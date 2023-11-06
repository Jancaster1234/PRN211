using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;

namespace MeetMyLecturerWinApp.Teacher_form
{
    public partial class frmTeacherProfile : Form
    {
        IUserRepository _userRepository = new UserRepository();
        public frmTeacherProfile()
        {
            InitializeComponent();
        }

        private void frmStudentProfile_Load(object sender, EventArgs e)
        {
            LoadStudentProfile();
            EnableText(false);
        }
        private void EnableText(bool status)
        {
            txtFullName.Enabled = status;
            txtDateOfBirth.Enabled = status;
            txtEmail.Enabled = status;
            txtPassword.Enabled = status;
            txtMajor.Enabled = status;
            txtInfo.Enabled = status;
            txtStatus.Enabled = status;
            txtRole.Enabled = status;
            txtIsShowProfile.Enabled = status;
            txtIsShowSchedule.Enabled = status;
        }

        public void LoadStudentProfile()
        {
            try
            {
                if (CurrentUser.Current != null)
                {

                    txtFullName.Text = CurrentUser.Current.Name;
                    txtDateOfBirth.Text = CurrentUser.Current.DayOfBirth?.ToString("dd-MM-yyyy");
                    txtEmail.Text = CurrentUser.Current.Email;
                    txtPassword.Text = CurrentUser.Current.Password;
                    txtMajor.Text = CurrentUser.Current.Major;
                    txtInfo.Text = CurrentUser.Current.Info;
                    txtStatus.Text = CurrentUser.Current.UserStatus;
                    txtRole.Text = CurrentUser.Current.RoleNavigation?.Id.ToString();
                    txtIsShowProfile.Text = CurrentUser.Current.IsShowProfile.ToString();
                    txtIsShowSchedule.Text = CurrentUser.Current.IsShowSchedule.ToString();
                    image1.Image = new Bitmap("D:\\Demo\\FU\\PRN211_G8_MeetMyLecturer\\MeetMyLecturerWinApp\\Resource\\" + CurrentUser.Current.Image);
                }
                else
                {
                    MessageBox.Show("There is no current user", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load student profile: " + ex.Message, "Error");
            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    string userEmail = CurrentUser.Current.Email;
                    string newFilename = userEmail + Path.GetExtension(imageLocation);
                    // Check if the current image is not the default profile picture
                    if (image1.Image != null)
                    {
                        string currentImageFileName = Path.GetFileName(image1.ImageLocation);
                        if (currentImageFileName != "default_profile_picture")
                        {
                            // Delete the current image
                            File.Delete(Path.Combine(@"D:\Demo\FU\PRN211_G8_MeetMyLecturer\MeetMyLecturerWinApp\Resource", currentImageFileName));
                        }
                    }
                    image1.Image = new Bitmap(imageLocation);
                    File.Copy(imageLocation, Path.Combine(@"D:\Demo\FU\PRN211_G8_MeetMyLecturer\MeetMyLecturerWinApp\Resource", newFilename), true);
                    _userRepository.UpdateUserImage(CurrentUser.Current, newFilename);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Cancel";
                btnSave.Enabled = true;
                EnableText(true);
            }
            else
            {
                btnEdit.Text = "Edit";
                btnSave.Enabled = false;
                EnableText(false);
                LoadStudentProfile();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                User user = CreateUserFromForm();

                _userRepository.UpdateUser(user);
                btnEdit.Text = "Edit";

                EnableText(false);
                btnSave.Enabled = false;
                LoadStudentProfile();

            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtPassword.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtMajor.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtInfo.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtStatus.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtIsShowProfile.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtIsShowSchedule.Text.Trim())
               )
            {
                MessageBox.Show("All fields are required!", "Member Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // You can add additional validation logic for other fields here.

            return true;
        }

        private User CreateUserFromForm()
        {
            try
            {
                User newUser = new User();

                // Set properties from the form
                newUser.Password = txtPassword.Text;

                // Set other properties as needed
                newUser.Name = txtFullName.Text;
                DateTime dateOfBirth;
                if (DateTime.TryParseExact(txtDateOfBirth.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
                {
                    newUser.DayOfBirth = dateOfBirth;
                }
                newUser.Email = txtEmail.Text;
                newUser.Major = txtMajor.Text;
                newUser.Info = txtInfo.Text;
                newUser.UserStatus = txtStatus.Text;

                // Handle nullable properties
                bool isShowProfile;
                if (bool.TryParse(txtIsShowProfile.Text, out isShowProfile))
                {
                    newUser.IsShowProfile = isShowProfile;
                }

                bool isShowSchedule;
                if (bool.TryParse(txtIsShowSchedule.Text, out isShowSchedule))
                {
                    newUser.IsShowSchedule = isShowSchedule;
                }

                int role;
                if (int.TryParse(txtRole.Text, out role))
                {
                    newUser.Role = role;
                }

                // Additional property assignments can be added as needed

                return newUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user from form: " + ex.Message, "Error");
                return null; // or handle the error as needed
            }
        }
    }
}
