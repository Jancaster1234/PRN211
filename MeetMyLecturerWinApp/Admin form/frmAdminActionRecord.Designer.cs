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
            dgvActionRecords.Location = new Point(40, 38);
            dgvActionRecords.Name = "dgvActionRecords";
            dgvActionRecords.RowHeadersWidth = 51;
            dgvActionRecords.RowTemplate.Height = 29;
            dgvActionRecords.Size = new Size(721, 375);
            dgvActionRecords.TabIndex = 1;
            // 
            // frmAdminActionRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvActionRecords);
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