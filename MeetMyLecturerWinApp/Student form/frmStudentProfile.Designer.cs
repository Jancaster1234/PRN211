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
            image1.Location = new Point(165, 28);
            image1.Name = "image1";
            image1.Size = new Size(125, 110);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 7;
            image1.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(44, 75);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 8;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnPublicProfile
            // 
            btnPublicProfile.Location = new Point(565, 75);
            btnPublicProfile.Name = "btnPublicProfile";
            btnPublicProfile.Size = new Size(66, 29);
            btnPublicProfile.TabIndex = 11;
            btnPublicProfile.Text = "On";
            btnPublicProfile.UseVisualStyleBackColor = true;
            btnPublicProfile.Click += btnPublicProfile_Click;
            // 
            // PublicProfile
            // 
            PublicProfile.AutoSize = true;
            PublicProfile.Location = new Point(448, 79);
            PublicProfile.Name = "PublicProfile";
            PublicProfile.Size = new Size(97, 20);
            PublicProfile.TabIndex = 12;
            PublicProfile.Text = "public Profile";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(660, 396);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(507, 396);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 51;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(495, 330);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(259, 27);
            txtStatus.TabIndex = 50;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(495, 277);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(259, 27);
            txtInfo.TabIndex = 49;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(495, 225);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(259, 27);
            txtMajor.TabIndex = 48;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(495, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 27);
            txtPassword.TabIndex = 47;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(137, 280);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(236, 27);
            txtRole.TabIndex = 46;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 27);
            txtEmail.TabIndex = 45;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(137, 173);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(236, 27);
            txtDateOfBirth.TabIndex = 44;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(137, 330);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(236, 27);
            txtFullName.TabIndex = 43;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(43, 280);
            Role.Name = "Role";
            Role.Size = new Size(39, 20);
            Role.TabIndex = 42;
            Role.Text = "Role";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(411, 333);
            status.Name = "status";
            status.Size = new Size(47, 20);
            status.TabIndex = 41;
            status.Text = "status";
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Location = new Point(411, 280);
            Info.Name = "Info";
            Info.Size = new Size(35, 20);
            Info.TabIndex = 39;
            Info.Text = "Info";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.Location = new Point(412, 228);
            Major.Name = "Major";
            Major.Size = new Size(48, 20);
            Major.TabIndex = 38;
            Major.Text = "Major";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(411, 173);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 37;
            Password.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(43, 228);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 36;
            Email.Text = "Email";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.Location = new Point(39, 173);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(88, 20);
            DateOfBirth.TabIndex = 40;
            DateOfBirth.Text = "DateOfBirth";
            // 
            // Fullname
            // 
            Fullname.AutoSize = true;
            Fullname.Location = new Point(43, 333);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(72, 20);
            Fullname.TabIndex = 35;
            Fullname.Text = "FullName";
            // 
            // frmStudentProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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