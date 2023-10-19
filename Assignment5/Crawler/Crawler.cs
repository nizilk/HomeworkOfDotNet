using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using static System.Net.WebRequestMethods;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

namespace Crawler
{
    public class Crawler
    {
        public Hashtable urls = new Hashtable();
        public Hashtable phones = new();
        public Queue<string> pending = new Queue<string>();
        private int count = 0;
        private int max = 10;
        public delegate void CrawlerUrlDelegate(UrlInfo urlInfo);
        public event CrawlerUrlDelegate CrawUrlEvent;

        public static readonly string PhoneDetectRegex = @"(0\d{2,3}-[1-9]\d{6,7}|1[3-9]\\d{9})";
        
        public static readonly string UrlDetectRegex = @"(href|HREF)\s*=\s*[""'](?<url>[^""'#>]+)[""']";
        
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        public string HostFilter { get; set; }
        public static string FileFilter = ".(html?|aspx|jsp|php)$|^[^.]*$";
        public void Run(int num, string args)
        {
            max = num;

            string startUrl = "https://cs.whu.edu.cn/";

            if (args.Length >= 1 && args != null)
            {
                startUrl = args;
                if (!Regex.IsMatch(startUrl, @"://")) startUrl = "https://" + startUrl;
            }

            Match m = Regex.Match(startUrl, urlParseRegex);
            string s = m.Groups["host"].Value;
            s = s.Split('.', 2)[1];
            HostFilter = s + "$";

            urls.Add(startUrl, false);
            pending.Enqueue(startUrl);

            new Thread(Crawl).Start();
        }

        public async void Crawl()
        {
            while (phones.Count <= max)
            {
                if (pending.Count == 0) continue;
                string url = pending.Dequeue();
                if (url == null) continue;
                if (urls[url] != null)
                {
                    if ((bool)urls[url]) { continue; }
                }
                    
                if (url == null) break;
                if (url == "") break;
                new Thread(() => this.Crawl(url)).Start();
                // count++;
            }
        }

        public void Crawl(string url)
        {
            string html = DownLoad(url, out UrlInfo urlInfo);
            Prase(urlInfo, html);
        }

        public string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { //完整路径
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }

        public string DownLoad(string url, out UrlInfo urlInfo)
        {
            string html = "";
            string state;
            string e = "";
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                html = webClient.DownloadString(url);

                string fileName = count.ToString();
                count++;
                System.IO.File.WriteAllText(fileName, html, Encoding.UTF8);
                state = "已爬取！";
            }
            catch (Exception ex)
            {
                state = "失败...";
                e = ex.Message;
            }
            
            urls[url] = true;
            urlInfo = new UrlInfo(url, state, e);
            urlInfo.PhoneNumber = "--";
            // CrawUrlEvent(urlInfo);
            return html;
        }

        public bool ifSkip(string url)
        {
            if (url == null || url == "" || url.Contains("javascript:")) return true;
            if (Regex.IsMatch(url, @"/rss$")) return true;

            Match linkUrlMatch = Regex.Match(url, urlParseRegex);

            string host = linkUrlMatch.Groups["host"].Value;
            string file = linkUrlMatch.Groups["file"].Value;
            

            if (!Regex.IsMatch(host, HostFilter)) return true;
            if (!Regex.IsMatch(file, FileFilter)) return true;
            return false;
        }

        public void Prase(UrlInfo info, string html)
        {
            string other;
            
            MatchCollection matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                linkUrl = FixUrl(linkUrl, info.Url);

                if (ifSkip(linkUrl)) continue;

                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string protocal = linkUrlMatch.Groups["protocal"].Value;
                string ns = Regex.Replace(linkUrl, protocal, "http");
                string s = Regex.Replace(linkUrl, protocal, "https");
                string f = Regex.Replace(linkUrl, protocal, "ftp");
                if(!linkUrl.EndsWith("/")) other = linkUrl + "/";
                else other = linkUrl.TrimEnd(new char[] { '/' });

                if (urls[ns]==null && urls[s]==null && urls[f]==null && urls[other]==null)
                { 
                    urls[linkUrl] = false; 
                    pending.Enqueue(linkUrl);
                }
            }

            MatchCollection phoneMatches = new Regex(PhoneDetectRegex).Matches(html);
            foreach (Match match in phoneMatches)
            {
                if (phones.Count >= max) return;
                string phone = match.Value;
                if (phones[phone]==null)
                {
                    phones[phone] = info.Url;
                    info.PhoneNumber = phone;
                    CrawUrlEvent(info);
                    //count++;
                }
            }
        }

    }
}