using BusinessObject.Models;
using MeetMyLecturerWinApp.Student_form;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MeetMyLecturerWinApp
{
    public partial class frmStudentTeacherForm : Form
    {
        IUserRepository _userRepository = new UserRepository();
        public frmStudentTeacherForm()
        {
            InitializeComponent();
            dgvTeachers.CellContentDoubleClick += dgvTeachers_CellContentDoubleClick;
        }
        private readonly Func<User, object> teacherProjection = teacher => new
        {
            Id = teacher.Id,
            Teacher = teacher.Name,
            TeacherEmail = teacher.Email ?? "N/A",
            Major = teacher.Major,
            Info = teacher.Info,
        };

        private void dgvTeachers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the DataBoundItem
                var dataBoundItem = dgvTeachers.Rows[e.RowIndex].DataBoundItem;
                if (dataBoundItem != null)
                {
                    int id = GetSelectedSlotId(dataBoundItem);
                    User teacher = _userRepository.GetUser(id);
                    if (teacher != null)
                    {
                        frmShowTeacherProfile frm = new frmShowTeacherProfile(teacher);
                        frm.Show();
                    }
                }
            }
        }

        private int GetSelectedSlotId(Object selectRow)
        {
            var idProperty = selectRow.GetType().GetProperty("Id");

            if (idProperty != null && int.TryParse(idProperty.GetValue(selectRow)?.ToString(), out int id))
            {
                return id;
            }

            return -1;
        }
        public void LoadTeacherList()
        {
            try
            {
                var teacherList = _userRepository.FilterUsers("teacher", null, null, null);

                var presentedTeacherList = teacherList.Select(teacherProjection).ToList();

                BindingSource source = new BindingSource();

                int columnIndexToHide = 0;

                source.DataSource = presentedTeacherList;
                dgvTeachers.DataSource = source;

                dgvTeachers.Columns[columnIndexToHide].Visible = false;
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
            LoadTeacherList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string? email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
            string? major = string.IsNullOrWhiteSpace(txtMajor.Text) ? null : txtMajor.Text.Trim();
            string? name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim();


            // Call the search method in _productRepository (you need to implement this method in ProductDAO)
            var searchResult = _userRepository.FilterUsers("teacher", email, major, name);

            var presentedTeacherList = searchResult.Select(teacherProjection).ToList();

            // You can update the DataGridView with the search results
            BindingSource source = new BindingSource();

            int columnIndexToHide = 0;

            source.DataSource = presentedTeacherList;
            dgvTeachers.DataSource = source;

            dgvTeachers.Columns[columnIndexToHide].Visible = false;
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
