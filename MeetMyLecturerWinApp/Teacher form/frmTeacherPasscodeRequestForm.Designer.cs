namespace MeetMyLecturerWinApp.Teacher_form
{
    partial class frmTeacherPasscodeRequestForm
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
            LabelTitle = new Label();
            dgvPasscodeRequests = new DataGridView();
            MessageIsListEmpty = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPasscodeRequests).BeginInit();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTitle.ForeColor = SystemColors.ControlLightLight;
            LabelTitle.Location = new Point(10, 62);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(245, 30);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Your passcode requests:";
            // 
            // dgvPasscodeRequests
            // 
            dgvPasscodeRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPasscodeRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasscodeRequests.Location = new Point(10, 101);
            dgvPasscodeRequests.Margin = new Padding(3, 2, 3, 2);
            dgvPasscodeRequests.Name = "dgvPasscodeRequests";
            dgvPasscodeRequests.RowHeadersWidth = 51;
            dgvPasscodeRequests.RowTemplate.Height = 29;
            dgvPasscodeRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasscodeRequests.Size = new Size(679, 220);
            dgvPasscodeRequests.TabIndex = 3;
            // 
            // MessageIsListEmpty
            // 
            MessageIsListEmpty.AutoSize = true;
            MessageIsListEmpty.BackColor = SystemColors.ButtonShadow;
            MessageIsListEmpty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MessageIsListEmpty.ForeColor = Color.IndianRed;
            MessageIsListEmpty.Location = new Point(26, 118);
            MessageIsListEmpty.Name = "MessageIsListEmpty";
            MessageIsListEmpty.Size = new Size(274, 28);
            MessageIsListEmpty.TabIndex = 8;
            MessageIsListEmpty.Text = "You have no passcode request";
            // 
            // frmTeacherPasscodeRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(MessageIsListEmpty);
            Controls.Add(LabelTitle);
            Controls.Add(dgvPasscodeRequests);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTeacherPasscodeRequestForm";
            Text = "frmTeacherPasscodeRequestForm";
            Load += frmStudentPasscodeRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPasscodeRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private DataGridView dgvPasscodeRequests;
        private Label MessageIsListEmpty;
    }
}