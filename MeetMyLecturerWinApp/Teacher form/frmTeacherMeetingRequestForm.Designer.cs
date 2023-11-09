namespace MeetMyLecturerWinApp.Teacher_form
{
    partial class frmTeacherMeetingRequestForm
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
            btnOK = new Button();
            btnClearText = new Button();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            txtSlotId = new TextBox();
            txtStatus = new TextBox();
            slotId = new Label();
            endReviewedDate = new Label();
            startReviewedDate = new Label();
            status = new Label();
            endCreatedDate = new Label();
            startCreatedDate = new Label();
            dgvMeetingRequests = new DataGridView();
            MessageIsListEmpty = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMeetingRequests).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(481, 188);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 20;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(208, 188);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 19;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(545, 70);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(250, 27);
            dateTimePicker4.TabIndex = 15;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(545, 36);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(139, 70);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // txtSlotId
            // 
            txtSlotId.Location = new Point(481, 121);
            txtSlotId.Name = "txtSlotId";
            txtSlotId.Size = new Size(173, 27);
            txtSlotId.TabIndex = 13;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(155, 121);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(173, 27);
            txtStatus.TabIndex = 14;
            // 
            // slotId
            // 
            slotId.AutoSize = true;
            slotId.Location = new Point(395, 121);
            slotId.Name = "slotId";
            slotId.Size = new Size(52, 20);
            slotId.TabIndex = 7;
            slotId.Text = "Slot Id";
            // 
            // endReviewedDate
            // 
            endReviewedDate.AutoSize = true;
            endReviewedDate.Location = new Point(395, 75);
            endReviewedDate.Name = "endReviewedDate";
            endReviewedDate.Size = new Size(138, 20);
            endReviewedDate.TabIndex = 8;
            endReviewedDate.Text = "End Reviewed Date";
            // 
            // startReviewedDate
            // 
            startReviewedDate.AutoSize = true;
            startReviewedDate.Location = new Point(395, 36);
            startReviewedDate.Name = "startReviewedDate";
            startReviewedDate.Size = new Size(144, 20);
            startReviewedDate.TabIndex = 9;
            startReviewedDate.Text = "Start Reviewed Date";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(85, 121);
            status.Name = "status";
            status.Size = new Size(49, 20);
            status.TabIndex = 10;
            status.Text = "Status";
            // 
            // endCreatedDate
            // 
            endCreatedDate.AutoSize = true;
            endCreatedDate.Location = new Point(12, 70);
            endCreatedDate.Name = "endCreatedDate";
            endCreatedDate.Size = new Size(126, 20);
            endCreatedDate.TabIndex = 11;
            endCreatedDate.Text = "End Created Date";
            // 
            // startCreatedDate
            // 
            startCreatedDate.AutoSize = true;
            startCreatedDate.Location = new Point(6, 36);
            startCreatedDate.Name = "startCreatedDate";
            startCreatedDate.Size = new Size(132, 20);
            startCreatedDate.TabIndex = 12;
            startCreatedDate.Text = "Start Created Date";
            // 
            // dgvMeetingRequests
            // 
            dgvMeetingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeetingRequests.Location = new Point(58, 246);
            dgvMeetingRequests.Name = "dgvMeetingRequests";
            dgvMeetingRequests.RowHeadersWidth = 51;
            dgvMeetingRequests.RowTemplate.Height = 29;
            dgvMeetingRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeetingRequests.Size = new Size(688, 168);
            dgvMeetingRequests.TabIndex = 6;
            // 
            // MessageIsListEmpty
            // 
            MessageIsListEmpty.AutoSize = true;
            MessageIsListEmpty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MessageIsListEmpty.ForeColor = Color.IndianRed;
            MessageIsListEmpty.Location = new Point(83, 263);
            MessageIsListEmpty.Name = "MessageIsListEmpty";
            MessageIsListEmpty.Size = new Size(339, 35);
            MessageIsListEmpty.TabIndex = 21;
            MessageIsListEmpty.Text = "You have no meeting request";
            // 
            // frmTeacherMeetingRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MessageIsListEmpty);
            Controls.Add(btnOK);
            Controls.Add(btnClearText);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSlotId);
            Controls.Add(txtStatus);
            Controls.Add(slotId);
            Controls.Add(endReviewedDate);
            Controls.Add(startReviewedDate);
            Controls.Add(status);
            Controls.Add(endCreatedDate);
            Controls.Add(startCreatedDate);
            Controls.Add(dgvMeetingRequests);
            Name = "frmTeacherMeetingRequestForm";
            Text = "frmTeacherMeetingRequestForm";
            Load += frmStudentMeetingRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMeetingRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnClearText;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSlotId;
        private TextBox txtStatus;
        private Label slotId;
        private Label endReviewedDate;
        private Label startReviewedDate;
        private Label status;
        private Label endCreatedDate;
        private Label startCreatedDate;
        private DataGridView dgvMeetingRequests;
        private Label MessageIsListEmpty;
    }
}