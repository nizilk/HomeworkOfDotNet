using StudentsManage_Funcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsManage_WinForm
{
    public delegate void InputEventHandler(string s1, string s2);
    
    public partial class NewSchoolForm : Form
    {
        public InputEventHandler InputHandler;
        public NewSchoolForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string str1 = textBoxSchName.Text;
            string str2 = textBoxSchAdd.Text;
            InputHandler(str1, str2);
            DialogResult = DialogResult.OK;
        }

        public void Display(string label1, string label2, string s1="", string s2="")
        {
            labelSchName.Text = label1;
            labelSchAdd.Text = label2;
            textBoxSchName.Text = s1;
            textBoxSchAdd.Text = s2;
        }
    }
}
