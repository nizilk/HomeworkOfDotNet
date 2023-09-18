using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment1_b.StartForm;

namespace Assignment1_b
{
    public partial class FinalForm : Form
    {
        public event LoadDelegate loadStart;
        public TableLayoutPanel TableFin => tableFin;
        public FinalForm()
        {
            InitializeComponent();
        }

        public FinalForm(string score)
        {
            InitializeComponent();
            lbFinScore.Text = score;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            StartForm frm = new StartForm();
            frm.loadMain += this.loadStart;
            loadStart(frm.TableStart);
            this.Dispose();
            this.Close();
        }
    }
}
