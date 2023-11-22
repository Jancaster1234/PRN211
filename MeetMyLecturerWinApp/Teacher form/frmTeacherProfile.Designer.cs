namespace MeetMyLecturerWinApp.Teacher_form
{
    partial class frmTeacherProfile
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
            btnSave = new Button();
            btnEdit = new Button();
            btnUpload = new Button();
            image1 = new PictureBox();
            txtStatus = new TextBox();
            txtInfo = new TextBox();
            txtMajor = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            txtEmail = new TextBox();
            txtDateOfBirth = new TextBox();
            txtFullName = new TextBox();
            Role = new Label();
            status = new Label();
            Info = new Label();
            Major = new Label();
            Password = new Label();
            Email = new Label();
            DateOfBirth = new Label();
            Fullname = new Label();
            PublicProfile = new Label();
            btnPublicProfile = new Button();
            PublicSchedule = new Label();
            btnPublicSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(575, 301);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(441, 301);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 33;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(35, 50);
            btnUpload.Margin = new Padding(3, 2, 3, 2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(82, 22);
            btnUpload.TabIndex = 32;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // image1
            // 
            image1.Location = new Point(137, 18);
            image1.Margin = new Padding(3, 2, 3, 2);
            image1.Name = "image1";
            image1.Size = new Size(109, 82);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 31;
            image1.TabStop = false;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(430, 251);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(227, 23);
            txtStatus.TabIndex = 28;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(430, 212);
            txtInfo.Margin = new Padding(3, 2, 3, 2);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(227, 23);
            txtInfo.TabIndex = 27;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(430, 172);
            txtMajor.Margin = new Padding(3, 2, 3, 2);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(227, 23);
            txtMajor.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(430, 131);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 23);
            txtPassword.TabIndex = 25;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(117, 214);
            txtRole.Margin = new Padding(3, 2, 3, 2);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(207, 23);
            txtRole.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 175);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 23;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(117, 134);
            txtDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(207, 23);
            txtDateOfBirth.TabIndex = 22;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(117, 251);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(207, 23);
            txtFullName.TabIndex = 21;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.ForeColor = SystemColors.ControlLightLight;
            Role.Location = new Point(35, 214);
            Role.Name = "Role";
            Role.Size = new Size(30, 15);
            Role.TabIndex = 20;
            Role.Text = "Role";
            // 
            // status
            // 
            status.AutoSize = true;
            status.ForeColor = SystemColors.ControlLightLight;
            status.Location = new Point(357, 254);
            status.Name = "status";
            status.Size = new Size(38, 15);
            status.TabIndex = 17;
            status.Text = "status";
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.ForeColor = SystemColors.ControlLightLight;
            Info.Location = new Point(357, 214);
            Info.Name = "Info";
            Info.Size = new Size(28, 15);
            Info.TabIndex = 15;
            Info.Text = "Info";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.ForeColor = SystemColors.ControlLightLight;
            Major.Location = new Point(358, 175);
            Major.Name = "Major";
            Major.Size = new Size(38, 15);
            Major.TabIndex = 14;
            Major.Text = "Major";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = SystemColors.ControlLightLight;
            Password.Location = new Point(357, 134);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 13;
            Password.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.ForeColor = SystemColors.ControlLightLight;
            Email.Location = new Point(35, 175);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 12;
            Email.Text = "Email";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.ForeColor = SystemColors.ControlLightLight;
            DateOfBirth.Location = new Point(32, 134);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(69, 15);
            DateOfBirth.TabIndex = 16;
            DateOfBirth.Text = "DateOfBirth";
            // 
            // Fullname
            // 
            Fullname.AutoSize = true;
            Fullname.ForeColor = SystemColors.ControlLightLight;
            Fullname.Location = new Point(35, 254);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(58, 15);
            Fullname.TabIndex = 11;
            Fullname.Text = "FullName";
            // 
            // PublicProfile
            // 
            PublicProfile.AutoSize = true;
            PublicProfile.ForeColor = SystemColors.ControlLightLight;
            PublicProfile.Location = new Point(404, 39);
            PublicProfile.Name = "PublicProfile";
            PublicProfile.Size = new Size(77, 15);
            PublicProfile.TabIndex = 36;
            PublicProfile.Text = "Public Profile";
            // 
            // btnPublicProfile
            // 
            btnPublicProfile.Location = new Point(523, 36);
            btnPublicProfile.Margin = new Padding(3, 2, 3, 2);
            btnPublicProfile.Name = "btnPublicProfile";
            btnPublicProfile.Size = new Size(58, 22);
            btnPublicProfile.TabIndex = 35;
            btnPublicProfile.Text = "ON-ed";
            btnPublicProfile.UseVisualStyleBackColor = true;
            btnPublicProfile.Click += btnPublicProfile_Click;
            // 
            // PublicSchedule
            // 
            PublicSchedule.AutoSize = true;
            PublicSchedule.ForeColor = SystemColors.ControlLightLight;
            PublicSchedule.Location = new Point(404, 71);
            PublicSchedule.Name = "PublicSchedule";
            PublicSchedule.Size = new Size(91, 15);
            PublicSchedule.TabIndex = 38;
            PublicSchedule.Text = "Public Schedule";
            // 
            // btnPublicSchedule
            // 
            btnPublicSchedule.Location = new Point(523, 68);
            btnPublicSchedule.Margin = new Padding(3, 2, 3, 2);
            btnPublicSchedule.Name = "btnPublicSchedule";
            btnPublicSchedule.Size = new Size(58, 22);
            btnPublicSchedule.TabIndex = 37;
            btnPublicSchedule.Text = "ON-ed";
            btnPublicSchedule.UseVisualStyleBackColor = true;
            btnPublicSchedule.Click += btnPublicSchedule_Click;
            // 
            // frmTeacherProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(PublicSchedule);
            Controls.Add(btnPublicSchedule);
            Controls.Add(PublicProfile);
            Controls.Add(btnPublicProfile);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnUpload);
            Controls.Add(image1);
            Controls.Add(txtStatus);
            Controls.Add(txtInfo);
            Controls.Add(txtMajor);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            Controls.Add(txtEmail);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtFullName);
            Controls.Add(Role);
            Controls.Add(status);
            Controls.Add(Info);
            Controls.Add(Major);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(DateOfBirth);
            Controls.Add(Fullname);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTeacherProfile";
            Text = "frmTeacherProfile";
            Load += frmStudentProfile_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnEdit;
        private Button btnUpload;
        private PictureBox image1;
        private TextBox txtStatus;
        private TextBox txtInfo;
        private TextBox txtMajor;
        private TextBox txtPassword;
        private TextBox txtRole;
        private TextBox txtEmail;
        private TextBox txtDateOfBirth;
        private TextBox txtFullName;
        private Label Role;
        private Label status;
        private Label Info;
        private Label Major;
        private Label Password;
        private Label Email;
        private Label DateOfBirth;
        private Label Fullname;
        private Label PublicProfile;
        private Button btnPublicProfile;
        private Label PublicSchedule;
        private Button btnPublicSchedule;
    }
}