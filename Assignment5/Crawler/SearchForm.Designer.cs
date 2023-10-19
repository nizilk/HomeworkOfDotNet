using System.Windows.Forms;

namespace Crawler
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            webbInner = new WebBrowser();
            toolStripContainer1 = new ToolStripContainer();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            tstbUrl_s = new ToolStripTextBox();
            tsbtEnter = new ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webbInner
            // 
            webbInner.Dock = DockStyle.Fill;
            webbInner.Location = new Point(0, 0);
            webbInner.Name = "webbInner";
            webbInner.Size = new Size(897, 581);
            webbInner.TabIndex = 0;
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(webbInner);
            toolStripContainer1.ContentPanel.Size = new Size(897, 581);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(897, 616);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, tstbUrl_s, tsbtEnter });
            toolStrip1.Location = new Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(687, 35);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(69, 30);
            toolStripLabel1.Text = "网址：";
            // 
            // tstbUrl_s
            // 
            tstbUrl_s.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tstbUrl_s.Name = "tstbUrl_s";
            tstbUrl_s.Size = new Size(500, 35);
            // 
            // tsbtEnter
            // 
            tsbtEnter.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtEnter.Image = (Image)resources.GetObject("tsbtEnter.Image");
            tsbtEnter.ImageTransparentColor = Color.Magenta;
            tsbtEnter.Name = "tsbtEnter";
            tsbtEnter.Size = new Size(50, 30);
            tsbtEnter.Text = "转到";
            tsbtEnter.Click += tsbtEnter_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 616);
            Controls.Add(toolStripContainer1);
            Name = "SearchForm";
            Text = "浏览器";
            Load += SearchForm_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private WebBrowser webbInner;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox tstbUrl_s;
        private ToolStripButton tsbtEnter;
    }
}