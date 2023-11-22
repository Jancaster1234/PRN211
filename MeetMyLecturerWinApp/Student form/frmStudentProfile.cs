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
using System.Xml.Linq;
using BusinessObject.Models;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace MeetMyLecturerWinApp
{
    public partial class frmStudentProfile : Form
    {
        IUserRepository _userRepository = new UserRepository();
        public frmStudentProfile()
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
        }

        public void LoadStudentProfile()
        {
            try
            {
                if (CurrentUser.Current != null)
                {
                    btnSave.Enabled = false;
                    txtFullName.Text = CurrentUser.Current.Name;
                    txtDateOfBirth.Text = CurrentUser.Current.DayOfBirth?.ToString("dd-MM-yyyy");
                    txtEmail.Text = CurrentUser.Current.Email;
                    txtPassword.Text = CurrentUser.Current.Password;
                    txtMajor.Text = CurrentUser.Current.Major;
                    txtInfo.Text = CurrentUser.Current.Info;
                    txtStatus.Text = CurrentUser.Current.UserStatus;
                    if (CurrentUser.Current.IsShowProfile == false)
                    {
                        btnPublicProfile.Text = "OFF-ed";
                    }
                    else if (CurrentUser.Current.IsShowProfile == true)
                    {
                        btnPublicProfile.Text = "ON-ed";
                    }
                    txtRole.Text = "Student";
                    image1.Image = new Bitmap("D:\\Demo\\FU\\PRN211_G8_MeetMyLecturer\\MeetMyLecturerWinApp\\Resource\\" + CurrentUser.Current.Image);
                }
                else
                {
                    MessageBox.Show("There is no current user", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load teacher profile: " + ex.Message, "Error");
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
                    string imageFolderPath = @"D:\Demo\FU\PRN211_G8_MeetMyLecturer\MeetMyLecturerWinApp\Resource";
                    string newFilePath = Path.Combine(imageFolderPath, newFilename);

                    if (File.Exists(newFilePath))
                    {
                        File.Delete(newFilePath); // Delete the old image if it exists
                    }

                    image1.Image = new Bitmap(imageLocation);
                    File.Copy(imageLocation, newFilePath, true);
                    CurrentUser.Current.Image = newFilename;
                    _userRepository.UpdateUserImage(CurrentUser.Current, newFilename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                btnEdit.Text = "Cancel";
                btnSave.Enabled = true;
                txtPassword.Enabled = true;
                txtFullName.Enabled = true;
                txtInfo.Enabled = true;
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
                EditUserFromForm();
                CurrentUser.SetCurrentUser(CurrentUser.Current);
                _userRepository.UpdateUser(CurrentUser.Current);
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
                string.IsNullOrWhiteSpace(txtStatus.Text.Trim())
               )
            {
                MessageBox.Show("All fields are required!", "Member Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // You can add additional validation logic for other fields here.

            return true;
        }

        private void EditUserFromForm()
        {
            try
            {


                // Set properties from the form
                CurrentUser.Current.Password = txtPassword.Text;

                // Set other properties as needed
                CurrentUser.Current.Name = txtFullName.Text;
                DateTime dateOfBirth;
                if (DateTime.TryParseExact(txtDateOfBirth.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
                {
                    CurrentUser.Current.DayOfBirth = dateOfBirth;
                }
                CurrentUser.Current.Info = txtInfo.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error edit user from form: " + ex.Message, "Error");
            }
        }

        private void btnPublicProfile_Click(object sender, EventArgs e)
        {
            if (btnPublicProfile.Text == "ON-ed")
            {
                btnPublicProfile.Text = "OFF-ed";
                CurrentUser.Current.IsShowProfile = false;
                _userRepository.ChangeIsShowProfile(CurrentUser.Current, false);
            }
            else
            {
                btnPublicProfile.Text = "ON-ed";
                CurrentUser.Current.IsShowProfile = true;
                _userRepository.ChangeIsShowProfile(CurrentUser.Current, true);
            }
        }
    }
}
