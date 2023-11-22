namespace MeetMyLecturerWinApp
{
    partial class frmStudentMeetingRequestForm
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
            dgvMeetingRequests = new DataGridView();
            startCreatedDate = new Label();
            endCreatedDate = new Label();
            status = new Label();
            startReviewedDate = new Label();
            endReviewedDate = new Label();
            slotId = new Label();
            txtStatus = new TextBox();
            txtSlotId = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            btnClearText = new Button();
            btnOK = new Button();
            MessageIsListEmpty = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMeetingRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvMeetingRequests
            // 
            dgvMeetingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeetingRequests.Location = new Point(16, 175);
            dgvMeetingRequests.Margin = new Padding(3, 2, 3, 2);
            dgvMeetingRequests.Name = "dgvMeetingRequests";
            dgvMeetingRequests.RowHeadersWidth = 51;
            dgvMeetingRequests.RowTemplate.Height = 29;
            dgvMeetingRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeetingRequests.Size = new Size(664, 154);
            dgvMeetingRequests.TabIndex = 0;
            // 
            // startCreatedDate
            // 
            startCreatedDate.AutoSize = true;
            startCreatedDate.Location = new Point(10, 16);
            startCreatedDate.Name = "startCreatedDate";
            startCreatedDate.Size = new Size(102, 15);
            startCreatedDate.TabIndex = 1;
            startCreatedDate.Text = "Start Created Date";
            // 
            // endCreatedDate
            // 
            endCreatedDate.AutoSize = true;
            endCreatedDate.Location = new Point(16, 41);
            endCreatedDate.Name = "endCreatedDate";
            endCreatedDate.Size = new Size(98, 15);
            endCreatedDate.TabIndex = 1;
            endCreatedDate.Text = "End Created Date";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(80, 80);
            status.Name = "status";
            status.Size = new Size(39, 15);
            status.TabIndex = 1;
            status.Text = "Status";
            // 
            // startReviewedDate
            // 
            startReviewedDate.AutoSize = true;
            startReviewedDate.Location = new Point(351, 16);
            startReviewedDate.Name = "startReviewedDate";
            startReviewedDate.Size = new Size(111, 15);
            startReviewedDate.TabIndex = 1;
            startReviewedDate.Text = "Start Reviewed Date";
            // 
            // endReviewedDate
            // 
            endReviewedDate.AutoSize = true;
            endReviewedDate.Location = new Point(351, 45);
            endReviewedDate.Name = "endReviewedDate";
            endReviewedDate.Size = new Size(107, 15);
            endReviewedDate.TabIndex = 1;
            endReviewedDate.Text = "End Reviewed Date";
            // 
            // slotId
            // 
            slotId.AutoSize = true;
            slotId.Location = new Point(351, 80);
            slotId.Name = "slotId";
            slotId.Size = new Size(40, 15);
            slotId.TabIndex = 1;
            slotId.Text = "Slot Id";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(141, 80);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(152, 23);
            txtStatus.TabIndex = 2;
            // 
            // txtSlotId
            // 
            txtSlotId.Location = new Point(426, 80);
            txtSlotId.Margin = new Padding(3, 2, 3, 2);
            txtSlotId.Name = "txtSlotId";
            txtSlotId.Size = new Size(152, 23);
            txtSlotId.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 16);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(127, 41);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(482, 16);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(219, 23);
            dateTimePicker3.TabIndex = 3;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(482, 41);
            dateTimePicker4.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(219, 23);
            dateTimePicker4.TabIndex = 3;
            // 
            // btnClearText
            // 
            btnClearText.ForeColor = SystemColors.ActiveCaptionText;
            btnClearText.Location = new Point(187, 130);
            btnClearText.Margin = new Padding(3, 2, 3, 2);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(82, 22);
            btnClearText.TabIndex = 4;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.ForeColor = SystemColors.ActiveCaptionText;
            btnOK.Location = new Point(426, 130);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 22);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // MessageIsListEmpty
            // 
            MessageIsListEmpty.AutoSize = true;
            MessageIsListEmpty.BackColor = SystemColors.ButtonShadow;
            MessageIsListEmpty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MessageIsListEmpty.ForeColor = Color.IndianRed;
            MessageIsListEmpty.Location = new Point(30, 185);
            MessageIsListEmpty.Name = "MessageIsListEmpty";
            MessageIsListEmpty.Size = new Size(265, 28);
            MessageIsListEmpty.TabIndex = 6;
            MessageIsListEmpty.Text = "You have no meeting request";
            // 
            // frmStudentMeetingRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(713, 338);
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
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmStudentMeetingRequestForm";
            Text = "frmStudentMeetingRequestForm";
            Load += frmStudentMeetingRequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMeetingRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMeetingRequests;
        private Label startCreatedDate;
        private Label endCreatedDate;
        private Label status;
        private Label startReviewedDate;
        private Label endReviewedDate;
        private Label slotId;
        private TextBox txtStatus;
        private TextBox txtSlotId;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Button btnClearText;
        private Button btnOK;
        private Label MessageIsListEmpty;
    }
}