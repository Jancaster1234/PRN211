namespace MeetMyLecturerWinApp.Admin_form
{
    partial class frmAdminActionRecord
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
            dgvActionRecords = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvActionRecords).BeginInit();
            SuspendLayout();
            // 
            // dgvActionRecords
            // 
            dgvActionRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActionRecords.Location = new Point(35, 28);
            dgvActionRecords.Margin = new Padding(3, 2, 3, 2);
            dgvActionRecords.Name = "dgvActionRecords";
            dgvActionRecords.RowHeadersWidth = 51;
            dgvActionRecords.RowTemplate.Height = 29;
            dgvActionRecords.Size = new Size(631, 281);
            dgvActionRecords.TabIndex = 1;
            // 
            // frmAdminActionRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(dgvActionRecords);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdminActionRecord";
            Text = "frmAdminActionRecord";
            Load += frmAdminActionRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActionRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvActionRecords;
    }
}