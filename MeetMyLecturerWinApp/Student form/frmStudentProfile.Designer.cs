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
            image1 = new PictureBox();
            btnUpload = new Button();
            btnPublicProfile = new Button();
            PublicProfile = new Label();
            btnSave = new Button();
            btnEdit = new Button();
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
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // image1
            // 
            image1.Location = new Point(144, 21);
            image1.Margin = new Padding(3, 2, 3, 2);
            image1.Name = "image1";
            image1.Size = new Size(109, 82);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 7;
            image1.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(38, 56);
            btnUpload.Margin = new Padding(3, 2, 3, 2);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(82, 22);
            btnUpload.TabIndex = 8;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnPublicProfile
            // 
            btnPublicProfile.Location = new Point(494, 56);
            btnPublicProfile.Margin = new Padding(3, 2, 3, 2);
            btnPublicProfile.Name = "btnPublicProfile";
            btnPublicProfile.Size = new Size(58, 22);
            btnPublicProfile.TabIndex = 11;
            btnPublicProfile.Text = "On";
            btnPublicProfile.UseVisualStyleBackColor = true;
            btnPublicProfile.Click += btnPublicProfile_Click;
            // 
            // PublicProfile
            // 
            PublicProfile.AutoSize = true;
            PublicProfile.ForeColor = SystemColors.ButtonHighlight;
            PublicProfile.Location = new Point(392, 59);
            PublicProfile.Name = "PublicProfile";
            PublicProfile.Size = new Size(77, 15);
            PublicProfile.TabIndex = 12;
            PublicProfile.Text = "public Profile";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(578, 297);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(444, 297);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 51;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(433, 248);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(227, 23);
            txtStatus.TabIndex = 50;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(433, 208);
            txtInfo.Margin = new Padding(3, 2, 3, 2);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(227, 23);
            txtInfo.TabIndex = 49;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(433, 169);
            txtMajor.Margin = new Padding(3, 2, 3, 2);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(227, 23);
            txtMajor.TabIndex = 48;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(433, 128);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 23);
            txtPassword.TabIndex = 47;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(120, 210);
            txtRole.Margin = new Padding(3, 2, 3, 2);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(207, 23);
            txtRole.TabIndex = 46;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 171);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 45;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(120, 130);
            txtDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(207, 23);
            txtDateOfBirth.TabIndex = 44;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(120, 248);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(207, 23);
            txtFullName.TabIndex = 43;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.ForeColor = SystemColors.ButtonHighlight;
            Role.Location = new Point(38, 210);
            Role.Name = "Role";
            Role.Size = new Size(30, 15);
            Role.TabIndex = 42;
            Role.Text = "Role";
            // 
            // status
            // 
            status.AutoSize = true;
            status.ForeColor = SystemColors.ButtonHighlight;
            status.Location = new Point(360, 250);
            status.Name = "status";
            status.Size = new Size(38, 15);
            status.TabIndex = 41;
            status.Text = "status";
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.ForeColor = SystemColors.ButtonHighlight;
            Info.Location = new Point(360, 210);
            Info.Name = "Info";
            Info.Size = new Size(28, 15);
            Info.TabIndex = 39;
            Info.Text = "Info";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.ForeColor = SystemColors.ButtonHighlight;
            Major.Location = new Point(360, 171);
            Major.Name = "Major";
            Major.Size = new Size(38, 15);
            Major.TabIndex = 38;
            Major.Text = "Major";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(360, 130);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 37;
            Password.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.ForeColor = SystemColors.ButtonHighlight;
            Email.Location = new Point(38, 171);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 36;
            Email.Text = "Email";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.ForeColor = SystemColors.ButtonHighlight;
            DateOfBirth.Location = new Point(34, 130);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(69, 15);
            DateOfBirth.TabIndex = 40;
            DateOfBirth.Text = "DateOfBirth";
            // 
            // Fullname
            // 
            Fullname.AutoSize = true;
            Fullname.ForeColor = SystemColors.ButtonHighlight;
            Fullname.Location = new Point(38, 250);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(58, 15);
            Fullname.TabIndex = 35;
            Fullname.Text = "FullName";
            // 
            // frmStudentProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
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
            Controls.Add(PublicProfile);
            Controls.Add(btnPublicProfile);
            Controls.Add(btnUpload);
            Controls.Add(image1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmStudentProfile";
            Text = "frmStudentProfile";
            Load += frmStudentProfile_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label imageochonay;
        private PictureBox image1;
        private Button btnUpload;
        private Button btnSaveImage;
        private Button btnPublicProfile;
        private Label PublicProfile;
        private Button btnSave;
        private Button btnEdit;
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
    }
}