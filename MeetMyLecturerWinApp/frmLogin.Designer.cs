namespace MeetMyLecturerWinApp
{
    partial class frmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtEmail = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            linkForgetPass = new LinkLabel();
            linkRegister = new LinkLabel();
            SignInButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = new Bitmap("C:\\Users\\Thinkpad T14\\Desktop\\clone\\PRN211\\MeetMyLecturerWinApp\\Resource\\Users1.gif");
            pictureBox1.Location = new Point(91, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(150, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 27);
            txtEmail.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = new Bitmap("C:\\Users\\Thinkpad T14\\Desktop\\clone\\PRN211\\MeetMyLecturerWinApp\\Resource\\account.png");
            pictureBox2.Location = new Point(91, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = new Bitmap("C:\\Users\\Thinkpad T14\\Desktop\\clone\\PRN211\\MeetMyLecturerWinApp\\Resource\\2639882_password_icon.png"); 
            pictureBox3.Location = new Point(91, 264);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(150, 266);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(184, 27);
            txtPassword.TabIndex = 3;
            // 
            // linkForgetPass
            // 
            linkForgetPass.AutoSize = true;
            linkForgetPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkForgetPass.Location = new Point(74, 315);
            linkForgetPass.Name = "linkForgetPass";
            linkForgetPass.Size = new Size(138, 19);
            linkForgetPass.TabIndex = 5;
            linkForgetPass.TabStop = true;
            linkForgetPass.Text = "Forgotten Password?";
            linkForgetPass.LinkClicked += linkForgetPass_LinkClicked;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegister.Location = new Point(291, 315);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(58, 19);
            linkRegister.TabIndex = 6;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(166, 358);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(85, 29);
            SignInButton.TabIndex = 7;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(444, 399);
            Controls.Add(SignInButton);
            Controls.Add(linkRegister);
            Controls.Add(linkForgetPass);
            Controls.Add(pictureBox3);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox2);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Name = "frmLogIn";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtPassword;
        private LinkLabel linkForgetPass;
        private LinkLabel linkRegister;
        private Button SignInButton;
    }
}