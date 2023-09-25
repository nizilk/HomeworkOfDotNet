namespace Assignment2
{
    partial class RecordsForm
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
            lvRecords = new ListView();
            time = new ColumnHeader();
            money = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(lvRecords, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(718, 538);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvRecords
            // 
            lvRecords.Columns.AddRange(new ColumnHeader[] { time, money });
            lvRecords.Dock = DockStyle.Fill;
            lvRecords.GridLines = true;
            lvRecords.Location = new Point(38, 29);
            lvRecords.Name = "lvRecords";
            lvRecords.Size = new Size(640, 478);
            lvRecords.TabIndex = 0;
            lvRecords.UseCompatibleStateImageBehavior = false;
            lvRecords.View = View.Details;
            // 
            // time
            // 
            time.Text = "交易时间";
            time.Width = 250;
            // 
            // money
            // 
            money.Text = "交易金额";
            money.TextAlign = HorizontalAlignment.Center;
            money.Width = 250;
            // 
            // RecordsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 538);
            Controls.Add(tableLayoutPanel1);
            Name = "RecordsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecordsForm";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvRecords;
        private ColumnHeader time;
        private ColumnHeader money;
    }
}