namespace StudentsManage_WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_sch = new System.Windows.Forms.DataGridView();
            this.comboBox_table = new System.Windows.Forms.ComboBox();
            this.dataGridView_class = new System.Windows.Forms.DataGridView();
            this.listView_log = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_logType = new System.Windows.Forms.ComboBox();
            this.textBox_logKey = new System.Windows.Forms.TextBox();
            this.button_logQuery = new System.Windows.Forms.Button();
            this.dataGridView_stu = new System.Windows.Forms.DataGridView();
            this.button_query = new System.Windows.Forms.Button();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.comboBox_column = new System.Windows.Forms.ComboBox();
            this.button_del = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_addSch = new System.Windows.Forms.Button();
            this.buttonUpdSch = new System.Windows.Forms.Button();
            this.button_addClass = new System.Windows.Forms.Button();
            this.buttonUpdClass = new System.Windows.Forms.Button();
            this.button_addStu = new System.Windows.Forms.Button();
            this.buttonUpdStu = new System.Windows.Forms.Button();
            this.bindingSourceSch = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceClass = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceStu = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStu)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.249223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.03632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.03632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.70283F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.70284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.244288F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_sch, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_table, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_class, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView_log, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_logType, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_logKey, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_logQuery, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_query, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_keyword, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_column, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_del, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_stu, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_addSch, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdSch, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_addClass, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdClass, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_addStu, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdStu, 6, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.06472F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.93528F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 1020);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView_sch
            // 
            this.dataGridView_sch.AllowUserToAddRows = false;
            this.dataGridView_sch.AllowUserToDeleteRows = false;
            this.dataGridView_sch.AllowUserToResizeRows = false;
            this.dataGridView_sch.AutoGenerateColumns = false;
            this.dataGridView_sch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.schoolnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView_sch, 2);
            this.dataGridView_sch.DataSource = this.bindingSourceSch;
            this.dataGridView_sch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_sch.Location = new System.Drawing.Point(29, 80);
            this.dataGridView_sch.MultiSelect = false;
            this.dataGridView_sch.Name = "dataGridView_sch";
            this.dataGridView_sch.RowHeadersVisible = false;
            this.dataGridView_sch.RowHeadersWidth = 62;
            this.dataGridView_sch.RowTemplate.Height = 30;
            this.dataGridView_sch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_sch.Size = new System.Drawing.Size(374, 472);
            this.dataGridView_sch.TabIndex = 1;
            this.dataGridView_sch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_sch_MouseDown);
            // 
            // comboBox_table
            // 
            this.comboBox_table.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_table.FormattingEnabled = true;
            this.comboBox_table.Items.AddRange(new object[] {
            "学校",
            "班级",
            "学生"});
            this.comboBox_table.Location = new System.Drawing.Point(92, 34);
            this.comboBox_table.Name = "comboBox_table";
            this.comboBox_table.Size = new System.Drawing.Size(121, 26);
            this.comboBox_table.TabIndex = 5;
            this.comboBox_table.SelectedIndexChanged += new System.EventHandler(this.comboBox_table_SelectedIndexChanged);
            // 
            // dataGridView_class
            // 
            this.dataGridView_class.AllowUserToAddRows = false;
            this.dataGridView_class.AllowUserToDeleteRows = false;
            this.dataGridView_class.AllowUserToResizeRows = false;
            this.dataGridView_class.AutoGenerateColumns = false;
            this.dataGridView_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_class.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.classnameDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView_class, 2);
            this.dataGridView_class.DataSource = this.bindingSourceClass;
            this.dataGridView_class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_class.Location = new System.Drawing.Point(409, 80);
            this.dataGridView_class.MultiSelect = false;
            this.dataGridView_class.Name = "dataGridView_class";
            this.dataGridView_class.RowHeadersVisible = false;
            this.dataGridView_class.RowHeadersWidth = 62;
            this.dataGridView_class.RowTemplate.Height = 30;
            this.dataGridView_class.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_class.Size = new System.Drawing.Size(246, 472);
            this.dataGridView_class.TabIndex = 2;
            this.dataGridView_class.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_class_MouseDown);
            // 
            // listView_log
            // 
            this.listView_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tableLayoutPanel1.SetColumnSpan(this.listView_log, 6);
            this.listView_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_log.HideSelection = false;
            this.listView_log.Location = new System.Drawing.Point(29, 698);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(1124, 280);
            this.listView_log.TabIndex = 3;
            this.listView_log.UseCompatibleStateImageBehavior = false;
            this.listView_log.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "操作类型";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "操作对象";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "操作记录";
            this.columnHeader4.Width = 444;
            // 
            // comboBox_logType
            // 
            this.comboBox_logType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_logType.FormattingEnabled = true;
            this.comboBox_logType.Items.AddRange(new object[] {
            "操作类型",
            "操作对象"});
            this.comboBox_logType.Location = new System.Drawing.Point(92, 658);
            this.comboBox_logType.Name = "comboBox_logType";
            this.comboBox_logType.Size = new System.Drawing.Size(121, 26);
            this.comboBox_logType.TabIndex = 7;
            // 
            // textBox_logKey
            // 
            this.textBox_logKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_logKey.Location = new System.Drawing.Point(252, 657);
            this.textBox_logKey.Name = "textBox_logKey";
            this.textBox_logKey.Size = new System.Drawing.Size(118, 28);
            this.textBox_logKey.TabIndex = 8;
            // 
            // button_logQuery
            // 
            this.button_logQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_logQuery.Location = new System.Drawing.Point(409, 653);
            this.button_logQuery.Name = "button_logQuery";
            this.button_logQuery.Size = new System.Drawing.Size(92, 36);
            this.button_logQuery.TabIndex = 9;
            this.button_logQuery.Text = "查询";
            this.button_logQuery.UseVisualStyleBackColor = true;
            this.button_logQuery.Click += new System.EventHandler(this.button_logQuery_Click);
            // 
            // dataGridView_stu
            // 
            this.dataGridView_stu.AllowUserToAddRows = false;
            this.dataGridView_stu.AllowUserToDeleteRows = false;
            this.dataGridView_stu.AllowUserToResizeRows = false;
            this.dataGridView_stu.AutoGenerateColumns = false;
            this.dataGridView_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView_stu, 2);
            this.dataGridView_stu.DataSource = this.bindingSourceStu;
            this.dataGridView_stu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_stu.Location = new System.Drawing.Point(661, 80);
            this.dataGridView_stu.MultiSelect = false;
            this.dataGridView_stu.Name = "dataGridView_stu";
            this.dataGridView_stu.RowHeadersVisible = false;
            this.dataGridView_stu.RowHeadersWidth = 62;
            this.dataGridView_stu.RowTemplate.Height = 30;
            this.dataGridView_stu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_stu.Size = new System.Drawing.Size(492, 472);
            this.dataGridView_stu.TabIndex = 0;
            this.dataGridView_stu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView_stu_MouseDown);
            // 
            // button_query
            // 
            this.button_query.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_query.Location = new System.Drawing.Point(563, 26);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(92, 43);
            this.button_query.TabIndex = 4;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_keyword.Location = new System.Drawing.Point(410, 33);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(118, 28);
            this.textBox_keyword.TabIndex = 6;
            // 
            // comboBox_column
            // 
            this.comboBox_column.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_column.FormattingEnabled = true;
            this.comboBox_column.Location = new System.Drawing.Point(250, 34);
            this.comboBox_column.Name = "comboBox_column";
            this.comboBox_column.Size = new System.Drawing.Size(121, 26);
            this.comboBox_column.TabIndex = 10;
            // 
            // button_del
            // 
            this.button_del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_del.Location = new System.Drawing.Point(990, 28);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(82, 38);
            this.button_del.TabIndex = 11;
            this.button_del.Text = "删除";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "序号";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // button_addSch
            // 
            this.button_addSch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_addSch.Location = new System.Drawing.Point(167, 564);
            this.button_addSch.Name = "button_addSch";
            this.button_addSch.Size = new System.Drawing.Size(46, 43);
            this.button_addSch.TabIndex = 12;
            this.button_addSch.Text = " + ";
            this.button_addSch.UseVisualStyleBackColor = true;
            this.button_addSch.Click += new System.EventHandler(this.button_addSch_Click);
            // 
            // buttonUpdSch
            // 
            this.buttonUpdSch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUpdSch.Location = new System.Drawing.Point(219, 564);
            this.buttonUpdSch.Name = "buttonUpdSch";
            this.buttonUpdSch.Size = new System.Drawing.Size(92, 43);
            this.buttonUpdSch.TabIndex = 13;
            this.buttonUpdSch.Text = "修改";
            this.buttonUpdSch.UseVisualStyleBackColor = true;
            this.buttonUpdSch.Click += new System.EventHandler(this.buttonUpdSch_Click);
            // 
            // button_addClass
            // 
            this.button_addClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_addClass.Location = new System.Drawing.Point(486, 564);
            this.button_addClass.Name = "button_addClass";
            this.button_addClass.Size = new System.Drawing.Size(43, 43);
            this.button_addClass.TabIndex = 14;
            this.button_addClass.Text = "+";
            this.button_addClass.UseVisualStyleBackColor = true;
            this.button_addClass.Click += new System.EventHandler(this.button_addClass_Click);
            // 
            // buttonUpdClass
            // 
            this.buttonUpdClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUpdClass.Location = new System.Drawing.Point(535, 564);
            this.buttonUpdClass.Name = "buttonUpdClass";
            this.buttonUpdClass.Size = new System.Drawing.Size(92, 43);
            this.buttonUpdClass.TabIndex = 15;
            this.buttonUpdClass.Text = "修改";
            this.buttonUpdClass.UseVisualStyleBackColor = true;
            this.buttonUpdClass.Click += new System.EventHandler(this.buttonUpdClass_Click);
            // 
            // button_addStu
            // 
            this.button_addStu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_addStu.Location = new System.Drawing.Point(859, 564);
            this.button_addStu.Name = "button_addStu";
            this.button_addStu.Size = new System.Drawing.Size(45, 43);
            this.button_addStu.TabIndex = 16;
            this.button_addStu.Text = "+";
            this.button_addStu.UseVisualStyleBackColor = true;
            this.button_addStu.Click += new System.EventHandler(this.button_addStu_Click);
            // 
            // buttonUpdStu
            // 
            this.buttonUpdStu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonUpdStu.Location = new System.Drawing.Point(910, 564);
            this.buttonUpdStu.Name = "buttonUpdStu";
            this.buttonUpdStu.Size = new System.Drawing.Size(92, 43);
            this.buttonUpdStu.TabIndex = 17;
            this.buttonUpdStu.Text = "修改";
            this.buttonUpdStu.UseVisualStyleBackColor = true;
            this.buttonUpdStu.Click += new System.EventHandler(this.buttonUpdStu_Click);
            // 
            // bindingSourceSch
            // 
            this.bindingSourceSch.DataSource = typeof(StudentsManage_Funcs.school);
            // 
            // bindingSourceClass
            // 
            this.bindingSourceClass.DataSource = typeof(StudentsManage_Funcs.classroom);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "student_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "学号";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "student_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "学生姓名";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn5.HeaderText = "性别";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "grade";
            this.dataGridViewTextBoxColumn6.HeaderText = "年级";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // bindingSourceStu
            // 
            this.bindingSourceStu.DataSource = typeof(StudentsManage_Funcs.student);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "序号";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // classnameDataGridViewTextBoxColumn
            // 
            this.classnameDataGridViewTextBoxColumn.DataPropertyName = "class_name";
            this.classnameDataGridViewTextBoxColumn.HeaderText = "班级名称";
            this.classnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classnameDataGridViewTextBoxColumn.Name = "classnameDataGridViewTextBoxColumn";
            this.classnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.classnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "序号";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 80;
            // 
            // schoolnameDataGridViewTextBoxColumn
            // 
            this.schoolnameDataGridViewTextBoxColumn.DataPropertyName = "school_name";
            this.schoolnameDataGridViewTextBoxColumn.HeaderText = "学校名称";
            this.schoolnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.schoolnameDataGridViewTextBoxColumn.Name = "schoolnameDataGridViewTextBoxColumn";
            this.schoolnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schoolnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 1020);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "学生管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_stu;
        private System.Windows.Forms.DataGridView dataGridView_sch;
        private System.Windows.Forms.DataGridView dataGridView_class;
        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.ComboBox comboBox_table;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comboBox_logType;
        private System.Windows.Forms.TextBox textBox_logKey;
        private System.Windows.Forms.Button button_logQuery;
        private System.Windows.Forms.BindingSource bindingSourceStu;
        private System.Windows.Forms.BindingSource bindingSourceClass;
        private System.Windows.Forms.BindingSource bindingSourceSch;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox_column;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button_addSch;
        private System.Windows.Forms.Button buttonUpdSch;
        private System.Windows.Forms.Button button_addClass;
        private System.Windows.Forms.Button buttonUpdClass;
        private System.Windows.Forms.Button button_addStu;
        private System.Windows.Forms.Button buttonUpdStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

