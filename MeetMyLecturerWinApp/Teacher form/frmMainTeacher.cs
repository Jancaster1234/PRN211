using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetMyLecturerWinApp.Teacher_form
{
    public partial class frmMainTeacher : Form
    {
        public frmMainTeacher()
        {
            InitializeComponent();
        }

        frmTeacher_SlotForm frmTeacher_SlotForm;
        frmTeacherActionRecordForm frmTeacherActionRecordForm;
        frmTeacherMeetingRequestForm teacherMeetingRequestForm;
        frmTeacherPasscodeRequestForm fPasscodeRequests;
        frmTeacherProfile frmTeacherProfile;

        private void slotFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTeacher_SlotForm == null)
            {
                frmTeacher_SlotForm = new frmTeacher_SlotForm();
                frmTeacher_SlotForm.MdiParent = this;
                frmTeacher_SlotForm.FormClosed += new FormClosedEventHandler(slotForm_FormClosed);
                frmTeacher_SlotForm.Show();
            }
            else
            {
                frmTeacher_SlotForm.Activate();
            }
        }

        private void slotForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTeacher_SlotForm = null;
        }

        private void actionRecordFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTeacherActionRecordForm == null)
            {
                frmTeacherActionRecordForm = new frmTeacherActionRecordForm();
                frmTeacherActionRecordForm.MdiParent = this;
                frmTeacherActionRecordForm.FormClosed += new FormClosedEventHandler(actionRecordForm_FormClosed);
                frmTeacherActionRecordForm.Show();
            }
            else
            {
                frmTeacherActionRecordForm.Activate();
            }
        }

        private void actionRecordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTeacherActionRecordForm = null;
        }

        private void meetingRequestFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (teacherMeetingRequestForm == null)
            {
                teacherMeetingRequestForm = new frmTeacherMeetingRequestForm();
                teacherMeetingRequestForm.MdiParent = this;
                teacherMeetingRequestForm.FormClosed += new FormClosedEventHandler(meetingRequestForm_FormClosed);
                teacherMeetingRequestForm.Show();
            }
            else
            {
                teacherMeetingRequestForm.Activate();
            }
        }

        private void meetingRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            teacherMeetingRequestForm = null;
        }

        private void passcodeRequestFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fPasscodeRequests == null)
            {
                fPasscodeRequests = new frmTeacherPasscodeRequestForm();
                fPasscodeRequests.MdiParent = this;
                fPasscodeRequests.FormClosed += new FormClosedEventHandler(passcodeRequestForm_FormClosed);
                fPasscodeRequests.Show();
            }
            else
            {
                fPasscodeRequests.Activate();
            }
        }

        private void passcodeRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fPasscodeRequests = null;
        }

        private void profileFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTeacherProfile == null)
            {
                frmTeacherProfile = new frmTeacherProfile();
                frmTeacherProfile.MdiParent = this;
                frmTeacherProfile.FormClosed += new FormClosedEventHandler(profileForm_FormClosed);
                frmTeacherProfile.Show();
            }
            else
            {
                frmTeacherProfile.Activate();
            }
        }

        private void profileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTeacherProfile = null;
        }

        private void frmMainTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
