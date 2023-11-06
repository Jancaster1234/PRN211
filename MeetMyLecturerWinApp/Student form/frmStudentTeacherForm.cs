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
    public partial class frmStudentTeacherForm : Form
    {
        IUserRepository _userRepository = new UserRepository();
        public frmStudentTeacherForm()
        {
            InitializeComponent();
        }

        public void LoadTeacherList()
        {
            try
            {
                var teacherList = _userRepository.FilterUsers("teacher", null, null, null);
                BindingSource source = new BindingSource();
                source.DataSource = teacherList;
                dgvTeachers.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of teachers: " + ex.Message, "Error");
            }
        }
        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtMajor.Text = "";
            txtName.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string? email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
            string? major = string.IsNullOrWhiteSpace(txtMajor.Text) ? null : txtMajor.Text.Trim();
            string? name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim();


            // Call the search method in _productRepository (you need to implement this method in ProductDAO)
            var searchResult = _userRepository.FilterUsers("teacher", email, major, name);

            // You can update the DataGridView with the search results
            BindingSource source = new BindingSource();
            source.DataSource = searchResult;
            dgvTeachers.DataSource = source;
        }

        private int? GetNullableIntValue(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            if (int.TryParse(input.Trim(), out int parsedValue))
            {
                return parsedValue;
            }

            MessageBox.Show("Invalid input. Please enter a valid number for the field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private void frmStudentTeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeacherList();
        }
    }
}
