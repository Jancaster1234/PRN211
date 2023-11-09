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
            LabelTitle = new Label();
            MessageIsListEmpty = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPasscodeRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvPasscodeRequests
            // 
            dgvPasscodeRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPasscodeRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasscodeRequests.Location = new Point(28, 135);
            dgvPasscodeRequests.Name = "dgvPasscodeRequests";
            dgvPasscodeRequests.RowHeadersWidth = 51;
            dgvPasscodeRequests.RowTemplate.Height = 29;
            dgvPasscodeRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasscodeRequests.Size = new Size(760, 294);
            dgvPasscodeRequests.TabIndex = 0;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTitle.Location = new Point(28, 83);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(299, 37);
            LabelTitle.TabIndex = 2;
            LabelTitle.Text = "Your passcode requests:";
            // 
            // MessageIsListEmpty
            // 
            MessageIsListEmpty.AutoSize = true;
            MessageIsListEmpty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MessageIsListEmpty.ForeColor = Color.IndianRed;
            MessageIsListEmpty.Location = new Point(38, 149);
            MessageIsListEmpty.Name = "MessageIsListEmpty";
            MessageIsListEmpty.Size = new Size(353, 35);
            MessageIsListEmpty.TabIndex = 7;
            MessageIsListEmpty.Text = "You have no passcode request";
            // 
            // frmStudentPasscodeRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MessageIsListEmpty);
            Controls.Add(LabelTitle);
            Controls.Add(dgvPasscodeRequests);
            Name = "frmStudentPasscodeRequestForm";
            Text = "frmStudentPasscodeRequestForm";
            Load += frmStudentPasscodeRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPasscodeRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPasscodeRequests;
        private Label LabelTitle;
        private Label MessageIsListEmpty;
    }
}