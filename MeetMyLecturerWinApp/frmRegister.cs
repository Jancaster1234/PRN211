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
                if (txtPassConfirm.Text.Equals(txtPass.Text))
                {
                    User user = new User();
                    user.Email = txtEmail.Text;
                    user.Name = txtName.Text;
                    user.Password = txtPass.Text;
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
                MessageBox.Show("Not Allow Empty Box", "Error");
            }
        }
    }
}
