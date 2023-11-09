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

namespace MeetMyLecturerWinApp
{
    public partial class frmStudentMeetingRequestForm : Form
    {
        IMeetingRequestRepository _meetingRequestRepository = new MeetingRequestRepository();
        public frmStudentMeetingRequestForm()
        {
            InitializeComponent();
            dgvMeetingRequests.CellContentDoubleClick += dgvMeetingRequests_CellContentDoubleClick;
        }

        private readonly Func<MeetingRequest, object> meetingRequestProjection = meetingRequest => new
        {
            Id = meetingRequest.Id,
            Teacher = meetingRequest.Teacher?.Name ?? "N/A",
            TeacherEmail = meetingRequest.Teacher?.Email ?? "N/A",
            CreatedDate = meetingRequest.CreatedDate ?? DateTime.MinValue,
            Status = meetingRequest.Status,
            ReviewedDate = meetingRequest.ReviewedDate,
            IntegrateToSlotId = meetingRequest.SlotId,
            Message = meetingRequest.Message,
        };

        public void LoadMeetingRequestList()
        {
            try
            {
                MessageIsListEmpty.Visible = false;

                var meetingRequestList = _meetingRequestRepository.FilterMeetingRequests(CurrentUser.Current.Id, null, null, null, null, null, null, null);

                var presentedMeetingRequestList = meetingRequestList.Select(meetingRequestProjection).ToList();

                BindingSource source = new BindingSource();

                int columnIndexToHide = 0;

                source.DataSource = presentedMeetingRequestList;
                if (source.Count > 0)
                {
                    dgvMeetingRequests.DataSource = source;
                    dgvMeetingRequests.Columns[columnIndexToHide].Visible = false;
                }
                else
                {
                    dgvMeetingRequests.DataSource = null;
                    MessageIsListEmpty.Visible = true;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of meeting requests: " + ex.Message, "Error");
            }
        }
        private void frmStudentMeetingRequestForm_Load(object sender, EventArgs e)
        {
            LoadMeetingRequestList();
        }
        private int GetSelectedMeetingRequestId(Object selectRow)
        {
            var idProperty = selectRow.GetType().GetProperty("Id");

            if (idProperty != null && int.TryParse(idProperty.GetValue(selectRow)?.ToString(), out int id))
            {
                return id;
            }

            return -1;
        }
        private void dgvMeetingRequests_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the DataBoundItem
                var dataBoundItem = dgvMeetingRequests.Rows[e.RowIndex].DataBoundItem;
                if (dataBoundItem != null)
                {
                    int id = GetSelectedMeetingRequestId(dataBoundItem);
                    MeetingRequest ps = _meetingRequestRepository.GetMeetingRequestById(id);
                    if (ps != null)
                    {
                        if (ps.Status == "pending")
                        {
                            DialogResult result = MessageBox.Show("Do you want to delete this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    _meetingRequestRepository.DeleteMeetingRequest(ps);
                                    MessageBox.Show("Successfully delete meeting request with id: " + ps.Id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadMeetingRequestList();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error occured in the process of delete this meeting request with id: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else if (ps.Status == "Approved" || ps.Status == "Rejected")
                        {
                            MessageBox.Show("Can't modify meeting request that had been viewed by teacher: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Meeting Request not existed in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
