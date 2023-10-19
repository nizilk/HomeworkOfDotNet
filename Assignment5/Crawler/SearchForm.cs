using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Crawler
{
    public partial class SearchForm : Form
    {
        public string Url { get; set; } = "https://www.baidu.com";
        public string KeyWord { get; set; } = "";
        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(string keyword, string url = "")
        {
            KeyWord = keyword;
            if (url.Length >= 1 && url != null)
            {
                Url = url;
                if (!Regex.IsMatch(Url, @"://")) Url = "https://" + Url;
            }

            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            if (KeyWord.Length > 0 && KeyWord != null)
            {
                Url = GetUri_Baidu(KeyWord);
            }
            tstbUrl_s.Text = Url;
            webbInner.Navigate(Url);
        }

        public string GetUri_Baidu(string keyWord)
        {
            StringBuilder stringBuilder = new();
            byte[] bs = Encoding.UTF8.GetBytes(keyWord);
            for (int i = 0; i < bs.Length; i++)
            {
                stringBuilder.Append(@"%" + Convert.ToString(bs[i], 16));
            }

            return String.Format("https://www.baidu.com/s?wd={0}&rsv_spt=1&rsv_iqid=0x88b43a5c00074f90&issp=1&f=8&rsv_bp=1&rsv_idx=2&ie=utf-8&tn=baiduhome_pg&rsv_enter=1&rsv_sug3=10&rsv_sug1=2&rsv_sug7=100", stringBuilder.ToString());
        }

        private void tsbtEnter_Click(object sender, EventArgs e)
        {
            webbInner.Navigate(tstbUrl_s.Text);
        }
    }
}