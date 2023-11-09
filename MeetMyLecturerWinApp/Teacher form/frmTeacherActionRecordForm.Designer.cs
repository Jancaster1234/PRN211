namespace MeetMyLecturerWinApp.Teacher_form
{
    partial class frmTeacherActionRecordForm
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
            MessageIsListEmpty = new Label();
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
            // MessageIsListEmpty
            // 
            MessageIsListEmpty.AutoSize = true;
            MessageIsListEmpty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MessageIsListEmpty.ForeColor = Color.IndianRed;
            MessageIsListEmpty.Location = new Point(55, 53);
            MessageIsListEmpty.Name = "MessageIsListEmpty";
            MessageIsListEmpty.Size = new Size(306, 35);
            MessageIsListEmpty.TabIndex = 8;
            MessageIsListEmpty.Text = "You have no action record";
            // 
            // frmTeacherActionRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MessageIsListEmpty);
            Controls.Add(dgvActionRecords);
            Name = "frmTeacherActionRecordForm";
            Text = "frmTeacherActionRecordForm";
            Load += frmStudentActionRecordForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActionRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvActionRecords;
        private Label MessageIsListEmpty;
    }
}