using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
                    SendPasswordByEmail(u);
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
        private async void SendPasswordByEmail(User user)
        {
            try
            {
                // Cấu hình thông tin email
                MailMessage mail = new MailMessage();
                mail.To.Add(user.Email);
                mail.From = new MailAddress("duynmse173649@fpt.edu.vn");
                mail.Subject = "Get password for account " + user.Email;
                mail.Body = "Password: " + user.Password;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("duynmse173649@fpt.edu.vn", "pdyf waar utat brpt");
                smtp.Send(mail);
                MessageBox.Show("Your password has been sent", "Notification");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }

        }
    }
}
