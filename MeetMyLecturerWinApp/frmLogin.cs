using BusinessObject.Models;
using MeetMyLecturerWinApp.Admin_form;
using MeetMyLecturerWinApp.Student_form;
using MeetMyLecturerWinApp.Teacher_form;
using Microsoft.Extensions.Configuration;
using Repository;

namespace MeetMyLecturerWinApp
{
    public partial class frmLogIn : Form
    {
        IUserRepository _userRepository = new UserRepository();

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            var tmp = _userRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
            if (tmp != null)
            {
                CurrentUser.SetCurrentUser(tmp);
                frmMain main = new frmMain(tmp);
                main.Show();
            }
            else
            {
                // Neither admin nor user, show error message
                MessageBox.Show("You have no permission to do this function!", "MeetMyLecturer");
            }
        }

        private void linkForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            frmForgotPassword.ShowDialog();
            this.Show();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
            this.Show();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}