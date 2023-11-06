using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetMyLecturerWinApp.Student_form
{
    public partial class frmMainStudent : Form
    {
        public frmMainStudent()
        {
            InitializeComponent();
        }
        frmStudent_SlotForm frmStudent_SlotForm;
        frmStudentActionRecordForm frmStudentActionRecordForm;
        frmStudentMeetingRequestForm studentMeetingRequestForm;
        frmStudentPasscodeRequestForm fPasscodeRequests;
        frmStudentProfile frmStudentProfile;
        frmStudentTeacherForm fTeacher;

        private void slotFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmStudent_SlotForm == null)
            {
                frmStudent_SlotForm = new frmStudent_SlotForm();
                frmStudent_SlotForm.MdiParent = this;
                frmStudent_SlotForm.FormClosed += new FormClosedEventHandler(FMembers_FormClosed);
                frmStudent_SlotForm.Show();
            }
            else
            {
                frmStudent_SlotForm.Activate();
            }
        }

        private void FMembers_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStudent_SlotForm = null;
        }
        private void meetingRequestFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (studentMeetingRequestForm == null)
            {
                studentMeetingRequestForm = new frmStudentMeetingRequestForm();
                studentMeetingRequestForm.MdiParent = this;
                studentMeetingRequestForm.FormClosed += new FormClosedEventHandler(FMembers_FormClosed);
                studentMeetingRequestForm.Show();
            }
            else
            {
                studentMeetingRequestForm.Activate();
            }
        }

        private void passcodeRequestFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fPasscodeRequests == null)
            {
                fPasscodeRequests = new frmStudentPasscodeRequestForm();
                fPasscodeRequests.MdiParent = this;
                fPasscodeRequests.FormClosed += new FormClosedEventHandler(FMembers_FormClosed);
                fPasscodeRequests.Show();
            }
            else
            {
                fPasscodeRequests.Activate();
            }
        }

        private void profileFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmStudentProfile == null)
            {
                frmStudentProfile = new frmStudentProfile();
                frmStudentProfile.MdiParent = this;
                frmStudentProfile.FormClosed += new FormClosedEventHandler(FMembers_FormClosed);
                frmStudentProfile.Show();
            }
            else
            {
                frmStudentProfile.Activate();
            }
        }

        private void teacherFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fTeacher == null)
            {
                fTeacher = new frmStudentTeacherForm();
                fTeacher.MdiParent = this;
                fTeacher.FormClosed += new FormClosedEventHandler(FMembers_FormClosed);
                fTeacher.Show();
            }
            else
            {
                fTeacher.Activate();
            }
        }

        // Add similar FormClosed event handler for each form
        private void meetingRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            studentMeetingRequestForm = null;
        }

        private void passcodeRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fPasscodeRequests = null;
        }

        private void profileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStudentProfile = null;
        }

        private void teacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fTeacher = null;
        }
        private void actionRecordFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmStudentActionRecordForm == null)
            {
                frmStudentActionRecordForm = new frmStudentActionRecordForm();
                frmStudentActionRecordForm.MdiParent = this;
                frmStudentActionRecordForm.FormClosed += new FormClosedEventHandler(FMembers_FormClosed);
                frmStudentActionRecordForm.Show();
            }
            else
            {
                frmStudentActionRecordForm.Activate();
            }
        }

        // Add similar FormClosed event handler for this form
        private void actionRecordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStudentActionRecordForm = null;
        }

    }
}
