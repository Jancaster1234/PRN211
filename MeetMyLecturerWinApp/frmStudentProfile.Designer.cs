namespace MeetMyLecturerWinApp
{
    partial class frmStudentProfile
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
            Fullname = new Label();
            DateOfBirth = new Label();
            Email = new Label();
            Password = new Label();
            Major = new Label();
            Info = new Label();
            imageochonay = new Label();
            status = new Label();
            IsShowProfile = new Label();
            IsShowSchedule = new Label();
            Role = new Label();
            SuspendLayout();
            // 
            // Fullname
            // 
            Fullname.AutoSize = true;
            Fullname.Location = new Point(102, 140);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(72, 20);
            Fullname.TabIndex = 0;
            Fullname.Text = "FullName";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.Location = new Point(102, 190);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(88, 20);
            DateOfBirth.TabIndex = 0;
            DateOfBirth.Text = "DateOfBirth";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(102, 241);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(420, 102);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 0;
            Password.Text = "Password";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.Location = new Point(420, 155);
            Major.Name = "Major";
            Major.Size = new Size(48, 20);
            Major.TabIndex = 0;
            Major.Text = "Major";
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Location = new Point(420, 201);
            Info.Name = "Info";
            Info.Size = new Size(35, 20);
            Info.TabIndex = 0;
            Info.Text = "Info";
            // 
            // imageochonay
            // 
            imageochonay.AutoSize = true;
            imageochonay.Location = new Point(36, 36);
            imageochonay.Name = "imageochonay";
            imageochonay.Size = new Size(119, 20);
            imageochonay.TabIndex = 1;
            imageochonay.Text = "Image ỏ chỗ này";
            imageochonay.Click += label1_Click;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(423, 243);
            status.Name = "status";
            status.Size = new Size(47, 20);
            status.TabIndex = 2;
            status.Text = "status";
            // 
            // IsShowProfile
            // 
            IsShowProfile.AutoSize = true;
            IsShowProfile.Location = new Point(102, 293);
            IsShowProfile.Name = "IsShowProfile";
            IsShowProfile.Size = new Size(98, 20);
            IsShowProfile.TabIndex = 3;
            IsShowProfile.Text = "IsShowProfile";
            // 
            // IsShowSchedule
            // 
            IsShowSchedule.AutoSize = true;
            IsShowSchedule.Location = new Point(423, 293);
            IsShowSchedule.Name = "IsShowSchedule";
            IsShowSchedule.Size = new Size(115, 20);
            IsShowSchedule.TabIndex = 4;
            IsShowSchedule.Text = "IsShowSchedule";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(102, 338);
            Role.Name = "Role";
            Role.Size = new Size(39, 20);
            Role.TabIndex = 5;
            Role.Text = "Role";
            // 
            // frmStudentProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Role);
            Controls.Add(IsShowSchedule);
            Controls.Add(IsShowProfile);
            Controls.Add(status);
            Controls.Add(imageochonay);
            Controls.Add(Info);
            Controls.Add(Major);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(DateOfBirth);
            Controls.Add(Fullname);
            Name = "frmStudentProfile";
            Text = "frmStudentProfile";
            Load += frmStudentProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Fullname;
        private Label DateOfBirth;
        private Label Email;
        private Label Password;
        private Label Major;
        private Label Info;
        private Label imageochonay;
        private Label status;
        private Label IsShowProfile;
        private Label IsShowSchedule;
        private Label Role;
    }
}