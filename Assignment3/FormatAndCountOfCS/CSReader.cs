using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormatAndCountOfCS
{
    public class CSReader
    {
        public string AddressIn { get; set; } = "";
        public string AddressOut { get; set; } = "";
        public int OriginRow { get; set; } = 0;
        public int OriginWords { get; set; } = 0;
        public int AfterRow { get; set; } = 0;
        public int AfterWords { get; set; } = 0;
        public Dictionary<string, int> WordsCounter { get; set; } = new();
        public CSReader() { }

        public CSReader(string addIn, string addOut = "test.txt")
        {
            AddressIn = addIn;
            AddressOut = addOut;
        }

        public void Run()
        {
            int[] temp = Read(AddressIn);
            OriginRow = temp[0];
            OriginWords = temp[1];
            Rewrite(AddressIn, AddressOut);
            temp = Read(AddressOut, true);
            AfterRow = temp[0];
            AfterWords = temp[1];
            Console.WriteLine($"原行数={OriginRow}，原单词={OriginWords}");
            Console.WriteLine($"新行数={AfterRow}，新单词={AfterWords}");
            Console.WriteLine();
            foreach(KeyValuePair<string, int> kvp in WordsCounter)
            {
                Console.WriteLine($"单词：{kvp.Key}，个数：{kvp.Value}");
            }
        }

        public int[] Read(string add, bool dicFlag = false)
        {
            Dictionary<string, int> dic = new();
            int[] res = {0, 0};
            using FileStream fs = new(@add, FileMode.Open, FileAccess.Read);
            using StreamReader sr = new(fs);
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                res[0]++;
                foreach (Match match in Regex.Matches(str, @"\w+"))
                {
                    res[1]++;
                    if (dicFlag)
                    {
                        if (!dic.ContainsKey(match.Value))
                            dic.Add(match.Value, 1);
                        else
                            dic[match.Value]++;
                    }
                }
            }
            WordsCounter = dic;
            return res;
        }

        public static void Rewrite(string addIn, string addOut)
        {
            using FileStream fsRead = new(@addIn, FileMode.Open, FileAccess.Read);
            using FileStream fsWrite = new(@addOut, FileMode.Create, FileAccess.Write);
            using StreamReader sr = new(fsRead);
            using StreamWriter sw = new(fsWrite);
            string all = DelComment(sr.ReadToEnd());
            sw.WriteLine(all);
        }

        public static string DelComment(string input)
        {
            input = Regex.Replace(input, @"/\*[\s\S]*?\*/", "", RegexOptions.IgnoreCase);
            input = Regex.Replace(input, @"^\s*//[\s\S]*?$", "", RegexOptions.Multiline);
            input = Regex.Replace(input, @"^\s*$\n", "", RegexOptions.Multiline);
            input = Regex.Replace(input, @"^\s*//[\s\S]*", "", RegexOptions.Multiline);
            input = Regex.Replace(input, @"\s*//[\s\S]*?$", "", RegexOptions.Multiline);
            return input;
        }
    }
}
