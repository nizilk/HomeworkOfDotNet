namespace Assignment1_b
{
    partial class FinalForm
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
            tableFin = new TableLayoutPanel();
            btBack = new Button();
            lbFinScore = new Label();
            label1 = new Label();
            label2 = new Label();
            tableFin.SuspendLayout();
            SuspendLayout();
            // 
            // tableFin
            // 
            tableFin.ColumnCount = 5;
            tableFin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.764681F));
            tableFin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0959F));
            tableFin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.2788372F));
            tableFin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0959F));
            tableFin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.764688F));
            tableFin.Controls.Add(btBack, 2, 2);
            tableFin.Controls.Add(lbFinScore, 2, 1);
            tableFin.Controls.Add(label1, 3, 1);
            tableFin.Controls.Add(label2, 1, 1);
            tableFin.Dock = DockStyle.Fill;
            tableFin.Location = new Point(0, 0);
            tableFin.Name = "tableFin";
            tableFin.RowCount = 4;
            tableFin.RowStyles.Add(new RowStyle(SizeType.Percent, 42.28856F));
            tableFin.RowStyles.Add(new RowStyle(SizeType.Percent, 57.71144F));
            tableFin.RowStyles.Add(new RowStyle(SizeType.Absolute, 128F));
            tableFin.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableFin.Size = new Size(541, 360);
            tableFin.TabIndex = 0;
            // 
            // btBack
            // 
            btBack.Anchor = AnchorStyles.None;
            btBack.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBack.Location = new Point(217, 226);
            btBack.Name = "btBack";
            btBack.Size = new Size(102, 49);
            btBack.TabIndex = 3;
            btBack.Text = "返回";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // lbFinScore
            // 
            lbFinScore.Anchor = AnchorStyles.None;
            lbFinScore.AutoSize = true;
            lbFinScore.Font = new Font("MV Boli", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lbFinScore.ForeColor = Color.Firebrick;
            lbFinScore.Location = new Point(206, 99);
            lbFinScore.Name = "lbFinScore";
            lbFinScore.Size = new Size(125, 68);
            lbFinScore.TabIndex = 4;
            lbFinScore.Text = "100";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(337, 133);
            label1.Margin = new Padding(3, 13, 3, 18);
            label1.Name = "label1";
            label1.Size = new Size(83, 36);
            label1.TabIndex = 5;
            label1.Text = "/ 100";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 79);
            label2.Name = "label2";
            label2.Size = new Size(142, 36);
            label2.TabIndex = 6;
            label2.Text = "您的得分 :";
            // 
            // FinalForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 360);
            Controls.Add(tableFin);
            Name = "FinalForm";
            Text = "Form1";
            tableFin.ResumeLayout(false);
            tableFin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableFin;
        private Button btBack;
        private Label lbFinScore;
        private Label label1;
        private Label label2;
    }
}