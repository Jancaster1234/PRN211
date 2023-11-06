namespace MeetMyLecturerWinApp.Teacher_form
{
    partial class frmTeacher_SlotForm
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
            endDatePicker = new DateTimePicker();
            startDatePicker = new DateTimePicker();
            btnOK = new Button();
            btnClearText = new Button();
            txtSubject = new TextBox();
            txtTeacher = new TextBox();
            endDate = new Label();
            startDate = new Label();
            Subject = new Label();
            TeacherEmail = new Label();
            dgvSlots = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSlots).BeginInit();
            SuspendLayout();
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(529, 68);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(250, 27);
            endDatePicker.TabIndex = 17;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(529, 29);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(250, 27);
            startDatePicker.TabIndex = 18;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(434, 118);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 15;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(163, 118);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 16;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(127, 70);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(231, 27);
            txtSubject.TabIndex = 13;
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(127, 25);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(231, 27);
            txtTeacher.TabIndex = 14;
            // 
            // endDate
            // 
            endDate.AutoSize = true;
            endDate.Location = new Point(438, 73);
            endDate.Name = "endDate";
            endDate.Size = new Size(66, 20);
            endDate.TabIndex = 12;
            endDate.Text = "endDate";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.Location = new Point(434, 29);
            startDate.Name = "startDate";
            startDate.Size = new Size(70, 20);
            startDate.TabIndex = 11;
            startDate.Text = "startDate";
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.Location = new Point(45, 73);
            Subject.Name = "Subject";
            Subject.Size = new Size(58, 20);
            Subject.TabIndex = 10;
            Subject.Text = "Subject";
            // 
            // TeacherEmail
            // 
            TeacherEmail.AutoSize = true;
            TeacherEmail.Location = new Point(22, 29);
            TeacherEmail.Name = "TeacherEmail";
            TeacherEmail.Size = new Size(101, 20);
            TeacherEmail.TabIndex = 9;
            TeacherEmail.Text = "Teacher Email";
            // 
            // dgvSlots
            // 
            dgvSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlots.Location = new Point(47, 160);
            dgvSlots.Name = "dgvSlots";
            dgvSlots.RowHeadersWidth = 51;
            dgvSlots.RowTemplate.Height = 29;
            dgvSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlots.Size = new Size(718, 265);
            dgvSlots.TabIndex = 8;
            // 
            // frmTeacher_SlotForm
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
            Name = "frmTeacher_SlotForm";
            Text = "frmTeacher_SlotForm";
            Load += frmStudent_SlotForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSlots).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
        private Button btnOK;
        private Button btnClearText;
        private TextBox txtSubject;
        private TextBox txtTeacher;
        private Label endDate;
        private Label startDate;
        private Label Subject;
        private Label TeacherEmail;
        private DataGridView dgvSlots;
    }
}