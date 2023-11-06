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
            ((System.ComponentModel.ISupportInitialize)dgvMeetingRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvMeetingRequests
            // 
            dgvMeetingRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeetingRequests.Location = new Point(64, 231);
            dgvMeetingRequests.Name = "dgvMeetingRequests";
            dgvMeetingRequests.RowHeadersWidth = 51;
            dgvMeetingRequests.RowTemplate.Height = 29;
            dgvMeetingRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeetingRequests.Size = new Size(688, 168);
            dgvMeetingRequests.TabIndex = 0;
            dgvMeetingRequests.CellContentClick += dgvMeetingRequests_CellContentClick;
            // 
            // startCreatedDate
            // 
            startCreatedDate.AutoSize = true;
            startCreatedDate.Location = new Point(12, 21);
            startCreatedDate.Name = "startCreatedDate";
            startCreatedDate.Size = new Size(132, 20);
            startCreatedDate.TabIndex = 1;
            startCreatedDate.Text = "Start Created Date";
            // 
            // endCreatedDate
            // 
            endCreatedDate.AutoSize = true;
            endCreatedDate.Location = new Point(18, 55);
            endCreatedDate.Name = "endCreatedDate";
            endCreatedDate.Size = new Size(126, 20);
            endCreatedDate.TabIndex = 1;
            endCreatedDate.Text = "End Created Date";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(91, 106);
            status.Name = "status";
            status.Size = new Size(49, 20);
            status.TabIndex = 1;
            status.Text = "Status";
            // 
            // startReviewedDate
            // 
            startReviewedDate.AutoSize = true;
            startReviewedDate.Location = new Point(401, 21);
            startReviewedDate.Name = "startReviewedDate";
            startReviewedDate.Size = new Size(144, 20);
            startReviewedDate.TabIndex = 1;
            startReviewedDate.Text = "Start Reviewed Date";
            // 
            // endReviewedDate
            // 
            endReviewedDate.AutoSize = true;
            endReviewedDate.Location = new Point(401, 60);
            endReviewedDate.Name = "endReviewedDate";
            endReviewedDate.Size = new Size(138, 20);
            endReviewedDate.TabIndex = 1;
            endReviewedDate.Text = "End Reviewed Date";
            // 
            // slotId
            // 
            slotId.AutoSize = true;
            slotId.Location = new Point(401, 106);
            slotId.Name = "slotId";
            slotId.Size = new Size(52, 20);
            slotId.TabIndex = 1;
            slotId.Text = "Slot Id";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(161, 106);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(173, 27);
            txtStatus.TabIndex = 2;
            // 
            // txtSlotId
            // 
            txtSlotId.Location = new Point(487, 106);
            txtSlotId.Name = "txtSlotId";
            txtSlotId.Size = new Size(173, 27);
            txtSlotId.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(145, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(145, 55);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(551, 21);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 3;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(551, 55);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(250, 27);
            dateTimePicker4.TabIndex = 3;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(214, 173);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 4;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(487, 173);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // frmStudentMeetingRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}