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
    public partial class InputForm : Form
    {
        public delegate bool InputDelegate(double num, string pwd);
        public delegate void ResDelegate(double num);

        public event InputDelegate Input;
        public event ResDelegate Res;
        public event ResDelegate BigMoneyFetched;
        public InputForm()
        {
            InitializeComponent();
        }

        public InputForm(double max)
        {
            InitializeComponent();
            lbMaxNum.Text = max.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double)nudInput.Value >= 10000)
                {
                    BigMoneyFetched((double)nudInput.Value);
                }
                if (Input((double)nudInput.Value, tbPwd.Text))
                {
                    DialogResult = DialogResult.OK;
                    Res((double)nudInput.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
