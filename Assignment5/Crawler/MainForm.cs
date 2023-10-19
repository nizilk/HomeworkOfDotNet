using System;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;

namespace Crawler
{
    public partial class MainForm : Form
    {
        private int count = 0;
        private string startUrl = "";
        private List<UrlInfo> urlInfos = new List<UrlInfo>();
        private Crawler crawler = new();
        public MainForm()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

        }

        public void PrintUrl(UrlInfo urlInfo)
        {
            lock (this)
            {
                if (urlInfo == null) return;
                count++;
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(count.ToString());
                item.SubItems.Add(urlInfo.PhoneNumber);
                item.SubItems.Add(urlInfo.Url);
                item.SubItems.Add(urlInfo.State);
                item.SubItems.Add(urlInfo.ErrorMessage);
            }
        }

        private void tstbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            crawler.CrawUrlEvent += PrintUrl;
        }

        private void tsbtStart_Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32("0" + tstbNum.Text);

            listView1.Items.Clear();
            startUrl = tstbUrl.Text;
            count = 0;

            listView1.BeginUpdate();
            crawler.Run(max, startUrl);
            listView1.EndUpdate();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string keywords = tbSearch.Text;
            string url = tstbUrl.Text;
            SearchForm searchForm = new SearchForm(keywords, url);
            searchForm.Show();
        }
    }
}