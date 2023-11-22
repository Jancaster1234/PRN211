using BusinessObject.Models;
using MeetMyLecturerWinApp.Admin_form;
using MeetMyLecturerWinApp.Teacher_form;

namespace MeetMyLecturerWinApp
{
    public partial class frmMain : Form
    {
        User user { get; set; }

        public frmMain(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (user.Role == 1)
            {
                btnPasscode.Visible = false;
                btnMeeting.Visible = false;
                btnSchedule.Visible = false;
                btnSearchSlot.Visible = false;
                btnSearchTeacher.Visible = false;
                btnManageSlot.Visible = false;
            }
            if (user.Role == 2)
            {
                btnStudents.Visible = false;
                btnTeachers.Visible = false;
                btnSearchSlot.Visible = false;
                btnSearchTeacher.Visible = false;
            }
            if (user.Role == 3)
            {
                btnStudents.Visible = false;
                btnTeachers.Visible = false;
                btnSchedule.Visible = false;
                btnManageSlot.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (user.Role)
            {
                case 2: OpenChildForm(new frmTeacherPasscodeRequestForm()); break;
                case 3: OpenChildForm(new frmStudentPasscodeRequestForm()); break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            switch (user.Role)
            {
                case 1: OpenChildForm(new frmAdminProfile()); break;
                case 2: OpenChildForm(new frmTeacherProfile()); break;
                case 3: OpenChildForm(new frmStudentProfile()); break;
            }
        }

        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStudentTeacherForm());
        }

        private void btnSearchSlot_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStudent_SlotForm());
        }

        private void btnMeeting_Click(object sender, EventArgs e)
        {
            switch (user.Role)
            {
                case 2: OpenChildForm(new frmTeacherMeetingRequestForm()); break;
                case 3: OpenChildForm(new frmStudentMeetingRequestForm()); break;
            }
        }

        private void btnManageSlot_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTeacher_SlotForm());
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTeacherSchedule());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageStudent());
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageTeacher());
        }

        private void btnActionRecord_Click(object sender, EventArgs e)
        {
            switch (user.Role)
            {
                case 1: OpenChildForm(new frmAdminActionRecord()); break;
                case 2: OpenChildForm(new frmTeacherActionRecordForm()); break;
                case 3: OpenChildForm(new frmStudentActionRecordForm()); break;
            }
        }
    }
}