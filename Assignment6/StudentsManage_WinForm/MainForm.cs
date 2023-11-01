using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsManage_Funcs;

namespace StudentsManage_WinForm
{
    public partial class MainForm : Form
    {
        private StuManageService service = new StuManageService();
        private List<Log> logs = new List<Log>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBox_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_column.Items.Clear();
            comboBox_column.Text = "";
            textBox_keyword.Text = "";
            switch (comboBox_table.SelectedIndex)
            {
                case 0:
                    comboBox_column.Items.Add("学校名称");
                    break;
                case 1:
                    comboBox_column.Items.Add("班级名称");
                    break;
                case 2:
                    comboBox_column.Items.Add("学号");
                    comboBox_column.Items.Add("学生姓名");
                    comboBox_column.Items.Add("性别");
                    comboBox_column.Items.Add("年级");
                    break;
            }
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            string keyword = textBox_keyword.Text;

            switch (comboBox_column.Text)
            {
                case "学校名称":
                    var q1 = service.QuerySchool_name(keyword);
                    bindingSourceSch.DataSource = q1;
                    break;
                case "班级名称":
                    var q2 = service.QueryClass_name(keyword);
                    bindingSourceClass.DataSource = q2;
                    break;
                case "学号":
                    var q3 = service.QueryStudent_id(keyword);
                    bindingSourceStu.DataSource = q3;
                    break;
                case "学生姓名":
                    var q4 = service.QueryStudent_name(keyword);
                    bindingSourceStu.DataSource = q4;
                    break;
                case "性别":
                    var q5 = service.QueryStudent_gender(keyword);
                    bindingSourceStu.DataSource = q5;
                    break;
                case "年级":
                    var q6 = service.QueryStudent_grade(Convert.ToInt32(keyword));
                    bindingSourceStu.DataSource = q6;
                    break;
                default:
                    break;
            }

            PrintLog(new Log("查询", comboBox_table.Text, comboBox_column.Text+" = "+keyword));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataRefresh();
            listView_log.Items.Clear();
        }

        public DataGridViewRow GetClickedRow(DataGridView dgv, int mouseY)
        {
            if (dgv.FirstDisplayedScrollingRowIndex < 0)
            {
                return null;
            }
            if (dgv.ColumnHeadersVisible == true && mouseY <= dgv.ColumnHeadersHeight)
            {
                return null;
            }
            int index = dgv.FirstDisplayedScrollingRowIndex;
            int displayedCount = dgv.DisplayedRowCount(true);
            for (int i = 1; i <= displayedCount;)
            {
                if (dgv.Rows[index].Visible == true)
                {
                    Rectangle rect = dgv.GetRowDisplayRectangle(index, true);
                    if (rect.Top <= mouseY && mouseY < rect.Bottom)
                    {
                        return dgv.Rows[index];
                    }
                    i++;
                }
                index++;
            }
            return null;
        }

        public DataGridViewColumn GetClickedColumn(DataGridView dgv, int mouseX)
        {
            if (dgv.FirstDisplayedScrollingColumnIndex < 0)
            {
                return null;
            }
            if (dgv.RowHeadersVisible == true && mouseX <= dgv.RowHeadersWidth)
            {
                return null;
            }
            int index = dgv.FirstDisplayedScrollingColumnIndex;
            int displayedCount = dgv.DisplayedColumnCount(true);
            for (int i = 1; i <= displayedCount;)
            {
                if (dgv.Columns[index].Visible == true)
                {
                    Rectangle rect = dgv.GetColumnDisplayRectangle(index, true);
                    if (rect.Top <= mouseX && mouseX < rect.Bottom)
                    {
                        return dgv.Columns[index];
                    }
                    i++;
                }
                index++;
            }
            return null;
        }

        private List<string> GetRowId(DataGridView dgv)
        {
            List<string> rowId = new List<string>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {

                if ((bool)dgv.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    rowId.Add(dgv.Rows[i].Cells[1].Value.ToString());
                }
            }
            return rowId;
        }

        private void dataGridView_sch_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            DataGridViewRow clickedRow = GetClickedRow(dgv, e.Y);
            DataGridViewColumn clickedColumn = GetClickedColumn(dgv, e.X);
            if (clickedRow == null || clickedColumn == null)
            {
                dgv.ClearSelection();
            }
        }

        private void dataGridView_class_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            DataGridViewRow clickedRow = GetClickedRow(dgv, e.Y);
            DataGridViewColumn clickedColumn = GetClickedColumn(dgv, e.X);
            if (clickedRow == null || clickedColumn == null)
            {
                dgv.ClearSelection();
            }
        }

        private void dataGridView_stu_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            DataGridViewRow clickedRow = GetClickedRow(dgv, e.Y);
            DataGridViewColumn clickedColumn = GetClickedColumn(dgv, e.X);
            if (clickedRow == null || clickedColumn == null)
            {
                dgv.ClearSelection();
            }
        }

        public void DataRefresh()
        {
            bindingSourceSch.DataSource = service.AllSchools;
            bindingSourceClass.DataSource = bindingSourceSch;
            bindingSourceClass.DataMember = "classroom";
            bindingSourceStu.DataSource = bindingSourceClass;
            bindingSourceStu.DataMember = "student";

            dataGridView_sch.ClearSelection();
            dataGridView_class.ClearSelection();
            dataGridView_stu.ClearSelection();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                string tar = "", content = "";
                List<string> rows = GetRowId(dataGridView_sch);
                if (rows != null && rows.Count > 0)
                {
                    tar += "学校, ";
                    content += rows.Count.ToString() + "条学校, ";
                }
                rows.ForEach(o =>
                {
                    service.DeleteSchool(Convert.ToInt32(o));
                });
                rows = GetRowId(dataGridView_class);
                if (rows != null && rows.Count > 0)
                {
                    tar += "班级, ";
                    content += rows.Count.ToString() + "条班级, ";
                }
                rows.ForEach(o =>
                {
                    service.DeleteClass(Convert.ToInt32(o));
                });
                rows = GetRowId(dataGridView_stu);
                if (rows != null && rows.Count > 0)
                {
                    tar += "学生";
                    content += rows.Count.ToString() + "条学生";
                }
                rows.ForEach(o =>
                {
                    service.DeleteStudent(Convert.ToInt32(o));
                });

                DataRefresh();

                PrintLog(new Log("删除", tar, content));
            };
        }

        private void button_logQuery_Click(object sender, EventArgs e)
        {
            string kw = textBox_logKey.Text;
            int i = 0;
            List<Log> q = new List<Log>();
            listView_log.Items.Clear();
            listView_log.BeginUpdate();

            switch(comboBox_logType.SelectedIndex)
            {
                case 0:
                    q = logs.Where(l => l.Type == kw).ToList();
                    break;
                case 1:
                    q = logs.Where(l => l.Target == kw).ToList();
                    break;
                default:
                    q = logs;
                    break;
            }

            foreach (var l in q)
            {
                i++;
                ListViewItem item = listView_log.Items.Add(i.ToString());
                item.SubItems.Add(l.Type);
                item.SubItems.Add(l.Target);
                item.SubItems.Add(l.Content);
            }

            listView_log.EndUpdate();
        }

        private void button_addSch_Click(object sender, EventArgs e)
        {
            NewSchoolForm schoolForm = new NewSchoolForm();
            schoolForm.Display("学校名称：", "学校地址：");
            schoolForm.InputHandler += (string s1, string s2) => {
                school sch = new school();
                sch.id = service.SchoolNum + 1;
                sch.school_name = s1;
                sch.address = s2;
                service.AddSchool(sch);
                PrintLog(new Log("增加", "学校", service.PrintSchool(sch)));
            };
            schoolForm.ShowDialog();
        }

        private void buttonUpdSch_Click(object sender, EventArgs e)
        {
            List<string> index = GetRowId(dataGridView_stu);
            if (index is null) return;
            if (index.Count > 1)
            {
                DialogResult cant = MessageBox.Show("请选择修改条目", "提示", MessageBoxButtons.OK);
                return;
            }
            index.ForEach(x =>
            {
                var q = service.QuerySchool_id(Convert.ToInt32(x));
                NewSchoolForm schoolForm = new NewSchoolForm();
                schoolForm.Display("学校名称：", "学校地址：", q.school_name, q.address);
                schoolForm.InputHandler += (string s1, string s2) =>
                {
                    school sch = new school
                    {
                        id = service.SchoolNum + 1,
                        school_name = s1,
                        address = s2
                    };
                    service.UpdateSchool(Convert.ToInt32(x), sch);
                    PrintLog(new Log("修改", "学校", "new: " + service.PrintSchool(sch)));
                };
                schoolForm.ShowDialog();
            });
        }

        private void button_addClass_Click(object sender, EventArgs e)
        {
            NewSchoolForm schoolForm = new NewSchoolForm();
            schoolForm.Display("班级名称：", "学校序号：");
            schoolForm.InputHandler += (string s1, string s2) => {
                classroom cs = new classroom();
                cs.id = service.ClassNum + 1;
                cs.class_name = s1;
                cs.school_id = Convert.ToInt32(s2);
                service.AddClass(cs);
                PrintLog(new Log("增加", "班级", "name = " + cs.class_name));
            };
            schoolForm.ShowDialog();
        }

        private void buttonUpdClass_Click(object sender, EventArgs e)
        {
            List<string> index = GetRowId(dataGridView_stu);
            if (index is null) return;
            if (index.Count > 1)
            {
                DialogResult cant = MessageBox.Show("请选择修改条目", "提示", MessageBoxButtons.OK);
                return;
            }
            index.ForEach(x =>
            {
                var q = service.QueryClass_id(Convert.ToInt32(x));
                NewSchoolForm schoolForm = new NewSchoolForm();
                schoolForm.Display("班级名称：", "学校序号：", q.class_name, q.school_id.ToString());
                schoolForm.InputHandler += (string s1, string s2) =>
                {
                    classroom cs = new classroom
                    {
                        id = service.ClassNum + 1,
                        class_name = s1,
                        school_id = Convert.ToInt32(s2)
                    };
                    service.UpdateClass(Convert.ToInt32(x), cs);
                    PrintLog(new Log("修改", "学校", "new: " + cs.class_name));
                };
                schoolForm.ShowDialog();
            });
        }

        private void button_addStu_Click(object sender, EventArgs e)
        {
            NewStudentForm studentForm = new NewStudentForm();
            studentForm.InputStu += (student stu) => {
                stu.id = service.StudentNum + 1;
                service.AddStudent(stu);
                PrintLog(new Log("增加", "学生", service.PrintStudent(stu)));
            };
            studentForm.ShowDialog();
        }

        private void buttonUpdStu_Click(object sender, EventArgs e)
        {
            List<string> index = GetRowId(dataGridView_stu);
            if (index is null) return;
            if (index.Count > 1)
            {
                DialogResult cant = MessageBox.Show("请选择修改条目", "提示", MessageBoxButtons.OK);
                return;
            }
            index.ForEach(x =>
            {
                var q = service.QueryStudent(Convert.ToInt32(x));
                NewStudentForm studentForm = new NewStudentForm();
                studentForm.DisplayStudent(q);
                studentForm.InputStu += (student stu) =>
                {
                    stu.id = service.StudentNum + 1;
                    service.UpdateStudent(Convert.ToInt32(x), stu);
                    PrintLog(new Log("修改", "学生", "new: " + service.PrintStudent(stu)));
                };
                studentForm.ShowDialog();
            });
        }

        public void PrintLog(Log log)
        {
            logs.Add(log);
            listView_log.BeginUpdate();
            ListViewItem item = listView_log.Items.Add((logs.Count).ToString());
            item.SubItems.Add(log.Type);
            item.SubItems.Add(log.Target);
            item.SubItems.Add(log.Content);
            listView_log.EndUpdate();
        }
    }

    public class Log
    {
        public string Type { get; set; } = "";
        public string Target { get; set; } = "";
        public string Content { get; set; } = "";
        public Log() { }
        public Log(string type, string target, string content)
        {
            Type = type;
            Target = target;
            Content = content;
        }
    }
}
