namespace Assignment1_b
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableStart = new TableLayoutPanel();
            btStart = new Button();
            lbsetNum = new Label();
            numTotal = new NumericUpDown();
            lbsetTime = new Label();
            numSec = new NumericUpDown();
            label1 = new Label();
            tableStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSec).BeginInit();
            SuspendLayout();
            // 
            // tableStart
            // 
            tableStart.ColumnCount = 6;
            tableStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.00162F));
            tableStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.99903F));
            tableStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.999352F));
            tableStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.999352F));
            tableStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.99903F));
            tableStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.00162F));
            tableStart.Controls.Add(btStart, 2, 3);
            tableStart.Controls.Add(lbsetNum, 1, 2);
            tableStart.Controls.Add(numTotal, 3, 2);
            tableStart.Controls.Add(lbsetTime, 1, 1);
            tableStart.Controls.Add(numSec, 3, 1);
            tableStart.Controls.Add(label1, 5, 1);
            tableStart.Dock = DockStyle.Fill;
            tableStart.Location = new Point(0, 0);
            tableStart.Name = "tableStart";
            tableStart.RowCount = 4;
            tableStart.RowStyles.Add(new RowStyle(SizeType.Percent, 53.37838F));
            tableStart.RowStyles.Add(new RowStyle(SizeType.Percent, 46.62162F));
            tableStart.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableStart.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            tableStart.Size = new Size(541, 360);
            tableStart.TabIndex = 2;
            // 
            // btStart
            // 
            btStart.Anchor = AnchorStyles.Top;
            tableStart.SetColumnSpan(btStart, 2);
            btStart.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btStart.Location = new Point(219, 227);
            btStart.Name = "btStart";
            btStart.Size = new Size(102, 49);
            btStart.TabIndex = 0;
            btStart.Text = "开始";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // lbsetNum
            // 
            lbsetNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbsetNum.AutoSize = true;
            tableStart.SetColumnSpan(lbsetNum, 2);
            lbsetNum.Location = new Point(167, 157);
            lbsetNum.Margin = new Padding(3);
            lbsetNum.Name = "lbsetNum";
            lbsetNum.Size = new Size(100, 24);
            lbsetNum.TabIndex = 2;
            lbsetNum.Text = "题目数量：";
            // 
            // numTotal
            // 
            numTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableStart.SetColumnSpan(numTotal, 2);
            numTotal.Location = new Point(285, 157);
            numTotal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTotal.Name = "numTotal";
            numTotal.Size = new Size(68, 30);
            numTotal.TabIndex = 1;
            numTotal.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lbsetTime
            // 
            lbsetTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbsetTime.AutoSize = true;
            tableStart.SetColumnSpan(lbsetTime, 2);
            lbsetTime.Location = new Point(167, 85);
            lbsetTime.Margin = new Padding(3);
            lbsetTime.Name = "lbsetTime";
            lbsetTime.Size = new Size(100, 24);
            lbsetTime.TabIndex = 3;
            lbsetTime.Text = "单题限时：";
            // 
            // numSec
            // 
            numSec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableStart.SetColumnSpan(numSec, 2);
            numSec.Location = new Point(285, 85);
            numSec.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numSec.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSec.Name = "numSec";
            numSec.Size = new Size(68, 30);
            numSec.TabIndex = 4;
            numSec.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 85);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(28, 24);
            label1.TabIndex = 5;
            label1.Text = "秒";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 360);
            Controls.Add(tableStart);
            Name = "StartForm";
            Text = "StartForm";
            tableStart.ResumeLayout(false);
            tableStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSec).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableStart;
        private Button btStart;
        private Label lbsetNum;
        private NumericUpDown numTotal;
        private Label lbsetTime;
        private NumericUpDown numSec;
        private Label label1;
    }
}