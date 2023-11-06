using MeetMyLecturerWinApp.Student_form;
using Repository;
using MeetMyLecturerWinApp.Teacher_form;
using MeetMyLecturerWinApp.Admin_form;

namespace MeetMyLecturerWinApp
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        IUserRepository _userRepository = new UserRepository();
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var tmp = _userRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (tmp != null)
            {
                CurrentUser.SetCurrentUser(tmp);
                if (tmp.Role == 1)
                {
                    frmMainAdmin f = new frmMainAdmin();
                    f.Show();
                }
                else if (tmp.Role == 2)
                {
                    frmMainTeacher f = new frmMainTeacher();
                    f.Show();
                }
                else if (tmp.Role == 3)
                {
                    frmMainStudent f = new frmMainStudent();
                    f.Show();
                }
            }
            else
            {
                // Neither admin nor user, show error message
                MessageBox.Show("You have no permission to do this function!", "MeetMyLecturer");
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Email = new Label();
            txtEmail = new TextBox();
            Password = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(100, 57);
            Email.Name = "Email";
            Email.Size = new Size(49, 20);
            Email.TabIndex = 2;
            Email.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(270, 57);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(135, 27);
            txtEmail.TabIndex = 4;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(100, 123);
            Password.Name = "Password";
            Password.Size = new Size(73, 20);
            Password.TabIndex = 5;
            Password.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(270, 132);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(135, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(288, 222);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(Password);
            Controls.Add(txtEmail);
            Controls.Add(Email);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Email;
        private TextBox txtEmail;
        private Label Password;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}