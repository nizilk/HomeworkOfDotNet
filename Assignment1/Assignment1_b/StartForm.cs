using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_b
{
    public partial class StartForm : Form
    {
        public delegate void LoadDelegate(Control control);
        public event LoadDelegate loadMain;
        public MainForm frm = new MainForm();
        public StartForm()
        {
            InitializeComponent();
        }

        public TableLayoutPanel TableStart => tableStart;

        private void btStart_Click(object sender, EventArgs e)
        {
            frm = new MainForm((int)numSec.Value, (int)numTotal.Value);
            frm.loadFin += this.loadMain;
            this.loadMain(frm.TableMain);
            this.Dispose();
            this.Close();
        }
    }
}
