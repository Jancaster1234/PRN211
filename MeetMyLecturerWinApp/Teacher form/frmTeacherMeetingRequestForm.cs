using BusinessObject.Models;
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
            dgvMeetingRequests.CellContentDoubleClick += dgvMeetingRequests_CellContentDoubleClick;
        }

        private readonly Func<MeetingRequest, object> meetingRequestProjection = meetingRequest => new
        {
            Id = meetingRequest.Id,
            Student = meetingRequest.Student?.Name ?? "N/A",
            StudentEmail = meetingRequest.Student?.Email ?? "N/A",
            CreatedDate = meetingRequest.CreatedDate ?? DateTime.MinValue,
            Status = meetingRequest.Status,
            ReviewedDate = meetingRequest.ReviewedDate,
            IntegrateToSlotId = meetingRequest.SlotId,
            Message = meetingRequest.Message,
        };

        private int GetSelectedMeetingRequestId(Object selectRow)
        {
            var idProperty = selectRow.GetType().GetProperty("Id");

            if (idProperty != null && int.TryParse(idProperty.GetValue(selectRow)?.ToString(), out int id))
            {
                return id;
            }

            return -1;
        }

        //public string GetSelectedPasscodeRequestPasscode(Object selectRow)
        //{
        //    var slotIdProperty = selectRow.GetType().GetProperty("SlotId");
        //    if (slotIdProperty != null && int.TryParse(slotIdProperty.GetValue(selectRow)?.ToString(), out int slotId))
        //    {
        //        Slot slot = _slotRepository.GetSlotById(slotId);
        //        if (slot != null)
        //        {
        //            return slot.Passcode;
        //        }
        //    }
        //    return null;
        //}

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
                            DialogResult result = MessageBox.Show("Review: accept this meeting request?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    frmChooseSlotForMeetingRequest frm = new frmChooseSlotForMeetingRequest();
                                    frm.Show();
                                    int slotId = frm.SelectedSlotId;
                                    if (slotId != 0) // Check if a valid slot ID was selected
                                    {
                                        MeetingRequest meetingRequest = _meetingRequestRepository.GetMeetingRequestById(id);
                                        meetingRequest.SlotId = slotId;
                                        meetingRequest.Status = "Approved";
                                        meetingRequest.ReviewedDate = DateTime.Now;
                                        meetingRequest.Message = "Here is your slotId: " + slotId; // Include the slot ID in the message
                                        _meetingRequestRepository.UpdateMeetingRequest(meetingRequest);
                                        MessageBox.Show("Successfully review meeting request with id: " + ps.Id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LoadMeetingRequestList();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error occured in the process of review this meeting request with id: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (result == DialogResult.No)
                            {
                                try
                                {
                                    MeetingRequest meetingRequest = _meetingRequestRepository.GetMeetingRequestById(id);
                                    meetingRequest.Status = "Rejected";
                                    meetingRequest.ReviewedDate = DateTime.Now;
                                    meetingRequest.Message = "This meeting request is rejected!";
                                    _meetingRequestRepository.UpdateMeetingRequest(meetingRequest);
                                    MessageBox.Show("Successfully review meeting request with id: " + ps.Id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadMeetingRequestList();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error occured in the process of review this meeting request with id: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (result == DialogResult.Cancel)
                            {

                            }
                        }
                        else if (ps.Status == "Approved" || ps.Status == "Rejected")
                        {
                            MessageBox.Show("Can't modify meeting request that had been reviewed: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Meeting request not existed in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        public void LoadMeetingRequestList()
        {
            try
            {

                MessageIsListEmpty.Visible = false;

                var meetingRequestList = _meetingRequestRepository.FilterMeetingRequests(null, CurrentUser.Current.Id, null, null, null, null, null, null);

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

        private void dgvMeetingRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
