using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
        }

        public RecordsForm(Dictionary<DateTime, double> data)
        {
            InitializeComponent();
            lvRecords.BeginUpdate();
            foreach (var item in data)
            {
                ListViewItem lvi = lvRecords.Items.Add(item.Key.ToString("yyyy/MM/dd HH:mm"));
                lvi.SubItems.Add(item.Value.ToString("+#.##;-#.##;0"));
            }
            lvRecords.EndUpdate();
        }
    }
}
