using BusinessObject.Models;
using Microsoft.IdentityModel.Tokens;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetMyLecturerWinApp
{
    public partial class frmRegister : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(txtEmail.Text)||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtPass.Text) ||
                string.IsNullOrEmpty(txtPassConfirm.Text)))
            {
                if (IsValidEmail(txtEmail.Text))
                {
                    if (!ContainsSpecialCharacters(txtName.Text))
                    {

                        if (txtPassConfirm.Text.Equals(txtPass.Text))
                        {
                            User user = new User();
                            user.Email = txtEmail.Text;
                            user.Name = txtName.Text;
                            user.Password = txtPass.Text;
                            user.Role = 3;
                            user.Image = "default_profile_picture.jpg";
                            user.UserStatus = "Active";
                            user.IsShowProfile = true;
                            user.IsShowSchedule = true;
                            user.Info = "nothing yet";
                            user.Major = "SE";
                            userRepository.SaveUser(user);
                            MessageBox.Show("Sign Up Success", "Notification");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Password and confirm password are not the same", "Notification");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name is not allowed to contain special characters", "Notification");
                    }
                }
                else
                {
                    MessageBox.Show("The email entered must have the extension @fe.edu.vn or @fpt.edu.vn", "Notification");
                }
            }
            else
            {
                MessageBox.Show("Not Allow Empty Box", "Error");
            }
        }
        private bool ContainsSpecialCharacters(string input)
        {
            string pattern = @"[!@#\$%\^&\*\(\)_\+=\-\[\]{};':""\\|,.<>/?]";
            return Regex.IsMatch(input, pattern);
        }
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[\w-]+(\.[\w-]+)*@(fpt\.edu\.vn|fe\.edu\.vn)$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
