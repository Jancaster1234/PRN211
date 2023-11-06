namespace MeetMyLecturerWinApp
{
    partial class frmStudentPasscodeRequestForm
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
            dgvPasscodeRequests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPasscodeRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvPasscodeRequests
            // 
            dgvPasscodeRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasscodeRequests.Location = new Point(67, 92);
            dgvPasscodeRequests.Name = "dgvPasscodeRequests";
            dgvPasscodeRequests.RowHeadersWidth = 51;
            dgvPasscodeRequests.RowTemplate.Height = 29;
            dgvPasscodeRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasscodeRequests.Size = new Size(645, 328);
            dgvPasscodeRequests.TabIndex = 0;
            // 
            // frmStudentPasscodeRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPasscodeRequests);
            Name = "frmStudentPasscodeRequestForm";
            Text = "frmStudentPasscodeRequestForm";
            Load += frmStudentPasscodeRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPasscodeRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPasscodeRequests;
    }
}