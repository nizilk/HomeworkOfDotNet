namespace Assignment2
{
    partial class InputForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btOK = new Button();
            label1 = new Label();
            nudInput = new NumericUpDown();
            lbMaxNum = new Label();
            label2 = new Label();
            label3 = new Label();
            tbPwd = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInput).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btOK, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(nudInput, 1, 1);
            tableLayoutPanel1.Controls.Add(lbMaxNum, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(tbPwd, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6969681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3030319F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.Size = new Size(515, 324);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btOK
            // 
            btOK.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.SetColumnSpan(btOK, 2);
            btOK.Location = new Point(201, 235);
            btOK.Name = "btOK";
            btOK.Size = new Size(112, 34);
            btOK.TabIndex = 4;
            btOK.Text = "确定";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(150, 88);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 1;
            label1.Text = "请输入金额:";
            // 
            // nudInput
            // 
            nudInput.Anchor = AnchorStyles.Left;
            nudInput.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudInput.Location = new Point(260, 85);
            nudInput.Margin = new Padding(3, 0, 3, 0);
            nudInput.Maximum = new decimal(new int[] { 6255555, 0, 0, 0 });
            nudInput.Name = "nudInput";
            nudInput.Size = new Size(180, 30);
            nudInput.TabIndex = 5;
            // 
            // lbMaxNum
            // 
            lbMaxNum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbMaxNum.AutoSize = true;
            lbMaxNum.Location = new Point(260, 38);
            lbMaxNum.Name = "lbMaxNum";
            lbMaxNum.Size = new Size(65, 24);
            lbMaxNum.TabIndex = 3;
            lbMaxNum.Text = "10000";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(168, 38);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 2;
            label2.Text = "最大额度:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(204, 173);
            label3.Name = "label3";
            label3.Size = new Size(50, 24);
            label3.TabIndex = 6;
            label3.Text = "密码:";
            // 
            // tbPwd
            // 
            tbPwd.Anchor = AnchorStyles.Left;
            tbPwd.Location = new Point(260, 170);
            tbPwd.Name = "tbPwd";
            tbPwd.PasswordChar = '*';
            tbPwd.Size = new Size(150, 30);
            tbPwd.TabIndex = 7;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 324);
            Controls.Add(tableLayoutPanel1);
            Name = "InputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label lbMaxNum;
        private Button btOK;
        private NumericUpDown nudInput;
        private Label label3;
        private TextBox tbPwd;
    }
}