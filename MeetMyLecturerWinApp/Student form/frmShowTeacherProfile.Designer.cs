namespace MeetMyLecturerWinApp.Student_form
{
    partial class frmShowTeacherProfile
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
            txtStatus = new TextBox();
            txtInfo = new TextBox();
            txtMajor = new TextBox();
            txtRole = new TextBox();
            txtEmail = new TextBox();
            txtDateOfBirth = new TextBox();
            txtFullName = new TextBox();
            Role = new Label();
            status = new Label();
            Info = new Label();
            Major = new Label();
            Email = new Label();
            DateOfBirth = new Label();
            Fullname = new Label();
            btnClose = new Button();
            MessageTeacherHidedProfile = new Label();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // image1
            // 
            image1.Location = new Point(134, 26);
            image1.Name = "image1";
            image1.Size = new Size(125, 110);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 29;
            image1.TabStop = false;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(490, 280);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(241, 27);
            txtStatus.TabIndex = 27;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(490, 229);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(241, 27);
            txtInfo.TabIndex = 26;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(490, 175);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(241, 27);
            txtMajor.TabIndex = 25;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(134, 280);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(221, 27);
            txtRole.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 226);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 27);
            txtEmail.TabIndex = 23;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(134, 178);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(221, 27);
            txtDateOfBirth.TabIndex = 22;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(134, 331);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(221, 27);
            txtFullName.TabIndex = 21;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(36, 280);
            Role.Name = "Role";
            Role.Size = new Size(39, 20);
            Role.TabIndex = 20;
            Role.Text = "Role";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(418, 283);
            status.Name = "status";
            status.Size = new Size(47, 20);
            status.TabIndex = 19;
            status.Text = "status";
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Location = new Point(418, 229);
            Info.Name = "Info";
            Info.Size = new Size(35, 20);
            Info.TabIndex = 17;
            Info.Text = "Info";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.Location = new Point(417, 175);
            Major.Name = "Major";
            Major.Size = new Size(48, 20);
            Major.TabIndex = 16;
            Major.Text = "Major";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(36, 226);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 14;
            Email.Text = "Email";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.Location = new Point(36, 178);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(88, 20);
            DateOfBirth.TabIndex = 18;
            DateOfBirth.Text = "DateOfBirth";
            // 
            // Fullname
            // 
            Fullname.AutoSize = true;
            Fullname.Location = new Point(36, 334);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(72, 20);
            Fullname.TabIndex = 13;
            Fullname.Text = "FullName";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(637, 401);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 35;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MessageTeacherHidedProfile
            // 
            MessageTeacherHidedProfile.AutoSize = true;
            MessageTeacherHidedProfile.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MessageTeacherHidedProfile.ForeColor = Color.IndianRed;
            MessageTeacherHidedProfile.Location = new Point(325, 73);
            MessageTeacherHidedProfile.Name = "MessageTeacherHidedProfile";
            MessageTeacherHidedProfile.Size = new Size(256, 35);
            MessageTeacherHidedProfile.TabIndex = 36;
            MessageTeacherHidedProfile.Text = "Teacher hided profile!";
            // 
            // frmShowTeacherProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MessageTeacherHidedProfile);
            Controls.Add(btnClose);
            Controls.Add(image1);
            Controls.Add(txtStatus);
            Controls.Add(txtInfo);
            Controls.Add(txtMajor);
            Controls.Add(txtRole);
            Controls.Add(txtEmail);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtFullName);
            Controls.Add(Role);
            Controls.Add(status);
            Controls.Add(Info);
            Controls.Add(Major);
            Controls.Add(Email);
            Controls.Add(DateOfBirth);
            Controls.Add(Fullname);
            Name = "frmShowTeacherProfile";
            Text = "frmShowTeacherProfile";
            Load += frmShowTeacherProfile_Load;
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox image1;
        private TextBox txtStatus;
        private TextBox txtInfo;
        private TextBox txtMajor;
        private TextBox txtRole;
        private TextBox txtEmail;
        private TextBox txtDateOfBirth;
        private TextBox txtFullName;
        private Label Role;
        private Label status;
        private Label Info;
        private Label Major;
        private Label Email;
        private Label DateOfBirth;
        private Label Fullname;
        private Button btnClose;
        private Label MessageTeacherHidedProfile;
    }
}