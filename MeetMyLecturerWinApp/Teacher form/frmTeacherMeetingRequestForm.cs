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

namespace MeetMyLecturerWinApp.Teacher_form
{
    public partial class frmTeacherMeetingRequestForm : Form
    {
        IMeetingRequestRepository _meetingRequestRepository = new MeetingRequestRepository();
        public frmTeacherMeetingRequestForm()
        {
            InitializeComponent();
        }
        public void LoadMeetingRequestList()
        {
            try
            {
                var meetingRequestList = _meetingRequestRepository.FilterMeetingRequests(CurrentUser.Current.Id, null, null, null, null, null, null, null);
                BindingSource source = new BindingSource();
                source.DataSource = meetingRequestList;
                dgvMeetingRequests.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of action records: " + ex.Message, "Error");
            }
        }
        private void frmStudentMeetingRequestForm_Load(object sender, EventArgs e)
        {
            LoadMeetingRequestList();
        }

        private void dgvMeetingRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
