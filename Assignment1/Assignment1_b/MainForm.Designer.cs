namespace Assignment1_b
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
            tableMain = new TableLayoutPanel();
            btOK = new Button();
            lbIfRight = new Label();
            tbAnswer = new TextBox();
            lbFormula = new Label();
            lbFenshu = new Label();
            lbScore = new Label();
            lbCountdown = new Label();
            timerPerQuiz = new System.Windows.Forms.Timer(components);
            tableMain.SuspendLayout();
            SuspendLayout();
            // 
            // tableMain
            // 
            tableMain.ColumnCount = 6;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6745F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.11667F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.17462F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2430382F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1166658F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6745033F));
            tableMain.Controls.Add(lbIfRight, 4, 2);
            tableMain.Controls.Add(tbAnswer, 3, 2);
            tableMain.Controls.Add(lbFormula, 1, 2);
            tableMain.Controls.Add(lbFenshu, 3, 1);
            tableMain.Controls.Add(lbScore, 4, 1);
            tableMain.Controls.Add(lbCountdown, 2, 1);
            tableMain.Controls.Add(btOK, 1, 4);
            tableMain.Dock = DockStyle.Fill;
            tableMain.Location = new Point(0, 0);
            tableMain.Name = "tableMain";
            tableMain.RowCount = 6;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 42.990654F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 57.009346F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableMain.Size = new Size(541, 360);
            tableMain.TabIndex = 0;
            // 
            // btOK
            // 
            btOK.Anchor = AnchorStyles.None;
            tableMain.SetColumnSpan(btOK, 4);
            btOK.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btOK.Location = new Point(218, 246);
            btOK.Name = "btOK";
            btOK.Size = new Size(102, 49);
            btOK.TabIndex = 2;
            btOK.Text = "确定";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // lbIfRight
            // 
            lbIfRight.Anchor = AnchorStyles.None;
            lbIfRight.AutoSize = true;
            lbIfRight.Font = new Font("华文行楷", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbIfRight.ForeColor = Color.Green;
            lbIfRight.Location = new Point(397, 137);
            lbIfRight.Name = "lbIfRight";
            lbIfRight.Size = new Size(54, 37);
            lbIfRight.TabIndex = 5;
            lbIfRight.Text = "√";
            lbIfRight.TextAlign = ContentAlignment.MiddleCenter;
            lbIfRight.Visible = false;
            // 
            // tbAnswer
            // 
            tbAnswer.Anchor = AnchorStyles.None;
            tbAnswer.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbAnswer.Location = new Point(300, 132);
            tbAnswer.MaxLength = 9999;
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Size = new Size(84, 46);
            tbAnswer.TabIndex = 1;
            tbAnswer.KeyPress += tbAnswer_KeyPress;
            // 
            // lbFormula
            // 
            lbFormula.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableMain.SetColumnSpan(lbFormula, 2);
            lbFormula.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbFormula.Location = new Point(87, 130);
            lbFormula.Margin = new Padding(3);
            lbFormula.Name = "lbFormula";
            lbFormula.Size = new Size(200, 50);
            lbFormula.TabIndex = 0;
            lbFormula.Text = "90 + 90 =";
            lbFormula.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbFenshu
            // 
            lbFenshu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbFenshu.AutoSize = true;
            lbFenshu.Location = new Point(336, 49);
            lbFenshu.Name = "lbFenshu";
            lbFenshu.Size = new Size(55, 24);
            lbFenshu.TabIndex = 4;
            lbFenshu.Text = "分数 :";
            lbFenshu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Dock = DockStyle.Top;
            lbScore.Location = new Point(397, 49);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(54, 24);
            lbScore.TabIndex = 6;
            lbScore.Text = "0";
            // 
            // lbCountdown
            // 
            lbCountdown.AutoSize = true;
            lbCountdown.Location = new Point(114, 49);
            lbCountdown.Name = "lbCountdown";
            lbCountdown.Size = new Size(58, 24);
            lbCountdown.TabIndex = 3;
            lbCountdown.Text = "01:00";
            lbCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerPerQuiz
            // 
            timerPerQuiz.Enabled = true;
            timerPerQuiz.Interval = 1000;
            timerPerQuiz.Tick += timerPerQuiz_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 360);
            Controls.Add(tableMain);
            Name = "MainForm";
            Text = "计算题";
            tableMain.ResumeLayout(false);
            tableMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableMain;
        private Label lbFormula;
        private TextBox tbAnswer;
        private Button btOK;
        private Label lbFenshu;
        private Label lbCountdown;
        private Label lbIfRight;
        private Label lbScore;
        private System.Windows.Forms.Timer timerPerQuiz;
    }
}