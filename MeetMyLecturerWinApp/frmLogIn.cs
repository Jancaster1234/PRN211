using BusinessObject.Models;
using Microsoft.Extensions.Configuration;
using Repository;

namespace MeetMyLecturerWinApp
{
    public partial class frmLogIn : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                 .Build();
            string EmailAdmin = config.GetSection("AdminAccount:Email").Value;
            string PasswordAdmin = config.GetSection("AdminAccount:password").Value;
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Not Allow Empty Box", "Error");
            }
            else
            {
                if (EmailAdmin.Equals(txtEmail.Text) && PasswordAdmin.Equals(txtPassword.Text))
                {
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                }
                else
                {
                    User user = userRepository.CheckLogin(txtEmail.Text, txtPassword.Text);
                    if (user == null)
                    {
                        MessageBox.Show("Wrong email or password");
                        txtEmail.Text = String.Empty;
                        txtPassword.Text = String.Empty;
                    }
                    else
                    {

                        frmMain frmMain = new frmMain();
                        frmMain.Show();
                    }
                }
            }
        }

        private void linkForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword frmForgotPassword = new frmForgotPassword();
            frmForgotPassword.Show();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
        }
    }
}