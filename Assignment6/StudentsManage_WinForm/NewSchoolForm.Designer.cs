namespace StudentsManage_WinForm
{
    partial class NewSchoolForm
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
            this.textBoxSchName = new System.Windows.Forms.TextBox();
            this.labelSchName = new System.Windows.Forms.Label();
            this.labelSchAdd = new System.Windows.Forms.Label();
            this.textBoxSchAdd = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSchName
            // 
            this.textBoxSchName.Location = new System.Drawing.Point(224, 57);
            this.textBoxSchName.Name = "textBoxSchName";
            this.textBoxSchName.Size = new System.Drawing.Size(180, 28);
            this.textBoxSchName.TabIndex = 0;
            // 
            // labelSchName
            // 
            this.labelSchName.AutoSize = true;
            this.labelSchName.Location = new System.Drawing.Point(107, 60);
            this.labelSchName.Name = "labelSchName";
            this.labelSchName.Size = new System.Drawing.Size(98, 18);
            this.labelSchName.TabIndex = 1;
            this.labelSchName.Text = "学校名称：";
            // 
            // labelSchAdd
            // 
            this.labelSchAdd.AutoSize = true;
            this.labelSchAdd.Location = new System.Drawing.Point(107, 126);
            this.labelSchAdd.Name = "labelSchAdd";
            this.labelSchAdd.Size = new System.Drawing.Size(98, 18);
            this.labelSchAdd.TabIndex = 3;
            this.labelSchAdd.Text = "学校地址：";
            // 
            // textBoxSchAdd
            // 
            this.textBoxSchAdd.Location = new System.Drawing.Point(224, 123);
            this.textBoxSchAdd.Name = "textBoxSchAdd";
            this.textBoxSchAdd.Size = new System.Drawing.Size(180, 28);
            this.textBoxSchAdd.TabIndex = 2;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(224, 192);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(84, 42);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // NewSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 292);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelSchAdd);
            this.Controls.Add(this.textBoxSchAdd);
            this.Controls.Add(this.labelSchName);
            this.Controls.Add(this.textBoxSchName);
            this.Name = "NewSchoolForm";
            this.Tag = "school";
            this.Text = "NewSchoolForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSchName;
        private System.Windows.Forms.Label labelSchName;
        private System.Windows.Forms.Label labelSchAdd;
        private System.Windows.Forms.TextBox textBoxSchAdd;
        private System.Windows.Forms.Button buttonOk;
    }
}