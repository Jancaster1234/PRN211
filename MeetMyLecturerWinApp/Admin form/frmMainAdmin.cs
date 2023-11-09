using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetMyLecturerWinApp.Admin_form
{
    public partial class frmMainAdmin : Form
    {
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        frmAdminActionRecord frmAdminActionRecordForm;
        frmManageStudent manageStudentForm;
        frmManageTeacher manageTeacherForm;
        frmAdminProfile frmAdminProfile;
        private void adminActionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAdminActionRecordForm == null)
            {
                frmAdminActionRecordForm = new frmAdminActionRecord();
                frmAdminActionRecordForm.MdiParent = this;
                frmAdminActionRecordForm.FormClosed += new FormClosedEventHandler(adminActionRecordForm_FormClosed);
                frmAdminActionRecordForm.Show();
            }
            else
            {
                frmAdminActionRecordForm.Activate();
            }
        }

        private void adminActionRecordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdminActionRecordForm = null;
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manageStudentForm == null)
            {
                manageStudentForm = new frmManageStudent();
                manageStudentForm.MdiParent = this;
                manageStudentForm.FormClosed += new FormClosedEventHandler(manageStudentForm_FormClosed);
                manageStudentForm.Show();
            }
            else
            {
                manageStudentForm.Activate();
            }
        }

        private void manageStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            manageStudentForm = null;
        }

        private void manageTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (manageTeacherForm == null)
            {
                manageTeacherForm = new frmManageTeacher();
                manageTeacherForm.MdiParent = this;
                manageTeacherForm.FormClosed += new FormClosedEventHandler(manageTeacherForm_FormClosed);
                manageTeacherForm.Show();
            }
            else
            {
                manageTeacherForm.Activate();
            }
        }

        private void manageTeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            manageTeacherForm = null;
        }

        private void adminProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAdminProfile == null)
            {
                frmAdminProfile = new frmAdminProfile();
                frmAdminProfile.MdiParent = this;
                frmAdminProfile.FormClosed += new FormClosedEventHandler(adminProfileForm_FormClosed);
                frmAdminProfile.Show();
            }
            else
            {
                frmAdminProfile.Activate();
            }
        }

        private void adminProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdminProfile = null;
        }

    }
}
