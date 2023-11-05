using BusinessObject.Models;
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
    public partial class frmForgotPassword : Form
    {
        IUserRepository userRepository = new UserRepository();
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void GetPassBut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                User u = userRepository.GetUserByEmail(txtEmail.Text);
                if (u != null)
                {
                    result.Text = u.Password;
                }
                else
                {
                    MessageBox.Show("Can't find this Email", "Notification");
                }
            }
            else
            {
                MessageBox.Show("Not Allow Empty Box", "Error");
            }
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
