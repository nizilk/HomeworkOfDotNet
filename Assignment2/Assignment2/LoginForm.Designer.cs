namespace Assignment2
{
    partial class LoginForm
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
            tbAccId = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btLogin = new Button();
            tbPwd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbAccId
            // 
            tbAccId.Anchor = AnchorStyles.Left;
            tbAccId.Location = new Point(202, 82);
            tbAccId.Name = "tbAccId";
            tbAccId.Size = new Size(213, 30);
            tbAccId.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.81579F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.18421F));
            tableLayoutPanel1.Controls.Add(btLogin, 0, 3);
            tableLayoutPanel1.Controls.Add(tbPwd, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(tbAccId, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.1372566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.8627434F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(515, 328);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btLogin
            // 
            btLogin.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(btLogin, 2);
            btLogin.Location = new Point(201, 234);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(112, 34);
            btLogin.TabIndex = 4;
            btLogin.Text = "登录";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // tbPwd
            // 
            tbPwd.Anchor = AnchorStyles.Left;
            tbPwd.Location = new Point(202, 163);
            tbPwd.Name = "tbPwd";
            tbPwd.PasswordChar = '*';
            tbPwd.Size = new Size(213, 30);
            tbPwd.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(141, 166);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 2;
            label2.Text = "密码: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(87, 85);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 1;
            label1.Text = "请输入账号: ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 328);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登录";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbAccId;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox tbPwd;
        private Label label2;
        private Button btLogin;
    }
}