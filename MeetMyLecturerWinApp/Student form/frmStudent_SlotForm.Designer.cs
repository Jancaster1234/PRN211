namespace MeetMyLecturerWinApp
{
    partial class frmStudent_SlotForm
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
            dgvSlots = new DataGridView();
            TeacherEmail = new Label();
            Subject = new Label();
            startDate = new Label();
            endDate = new Label();
            txtTeacher = new TextBox();
            txtSubject = new TextBox();
            btnClearText = new Button();
            btnOK = new Button();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvSlots).BeginInit();
            SuspendLayout();
            // 
            // dgvSlots
            // 
            dgvSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlots.Location = new Point(37, 162);
            dgvSlots.Name = "dgvSlots";
            dgvSlots.RowHeadersWidth = 51;
            dgvSlots.RowTemplate.Height = 29;
            dgvSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlots.Size = new Size(718, 265);
            dgvSlots.TabIndex = 0;
            // 
            // TeacherEmail
            // 
            TeacherEmail.AutoSize = true;
            TeacherEmail.Location = new Point(12, 31);
            TeacherEmail.Name = "TeacherEmail";
            TeacherEmail.Size = new Size(101, 20);
            TeacherEmail.TabIndex = 1;
            TeacherEmail.Text = "Teacher Email";
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.Location = new Point(35, 75);
            Subject.Name = "Subject";
            Subject.Size = new Size(58, 20);
            Subject.TabIndex = 2;
            Subject.Text = "Subject";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.Location = new Point(424, 31);
            startDate.Name = "startDate";
            startDate.Size = new Size(70, 20);
            startDate.TabIndex = 3;
            startDate.Text = "startDate";
            // 
            // endDate
            // 
            endDate.AutoSize = true;
            endDate.Location = new Point(428, 75);
            endDate.Name = "endDate";
            endDate.Size = new Size(66, 20);
            endDate.TabIndex = 4;
            endDate.Text = "endDate";
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(117, 27);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(231, 27);
            txtTeacher.TabIndex = 5;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(117, 72);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(231, 27);
            txtSubject.TabIndex = 5;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(153, 120);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 6;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(424, 120);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(519, 31);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(250, 27);
            startDatePicker.TabIndex = 7;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(519, 70);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(250, 27);
            endDatePicker.TabIndex = 7;
            // 
            // frmStudent_SlotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(btnOK);
            Controls.Add(btnClearText);
            Controls.Add(txtSubject);
            Controls.Add(txtTeacher);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(Subject);
            Controls.Add(TeacherEmail);
            Controls.Add(dgvSlots);
            Name = "frmStudent_SlotForm";
            Text = "frmStudent_SlotForm";
            Load += frmStudent_SlotForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSlots).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSlots;
        private Label TeacherEmail;
        private Label Subject;
        private Label startDate;
        private Label endDate;
        private TextBox txtTeacher;
        private TextBox txtSubject;
        private Button btnClearText;
        private Button btnOK;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
    }
}