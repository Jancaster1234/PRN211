﻿namespace MeetMyLecturerWinApp.Student_form
{
    partial class frmEnrollInSlot
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
            Teacher = new Label();
            TeacherEmail = new Label();
            Date = new Label();
            startTime = new Label();
            endTime = new Label();
            createdDate = new Label();
            message = new Label();
            subject = new Label();
            studentLimit = new Label();
            txtTeacher = new TextBox();
            txtTeacherEmail = new TextBox();
            txtDate = new TextBox();
            txtStartTime = new TextBox();
            txtEndTime = new TextBox();
            txtCreatedDate = new TextBox();
            txtMessage = new TextBox();
            txtSubject = new TextBox();
            txtStudentLimit = new TextBox();
            btnRequestPasscode = new Button();
            rabtnRequiredPasscode = new RadioButton();
            btnEnroll = new Button();
            btnClose = new Button();
            EnterPasscode = new Label();
            txtEnterPasscode = new TextBox();
            RequestPasscodeMessage = new Label();
            SuspendLayout();
            // 
            // Teacher
            // 
            Teacher.AutoSize = true;
            Teacher.Location = new Point(38, 30);
            Teacher.Name = "Teacher";
            Teacher.Size = new Size(60, 20);
            Teacher.TabIndex = 0;
            Teacher.Text = "Teacher";
            // 
            // TeacherEmail
            // 
            TeacherEmail.AutoSize = true;
            TeacherEmail.Location = new Point(38, 86);
            TeacherEmail.Name = "TeacherEmail";
            TeacherEmail.Size = new Size(97, 20);
            TeacherEmail.TabIndex = 0;
            TeacherEmail.Text = "TeacherEmail";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(38, 138);
            Date.Name = "Date";
            Date.Size = new Size(41, 20);
            Date.TabIndex = 0;
            Date.Text = "Date";
            // 
            // startTime
            // 
            startTime.AutoSize = true;
            startTime.Location = new Point(38, 195);
            startTime.Name = "startTime";
            startTime.Size = new Size(71, 20);
            startTime.TabIndex = 0;
            startTime.Text = "startTime";
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Location = new Point(38, 253);
            endTime.Name = "endTime";
            endTime.Size = new Size(67, 20);
            endTime.TabIndex = 0;
            endTime.Text = "endTime";
            // 
            // createdDate
            // 
            createdDate.AutoSize = true;
            createdDate.Location = new Point(446, 33);
            createdDate.Name = "createdDate";
            createdDate.Size = new Size(91, 20);
            createdDate.TabIndex = 0;
            createdDate.Text = "createdDate";
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(446, 86);
            message.Name = "message";
            message.Size = new Size(67, 20);
            message.TabIndex = 0;
            message.Text = "message";
            // 
            // subject
            // 
            subject.AutoSize = true;
            subject.Location = new Point(446, 138);
            subject.Name = "subject";
            subject.Size = new Size(56, 20);
            subject.TabIndex = 0;
            subject.Text = "subject";
            // 
            // studentLimit
            // 
            studentLimit.AutoSize = true;
            studentLimit.Location = new Point(446, 195);
            studentLimit.Name = "studentLimit";
            studentLimit.Size = new Size(91, 20);
            studentLimit.TabIndex = 0;
            studentLimit.Text = "studentLimit";
            // 
            // txtTeacher
            // 
            txtTeacher.Location = new Point(153, 30);
            txtTeacher.Name = "txtTeacher";
            txtTeacher.Size = new Size(255, 27);
            txtTeacher.TabIndex = 1;
            // 
            // txtTeacherEmail
            // 
            txtTeacherEmail.Location = new Point(153, 83);
            txtTeacherEmail.Name = "txtTeacherEmail";
            txtTeacherEmail.Size = new Size(255, 27);
            txtTeacherEmail.TabIndex = 1;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(153, 135);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(255, 27);
            txtDate.TabIndex = 1;
            // 
            // txtStartTime
            // 
            txtStartTime.Location = new Point(153, 192);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(255, 27);
            txtStartTime.TabIndex = 1;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new Point(153, 250);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new Size(255, 27);
            txtEndTime.TabIndex = 1;
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.Location = new Point(568, 30);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.Size = new Size(255, 27);
            txtCreatedDate.TabIndex = 1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(568, 83);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(255, 27);
            txtMessage.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(568, 135);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(255, 27);
            txtSubject.TabIndex = 1;
            // 
            // txtStudentLimit
            // 
            txtStudentLimit.Location = new Point(568, 192);
            txtStudentLimit.Name = "txtStudentLimit";
            txtStudentLimit.Size = new Size(255, 27);
            txtStudentLimit.TabIndex = 1;
            // 
            // btnRequestPasscode
            // 
            btnRequestPasscode.Location = new Point(640, 244);
            btnRequestPasscode.Name = "btnRequestPasscode";
            btnRequestPasscode.Size = new Size(150, 29);
            btnRequestPasscode.TabIndex = 2;
            btnRequestPasscode.Text = "Request passcode";
            btnRequestPasscode.UseVisualStyleBackColor = true;
            btnRequestPasscode.Click += btnRequestPasscode_Click;
            // 
            // rabtnRequiredPasscode
            // 
            rabtnRequiredPasscode.AutoSize = true;
            rabtnRequiredPasscode.Location = new Point(446, 246);
            rabtnRequiredPasscode.Name = "rabtnRequiredPasscode";
            rabtnRequiredPasscode.Size = new Size(154, 24);
            rabtnRequiredPasscode.TabIndex = 3;
            rabtnRequiredPasscode.TabStop = true;
            rabtnRequiredPasscode.Text = "Required Passcode";
            rabtnRequiredPasscode.UseVisualStyleBackColor = true;
            // 
            // btnEnroll
            // 
            btnEnroll.Location = new Point(243, 380);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(94, 29);
            btnEnroll.TabIndex = 4;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(506, 380);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // EnterPasscode
            // 
            EnterPasscode.AutoSize = true;
            EnterPasscode.Location = new Point(446, 321);
            EnterPasscode.Name = "EnterPasscode";
            EnterPasscode.Size = new Size(109, 20);
            EnterPasscode.TabIndex = 5;
            EnterPasscode.Text = "Enter passcode";
            // 
            // txtEnterPasscode
            // 
            txtEnterPasscode.Location = new Point(568, 318);
            txtEnterPasscode.Name = "txtEnterPasscode";
            txtEnterPasscode.Size = new Size(255, 27);
            txtEnterPasscode.TabIndex = 6;
            // 
            // RequestPasscodeMessage
            // 
            RequestPasscodeMessage.AutoSize = true;
            RequestPasscodeMessage.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            RequestPasscodeMessage.ForeColor = Color.Salmon;
            RequestPasscodeMessage.Location = new Point(608, 276);
            RequestPasscodeMessage.Name = "RequestPasscodeMessage";
            RequestPasscodeMessage.Size = new Size(226, 19);
            RequestPasscodeMessage.TabIndex = 7;
            RequestPasscodeMessage.Text = "you already had a pending request!";
            // 
            // frmEnrollInSlot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(RequestPasscodeMessage);
            Controls.Add(txtEnterPasscode);
            Controls.Add(EnterPasscode);
            Controls.Add(btnClose);
            Controls.Add(btnEnroll);
            Controls.Add(rabtnRequiredPasscode);
            Controls.Add(btnRequestPasscode);
            Controls.Add(txtStudentLimit);
            Controls.Add(txtSubject);
            Controls.Add(txtMessage);
            Controls.Add(txtCreatedDate);
            Controls.Add(txtEndTime);
            Controls.Add(txtStartTime);
            Controls.Add(txtDate);
            Controls.Add(txtTeacherEmail);
            Controls.Add(txtTeacher);
            Controls.Add(endTime);
            Controls.Add(studentLimit);
            Controls.Add(subject);
            Controls.Add(message);
            Controls.Add(createdDate);
            Controls.Add(startTime);
            Controls.Add(Date);
            Controls.Add(TeacherEmail);
            Controls.Add(Teacher);
            Name = "frmEnrollInSlot";
            Text = "frmEnrollInSlot";
            Load += frmEnrollInSlot_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Teacher;
        private Label TeacherEmail;
        private Label Date;
        private Label startTime;
        private Label endTime;
        private Label createdDate;
        private Label message;
        private Label subject;
        private Label studentLimit;
        private TextBox txtTeacher;
        private TextBox txtTeacherEmail;
        private TextBox txtDate;
        private TextBox txtStartTime;
        private TextBox txtEndTime;
        private TextBox txtCreatedDate;
        private TextBox txtMessage;
        private TextBox txtSubject;
        private TextBox txtStudentLimit;
        private Button btnRequestPasscode;
        private RadioButton rabtnRequiredPasscode;
        private Button btnEnroll;
        private Button btnClose;
        private Label EnterPasscode;
        private TextBox txtEnterPasscode;
        private Label RequestPasscodeMessage;
    }
}