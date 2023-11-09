namespace MeetMyLecturerWinApp.Admin_form
{
    partial class frmAdminProfile
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
            txtIsShowSchedule = new TextBox();
            txtStatus = new TextBox();
            txtInfo = new TextBox();
            txtMajor = new TextBox();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            txtIsShowProfile = new TextBox();
            txtEmail = new TextBox();
            txtDateOfBirth = new TextBox();
            txtFullName = new TextBox();
            Role = new Label();
            IsShowSchedule = new Label();
            IsShowProfile = new Label();
            status = new Label();
            Info = new Label();
            Major = new Label();
            Password = new Label();
            Email = new Label();
            DateOfBirth = new Label();
            Fullname = new Label();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(522, 305);
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
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.Location = new Point(419, 305);
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
            btnUpload.ForeColor = SystemColors.ActiveCaptionText;
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
            image1.Location = new Point(141, 15);
            image1.Margin = new Padding(3, 2, 3, 2);
            image1.Name = "image1";
            image1.Size = new Size(109, 82);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 31;
            image1.TabStop = false;
            // 
            // txtIsShowSchedule
            // 
            txtIsShowSchedule.Location = new Point(494, 238);
            txtIsShowSchedule.Margin = new Padding(3, 2, 3, 2);
            txtIsShowSchedule.Name = "txtIsShowSchedule";
            txtIsShowSchedule.Size = new Size(110, 23);
            txtIsShowSchedule.TabIndex = 29;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(494, 188);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(110, 23);
            txtStatus.TabIndex = 28;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(494, 146);
            txtInfo.Margin = new Padding(3, 2, 3, 2);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(110, 23);
            txtInfo.TabIndex = 27;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(494, 106);
            txtMajor.Margin = new Padding(3, 2, 3, 2);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(110, 23);
            txtMajor.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(494, 60);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(110, 23);
            txtPassword.TabIndex = 25;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(122, 238);
            txtRole.Margin = new Padding(3, 2, 3, 2);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(194, 23);
            txtRole.TabIndex = 24;
            // 
            // txtIsShowProfile
            // 
            txtIsShowProfile.Location = new Point(122, 205);
            txtIsShowProfile.Margin = new Padding(3, 2, 3, 2);
            txtIsShowProfile.Name = "txtIsShowProfile";
            txtIsShowProfile.Size = new Size(194, 23);
            txtIsShowProfile.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 167);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 23;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(122, 134);
            txtDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(194, 23);
            txtDateOfBirth.TabIndex = 22;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(122, 273);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(194, 23);
            txtFullName.TabIndex = 21;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.ForeColor = SystemColors.ControlLightLight;
            Role.Location = new Point(32, 241);
            Role.Name = "Role";
            Role.Size = new Size(30, 15);
            Role.TabIndex = 20;
            Role.Text = "Role";
            Role.Click += Role_Click;
            // 
            // IsShowSchedule
            // 
            IsShowSchedule.AutoSize = true;
            IsShowSchedule.ForeColor = SystemColors.ControlLightLight;
            IsShowSchedule.Location = new Point(368, 241);
            IsShowSchedule.Name = "IsShowSchedule";
            IsShowSchedule.Size = new Size(92, 15);
            IsShowSchedule.TabIndex = 19;
            IsShowSchedule.Text = "IsShowSchedule";
            IsShowSchedule.Click += IsShowSchedule_Click;
            // 
            // IsShowProfile
            // 
            IsShowProfile.AutoSize = true;
            IsShowProfile.ForeColor = SystemColors.ControlLightLight;
            IsShowProfile.Location = new Point(32, 205);
            IsShowProfile.Name = "IsShowProfile";
            IsShowProfile.Size = new Size(78, 15);
            IsShowProfile.TabIndex = 18;
            IsShowProfile.Text = "IsShowProfile";
            IsShowProfile.Click += IsShowProfile_Click;
            // 
            // status
            // 
            status.AutoSize = true;
            status.ForeColor = SystemColors.ControlLightLight;
            status.Location = new Point(368, 191);
            status.Name = "status";
            status.Size = new Size(38, 15);
            status.TabIndex = 17;
            status.Text = "status";
            status.Click += status_Click;
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.ForeColor = SystemColors.ControlLightLight;
            Info.Location = new Point(368, 149);
            Info.Name = "Info";
            Info.Size = new Size(28, 15);
            Info.TabIndex = 15;
            Info.Text = "Info";
            Info.Click += Info_Click;
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.ForeColor = SystemColors.ControlLightLight;
            Major.Location = new Point(368, 109);
            Major.Name = "Major";
            Major.Size = new Size(38, 15);
            Major.TabIndex = 14;
            Major.Text = "Major";
            Major.Click += Major_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = SystemColors.ControlLightLight;
            Password.Location = new Point(368, 63);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 13;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.ForeColor = SystemColors.ControlLightLight;
            Email.Location = new Point(32, 170);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 12;
            Email.Text = "Email";
            Email.Click += Email_Click;
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
            DateOfBirth.Click += DateOfBirth_Click;
            // 
            // Fullname
            // 
            Fullname.AutoSize = true;
            Fullname.ForeColor = SystemColors.ControlLightLight;
            Fullname.Location = new Point(32, 281);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(58, 15);
            Fullname.TabIndex = 11;
            Fullname.Text = "FullName";
            Fullname.Click += Fullname_Click;
            // 
            // frmAdminProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(629, 338);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnUpload);
            Controls.Add(image1);
            Controls.Add(txtIsShowSchedule);
            Controls.Add(txtStatus);
            Controls.Add(txtInfo);
            Controls.Add(txtMajor);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            Controls.Add(txtIsShowProfile);
            Controls.Add(txtEmail);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtFullName);
            Controls.Add(Role);
            Controls.Add(IsShowSchedule);
            Controls.Add(IsShowProfile);
            Controls.Add(status);
            Controls.Add(Info);
            Controls.Add(Major);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(DateOfBirth);
            Controls.Add(Fullname);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdminProfile";
            Text = "frmAdminProfile";
            Load += frmAdminProfile_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnEdit;
        private Button btnUpload;
        private PictureBox image1;
        private TextBox txtIsShowSchedule;
        private TextBox txtStatus;
        private TextBox txtInfo;
        private TextBox txtMajor;
        private TextBox txtPassword;
        private TextBox txtRole;
        private TextBox txtIsShowProfile;
        private TextBox txtEmail;
        private TextBox txtDateOfBirth;
        private TextBox txtFullName;
        private Label Role;
        private Label IsShowSchedule;
        private Label IsShowProfile;
        private Label status;
        private Label Info;
        private Label Major;
        private Label Password;
        private Label Email;
        private Label DateOfBirth;
        private Label Fullname;
    }
}