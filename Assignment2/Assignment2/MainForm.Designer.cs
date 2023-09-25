namespace Assignment2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbName = new Label();
            btBalance = new Button();
            lbAccId = new Label();
            btWithdraw = new Button();
            btDeposit = new Button();
            button4 = new Button();
            btRecords = new Button();
            btExit = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tableLayoutPanel1.Controls.Add(lbName, 1, 0);
            tableLayoutPanel1.Controls.Add(btBalance, 0, 1);
            tableLayoutPanel1.Controls.Add(lbAccId, 2, 0);
            tableLayoutPanel1.Controls.Add(btWithdraw, 0, 2);
            tableLayoutPanel1.Controls.Add(btDeposit, 0, 3);
            tableLayoutPanel1.Controls.Add(button4, 2, 1);
            tableLayoutPanel1.Controls.Add(btRecords, 2, 2);
            tableLayoutPanel1.Controls.Add(btExit, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.0438766F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.971838F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9718361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9718361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0406246F));
            tableLayoutPanel1.Size = new Size(718, 538);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.None;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(294, 57);
            lbName.Name = "lbName";
            lbName.Size = new Size(127, 36);
            lbName.TabIndex = 0;
            lbName.Text = "测试银行";
            // 
            // btBalance
            // 
            btBalance.Anchor = AnchorStyles.Right;
            btBalance.Location = new Point(114, 184);
            btBalance.Name = "btBalance";
            btBalance.Size = new Size(112, 34);
            btBalance.TabIndex = 1;
            btBalance.Text = "查余额";
            btBalance.UseVisualStyleBackColor = true;
            btBalance.Click += btBalance_Click;
            // 
            // lbAccId
            // 
            lbAccId.Anchor = AnchorStyles.Left;
            lbAccId.AutoSize = true;
            lbAccId.Location = new Point(490, 63);
            lbAccId.Name = "lbAccId";
            lbAccId.Size = new Size(208, 24);
            lbAccId.TabIndex = 2;
            lbAccId.Text = "账号：xxxxxxxxxxxxxxxx";
            // 
            // btWithdraw
            // 
            btWithdraw.Anchor = AnchorStyles.Right;
            btWithdraw.Location = new Point(114, 286);
            btWithdraw.Name = "btWithdraw";
            btWithdraw.Size = new Size(112, 34);
            btWithdraw.TabIndex = 3;
            btWithdraw.Text = "取款";
            btWithdraw.UseVisualStyleBackColor = true;
            btWithdraw.Click += btWithdraw_Click;
            // 
            // btDeposit
            // 
            btDeposit.Anchor = AnchorStyles.Right;
            btDeposit.Location = new Point(114, 388);
            btDeposit.Name = "btDeposit";
            btDeposit.Size = new Size(112, 34);
            btDeposit.TabIndex = 4;
            btDeposit.Text = "存款";
            btDeposit.UseVisualStyleBackColor = true;
            btDeposit.Click += btDeposit_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.Location = new Point(490, 184);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 5;
            button4.Text = "转账";
            button4.UseVisualStyleBackColor = true;
            // 
            // btRecords
            // 
            btRecords.Anchor = AnchorStyles.Left;
            btRecords.Location = new Point(490, 286);
            btRecords.Name = "btRecords";
            btRecords.Size = new Size(112, 34);
            btRecords.TabIndex = 6;
            btRecords.Text = "交易记录";
            btRecords.UseVisualStyleBackColor = true;
            btRecords.Click += btRecords_Click;
            // 
            // btExit
            // 
            btExit.Anchor = AnchorStyles.Left;
            btExit.Location = new Point(490, 388);
            btExit.Name = "btExit";
            btExit.Size = new Size(112, 34);
            btExit.TabIndex = 7;
            btExit.Text = "退出";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 538);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM机";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbName;
        private Button btBalance;
        private Label lbAccId;
        private Button btWithdraw;
        private Button btDeposit;
        private Button button4;
        private Button btRecords;
        private Button btExit;
    }
}