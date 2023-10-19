using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    public class UrlInfo : EventArgs
    {
        public string PhoneNumber { get; set; } = "";
        public string Url { get; } = "";
        public string State { get; } = "";
        public string ErrorMessage { get; } = "";
        public UrlInfo() { }

        public UrlInfo(string url, string state, string e = "")
        {
            Url = url;
            State = state;
            ErrorMessage = e;
        }

        public UrlInfo(string phone, string url, string state, string e = "")
        {
            PhoneNumber = phone;
            Url = url;
            State = state;
            ErrorMessage = e;
        }
    }
}
