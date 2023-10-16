namespace FileViewer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            tsslFilesNum = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            tvDirectory = new TreeView();
            imageListIcons = new ImageList(components);
            lvFiles = new ListView();
            colName = new ColumnHeader();
            colDate = new ColumnHeader();
            colType = new ColumnHeader();
            colSize = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            新建文件ToolStripMenuItem = new ToolStripMenuItem();
            新建文件夹ToolStripMenuItem = new ToolStripMenuItem();
            编辑ToolStripMenuItem = new ToolStripMenuItem();
            剪切ToolStripMenuItem = new ToolStripMenuItem();
            复制ToolStripMenuItem = new ToolStripMenuItem();
            粘贴ToolStripMenuItem = new ToolStripMenuItem();
            删除ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tstbPath = new ToolStripTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(1020, 540);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(1020, 633);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslFilesNum });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1020, 31);
            statusStrip1.TabIndex = 0;
            // 
            // tsslFilesNum
            // 
            tsslFilesNum.Name = "tsslFilesNum";
            tsslFilesNum.Size = new Size(75, 24);
            tsslFilesNum.Text = "0个项目";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDirectory);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lvFiles);
            splitContainer1.Size = new Size(1020, 540);
            splitContainer1.SplitterDistance = 310;
            splitContainer1.TabIndex = 0;
            // 
            // tvDirectory
            // 
            tvDirectory.Dock = DockStyle.Fill;
            tvDirectory.ImageIndex = 0;
            tvDirectory.ImageList = imageListIcons;
            tvDirectory.Location = new Point(0, 0);
            tvDirectory.Name = "tvDirectory";
            tvDirectory.SelectedImageIndex = 0;
            tvDirectory.Size = new Size(310, 540);
            tvDirectory.TabIndex = 0;
            tvDirectory.BeforeExpand += tvDirectory_BeforeExpand;
            tvDirectory.AfterSelect += tvDirectory_AfterSelect;
            // 
            // imageListIcons
            // 
            imageListIcons.ColorDepth = ColorDepth.Depth8Bit;
            imageListIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons.ImageStream");
            imageListIcons.TransparentColor = Color.Transparent;
            imageListIcons.Images.SetKeyName(0, "disk.png");
            imageListIcons.Images.SetKeyName(1, "folder.png");
            // 
            // lvFiles
            // 
            lvFiles.Columns.AddRange(new ColumnHeader[] { colName, colDate, colType, colSize });
            lvFiles.Dock = DockStyle.Fill;
            lvFiles.HideSelection = true;
            lvFiles.LabelWrap = false;
            lvFiles.Location = new Point(0, 0);
            lvFiles.Name = "lvFiles";
            lvFiles.Size = new Size(706, 540);
            lvFiles.SmallImageList = imageListIcons;
            lvFiles.TabIndex = 0;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.View = View.Details;
            lvFiles.ItemActivate += lvFiles_ItemActivate;
            // 
            // colName
            // 
            colName.Text = "名称";
            colName.Width = 200;
            // 
            // colDate
            // 
            colDate.Text = "修改日期";
            colDate.Width = 200;
            // 
            // colType
            // 
            colType.Text = "类型";
            colType.Width = 150;
            // 
            // colSize
            // 
            colSize.Text = "大小";
            colSize.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 编辑ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1020, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 新建文件ToolStripMenuItem, 新建文件夹ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(62, 28);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建文件ToolStripMenuItem
            // 
            新建文件ToolStripMenuItem.Name = "新建文件ToolStripMenuItem";
            新建文件ToolStripMenuItem.Size = new Size(200, 34);
            新建文件ToolStripMenuItem.Text = "‌新建文件";
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            新建文件夹ToolStripMenuItem.Size = new Size(200, 34);
            新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            // 
            // 编辑ToolStripMenuItem
            // 
            编辑ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 剪切ToolStripMenuItem, 复制ToolStripMenuItem, 粘贴ToolStripMenuItem, 删除ToolStripMenuItem });
            编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            编辑ToolStripMenuItem.Size = new Size(62, 28);
            编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 剪切ToolStripMenuItem
            // 
            剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            剪切ToolStripMenuItem.Size = new Size(146, 34);
            剪切ToolStripMenuItem.Text = "剪切";
            // 
            // 复制ToolStripMenuItem
            // 
            复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            复制ToolStripMenuItem.Size = new Size(146, 34);
            复制ToolStripMenuItem.Text = "复制";
            // 
            // 粘贴ToolStripMenuItem
            // 
            粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            粘贴ToolStripMenuItem.Size = new Size(146, 34);
            粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(146, 34);
            删除ToolStripMenuItem.Text = "删除";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tstbPath });
            toolStrip1.Location = new Point(4, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(522, 30);
            toolStrip1.TabIndex = 1;
            // 
            // tstbPath
            // 
            tstbPath.Name = "tstbPath";
            tstbPath.Size = new Size(500, 30);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 633);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "文件浏览器";
            Load += MainForm_Load;
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripContainer toolStripContainer1;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslFilesNum;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 新建文件ToolStripMenuItem;
        private ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private ToolStripMenuItem 编辑ToolStripMenuItem;
        private ToolStripMenuItem 剪切ToolStripMenuItem;
        private ToolStripMenuItem 复制ToolStripMenuItem;
        private ToolStripMenuItem 粘贴ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private TreeView tvDirectory;
        private ListView lvFiles;
        private ColumnHeader colName;
        private ColumnHeader colDate;
        private ColumnHeader colType;
        private ColumnHeader colSize;
        private ImageList imageListIcons;
        private ToolStrip toolStrip1;
        private ToolStripTextBox tstbPath;
        private ContextMenuStrip contextMenuStrip1;
    }
}