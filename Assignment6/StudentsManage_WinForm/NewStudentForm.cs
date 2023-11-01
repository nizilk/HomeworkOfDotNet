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
    public partial class NewStudentForm : Form
    {
        public delegate void InputEventHandler(student stu);
        public InputEventHandler InputStu;
        public NewStudentForm()
        {
            InitializeComponent();
        }

        private void textBoxGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            student stu = new student();
            stu.student_id = textBoxStuId.Text;
            stu.student_name = textBoxStuName.Text;
            stu.grade = Convert.ToInt32(textBoxGrade.Text);
            if (radioButton_F.Checked)
            {
                stu.gender = "female";
            }
            else
            {
                stu.gender = "male";
            }
            stu.class_id = Convert.ToInt32(textBoxClassId.Text);
            InputStu(stu);
            DialogResult = DialogResult.OK;
        }

        private void textBoxClassId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        public void DisplayStudent(student stu)
        {
            textBoxStuId.Text = stu.student_id;
            textBoxStuName.Text = stu.student_name;
            if (stu.gender == "female") radioButton_F.Checked = true;
            if (stu.gender == "male")   radioButton_M.Checked = true;
            textBoxGrade.Text = stu.grade.ToString();
            textBoxClassId.Text = stu.class_id.ToString();
        }
    }
}
