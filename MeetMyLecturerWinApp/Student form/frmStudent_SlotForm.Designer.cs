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
            dgvSlots.Location = new Point(32, 122);
            dgvSlots.Margin = new Padding(3, 2, 3, 2);
            dgvSlots.Name = "dgvSlots";
            dgvSlots.RowHeadersWidth = 51;
            dgvSlots.RowTemplate.Height = 29;
            dgvSlots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSlots.Size = new Size(628, 199);
            dgvSlots.TabIndex = 0;
            // 
            // TeacherEmail
            // 
            TeacherEmail.AutoSize = true;
            TeacherEmail.Location = new Point(10, 23);
            TeacherEmail.Name = "TeacherEmail";
            TeacherEmail.Size = new Size(79, 15);
            TeacherEmail.TabIndex = 1;
            TeacherEmail.Text = "Teacher Email";
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.Location = new Point(31, 56);
            Subject.Name = "Subject";
            Subject.Size = new Size(46, 15);
            Subject.TabIndex = 2;
            Subject.Text = "Subject";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.Location = new Point(371, 23);
            startDate.Name = "startDate";
            startDate.Size = new Size(54, 15);
            startDate.TabIndex = 3;
            startDate.Text = "startDate";
            // 
            // endDate
            // 
            endDate.AutoSize = true;
            endDate.Location = new Point(374, 56);
            endDate.Name = "endDate";
            endDate.Size = new Size(51, 15);
            endDate.TabIndex = 4;
            endDate.Text = "endDate";
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(102, 20);
            txtTeacher.Margin = new Padding(3, 2, 3, 2);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(203, 23);
            txtTeacher.TabIndex = 5;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(102, 54);
            txtSubject.Margin = new Padding(3, 2, 3, 2);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(203, 23);
            txtSubject.TabIndex = 5;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(134, 90);
            btnClearText.Margin = new Padding(3, 2, 3, 2);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(82, 22);
            btnClearText.TabIndex = 6;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(371, 90);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 22);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(454, 23);
            startDatePicker.Margin = new Padding(3, 2, 3, 2);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(219, 23);
            startDatePicker.TabIndex = 7;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(454, 52);
            endDatePicker.Margin = new Padding(3, 2, 3, 2);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(219, 23);
            endDatePicker.TabIndex = 7;
            // 
            // frmStudent_SlotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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