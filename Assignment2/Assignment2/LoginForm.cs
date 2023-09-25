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
    public partial class LoginForm : Form
    {
        public delegate bool LoginDelegate(string id, string pwd);

        public event LoginDelegate login;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (login(tbAccId.Text, tbPwd.Text))
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
