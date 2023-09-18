namespace Assignment1_b
{
    partial class Form_Container
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
            PnlContainer = new Panel();
            SuspendLayout();
            // 
            // PnlContainer
            // 
            PnlContainer.Dock = DockStyle.Fill;
            PnlContainer.Location = new Point(0, 0);
            PnlContainer.Name = "PnlContainer";
            PnlContainer.Size = new Size(541, 360);
            PnlContainer.TabIndex = 0;
            // 
            // Form_Container
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 360);
            Controls.Add(PnlContainer);
            Name = "Form_Container";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "计算题";
            Load += Form_Container_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlContainer;
    }
}