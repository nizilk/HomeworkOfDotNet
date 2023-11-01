namespace StudentsManage_WinForm
{
    partial class NewStudentForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStuName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStuId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_F = new System.Windows.Forms.RadioButton();
            this.radioButton_M = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxClassId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(238, 379);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(84, 42);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "学生姓名：";
            // 
            // textBoxStuName
            // 
            this.textBoxStuName.Location = new System.Drawing.Point(238, 128);
            this.textBoxStuName.Name = "textBoxStuName";
            this.textBoxStuName.Size = new System.Drawing.Size(180, 28);
            this.textBoxStuName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "学号：";
            // 
            // textBoxStuId
            // 
            this.textBoxStuId.Location = new System.Drawing.Point(238, 70);
            this.textBoxStuId.Name = "textBoxStuId";
            this.textBoxStuId.Size = new System.Drawing.Size(180, 28);
            this.textBoxStuId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "年级：";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(238, 246);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(180, 28);
            this.textBoxGrade.TabIndex = 12;
            this.textBoxGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGrade_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "性别：";
            // 
            // radioButton_F
            // 
            this.radioButton_F.AutoSize = true;
            this.radioButton_F.Location = new System.Drawing.Point(238, 191);
            this.radioButton_F.Name = "radioButton_F";
            this.radioButton_F.Size = new System.Drawing.Size(87, 22);
            this.radioButton_F.TabIndex = 16;
            this.radioButton_F.TabStop = true;
            this.radioButton_F.Text = "female";
            this.radioButton_F.UseVisualStyleBackColor = true;
            // 
            // radioButton_M
            // 
            this.radioButton_M.AutoSize = true;
            this.radioButton_M.Location = new System.Drawing.Point(349, 191);
            this.radioButton_M.Name = "radioButton_M";
            this.radioButton_M.Size = new System.Drawing.Size(69, 22);
            this.radioButton_M.TabIndex = 17;
            this.radioButton_M.TabStop = true;
            this.radioButton_M.Text = "male";
            this.radioButton_M.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "班级编号：";
            // 
            // textBoxClassId
            // 
            this.textBoxClassId.Location = new System.Drawing.Point(238, 310);
            this.textBoxClassId.Name = "textBoxClassId";
            this.textBoxClassId.Size = new System.Drawing.Size(180, 28);
            this.textBoxClassId.TabIndex = 18;
            this.textBoxClassId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClassId_KeyPress);
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxClassId);
            this.Controls.Add(this.radioButton_M);
            this.Controls.Add(this.radioButton_F);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStuName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStuId);
            this.Name = "NewStudentForm";
            this.Text = "NewStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStuId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_F;
        private System.Windows.Forms.RadioButton radioButton_M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxClassId;
    }
}