namespace Crawler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripContainer1 = new ToolStripContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btSearch = new Button();
            tbSearch = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tslbUrl = new ToolStripLabel();
            tstbUrl = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            tslbNum = new ToolStripLabel();
            tstbNum = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbtStart = new ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanel1);
            toolStripContainer1.ContentPanel.Size = new Size(928, 709);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(928, 744);
            toolStripContainer1.TabIndex = 6;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.759124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.9124088F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.32847F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Controls.Add(listView1, 0, 1);
            tableLayoutPanel1.Controls.Add(btSearch, 3, 0);
            tableLayoutPanel1.Controls.Add(tbSearch, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20, 20, 20, 30);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9547653F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.0452347F));
            tableLayoutPanel1.Size = new Size(928, 709);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            tableLayoutPanel1.SetColumnSpan(listView1, 5);
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(23, 101);
            listView1.Name = "listView1";
            listView1.Size = new Size(882, 575);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "序号";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "电话号码";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "网址";
            columnHeader3.Width = 530;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "状态";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "错误信息";
            columnHeader5.Width = 250;
            // 
            // btSearch
            // 
            btSearch.Anchor = AnchorStyles.None;
            btSearch.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btSearch.Location = new Point(734, 38);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(70, 42);
            btSearch.TabIndex = 1;
            btSearch.Text = "搜索";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.Location = new Point(192, 41);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(510, 35);
            tbSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(97, 49);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "关键词：";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tslbUrl, tstbUrl, toolStripSeparator1, tslbNum, tstbNum, toolStripSeparator2, tsbtStart });
            toolStrip1.Location = new Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(895, 35);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // tslbUrl
            // 
            tslbUrl.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tslbUrl.Name = "tslbUrl";
            tslbUrl.Size = new Size(69, 30);
            tslbUrl.Text = "网址：";
            // 
            // tstbUrl
            // 
            tstbUrl.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tstbUrl.Name = "tstbUrl";
            tstbUrl.Size = new Size(500, 35);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // tslbNum
            // 
            tslbNum.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tslbNum.Name = "tslbNum";
            tslbNum.Size = new Size(109, 30);
            tslbNum.Text = "电话个数：";
            // 
            // tstbNum
            // 
            tstbNum.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tstbNum.Name = "tstbNum";
            tstbNum.Size = new Size(100, 35);
            tstbNum.KeyPress += tstbNum_KeyPress;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // tsbtStart
            // 
            tsbtStart.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtStart.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tsbtStart.Image = (Image)resources.GetObject("tsbtStart.Image");
            tsbtStart.ImageTransparentColor = Color.Magenta;
            tsbtStart.Name = "tsbtStart";
            tsbtStart.Size = new Size(93, 30);
            tsbtStart.Text = "开始爬取";
            tsbtStart.Click += tsbtStart_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 744);
            Controls.Add(toolStripContainer1);
            MaximizeBox = false;
            MaximumSize = new Size(950, 800);
            MinimumSize = new Size(950, 800);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "爬虫";
            Load += MainForm_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox tbSearch;
        private Button btSearch;
        private ToolStrip toolStrip1;
        private ToolStripLabel tslbUrl;
        private ToolStripTextBox tstbUrl;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel tslbNum;
        private ToolStripTextBox tstbNum;
        private Label label1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbtStart;
    }
}