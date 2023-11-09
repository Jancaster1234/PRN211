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
            endDatePicker.Location = new Point(463, 51);
            endDatePicker.Margin = new Padding(3, 2, 3, 2);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(219, 23);
            endDatePicker.TabIndex = 17;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(463, 22);
            startDatePicker.Margin = new Padding(3, 2, 3, 2);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(219, 23);
            startDatePicker.TabIndex = 18;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(463, 88);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 22);
            btnOK.TabIndex = 15;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(232, 88);
            btnClearText.Margin = new Padding(3, 2, 3, 2);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(82, 22);
            btnClearText.TabIndex = 16;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(111, 52);
            txtSubject.Margin = new Padding(3, 2, 3, 2);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(203, 23);
            txtSubject.TabIndex = 13;
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(111, 19);
            txtTeacher.Margin = new Padding(3, 2, 3, 2);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(203, 23);
            txtTeacher.TabIndex = 14;
            // 
            // endDate
            // 
            endDate.AutoSize = true;
            endDate.ForeColor = SystemColors.ControlLightLight;
            endDate.Location = new Point(383, 55);
            endDate.Name = "endDate";
            endDate.Size = new Size(51, 15);
            endDate.TabIndex = 12;
            endDate.Text = "endDate";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.ForeColor = SystemColors.ControlLightLight;
            startDate.Location = new Point(380, 22);
            startDate.Name = "startDate";
            startDate.Size = new Size(54, 15);
            startDate.TabIndex = 11;
            startDate.Text = "startDate";
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.ForeColor = SystemColors.ControlLightLight;
            Subject.Location = new Point(39, 55);
            Subject.Name = "Subject";
            Subject.Size = new Size(46, 15);
            Subject.TabIndex = 10;
            Subject.Text = "Subject";
            // 
            // TeacherEmail
            // 
            TeacherEmail.AutoSize = true;
            TeacherEmail.ForeColor = SystemColors.ControlLightLight;
            TeacherEmail.Location = new Point(19, 22);
            TeacherEmail.Name = "TeacherEmail";
            TeacherEmail.Size = new Size(79, 15);
            TeacherEmail.TabIndex = 9;
            TeacherEmail.Text = "Teacher Email";
            // 
            // dgvSlots
            // 
            dgvSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlots.Location = new Point(41, 120);
            dgvSlots.Margin = new Padding(3, 2, 3, 2);
            dgvSlots.Name = "dgvSlots";
            dgvSlots.RowHeadersWidth = 51;
            dgvSlots.RowTemplate.Height = 29;
            dgvSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlots.Size = new Size(628, 199);
            dgvSlots.TabIndex = 8;
            // 
            // frmTeacher_SlotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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