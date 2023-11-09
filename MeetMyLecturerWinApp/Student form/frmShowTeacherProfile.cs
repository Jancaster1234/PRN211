using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using Repository;

namespace MeetMyLecturerWinApp.Student_form
{
    public partial class frmShowTeacherProfile : Form
    {
        IUserRepository _userRepository = new UserRepository();
        public frmShowTeacherProfile()
        {
            InitializeComponent();
        }
        User selectedTeacher;
        public frmShowTeacherProfile(User teacher)
        {
            InitializeComponent();
            selectedTeacher = teacher;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void LoadTeacherProfile()
        {
            try
            {
                if (selectedTeacher != null)
                {
                    if (selectedTeacher.IsShowProfile == true)
                    {
                        MessageTeacherHidedProfile.Visible = false;
                        txtFullName.Text = selectedTeacher.Name;
                        txtDateOfBirth.Text = selectedTeacher.DayOfBirth?.ToString("dd-MM-yyyy");
                        txtEmail.Text = selectedTeacher.Email;
                        txtMajor.Text = selectedTeacher.Major;
                        txtInfo.Text = selectedTeacher.Info;
                        txtStatus.Text = selectedTeacher.UserStatus;
                        txtRole.Text = "Teacher";
                        image1.Image = new Bitmap("D:\\Demo\\FU\\PRN211_G8_MeetMyLecturer\\MeetMyLecturerWinApp\\Resource\\" + selectedTeacher.Image);
                    }
                    else if (selectedTeacher.IsShowProfile == false)
                    {
                        image1.Image = new Bitmap("D:\\Demo\\FU\\PRN211_G8_MeetMyLecturer\\MeetMyLecturerWinApp\\Resource\\" + selectedTeacher.Image);
                        txtRole.Text = "Teacher";
                        MessageTeacherHidedProfile.Visible = true;
                    }

                }
                else
                {
                    MessageBox.Show("There is no current teacher", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load teacher profile: " + ex.Message, "Error");
            }
        }
        private void frmShowTeacherProfile_Load(object sender, EventArgs e)
        {
            LoadTeacherProfile();
            EnableText(false);
        }

        public void EnableText(bool status)
        {
            txtFullName.Enabled = status;
            txtEmail.Enabled = status;
            txtDateOfBirth.Enabled = status;
            txtInfo.Enabled = status;
            txtMajor.Enabled = status;
            txtRole.Enabled = status;
            txtStatus.Enabled = status;
        }
    }
}
