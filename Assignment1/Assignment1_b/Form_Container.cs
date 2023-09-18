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
    public partial class Form_Container : Form
    {
        public static StartForm start { get; set; } = new StartForm();
        public Form_Container()
        {
            InitializeComponent();
        }

        public void LoadChildPage(Control cnl)
        {
            PnlContainer.Controls.Clear();
            PnlContainer.Controls.Add(cnl);
            cnl.Show();
        }

        private void Form_Container_Load(object sender, EventArgs e)
        {
            LoadChildPage(start.TableStart);
            start.loadMain += LoadChildPage;
        }
    }
}
