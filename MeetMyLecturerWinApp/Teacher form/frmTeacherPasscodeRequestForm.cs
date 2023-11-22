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
    public partial class frmTeacherPasscodeRequestForm : Form
    {
        ISlotRepository _slotRepository = new SlotRepository();
        IPasscodeRequestRepository _passcodeRequestRepository = new PasscodeRequestRepository();
        public frmTeacherPasscodeRequestForm()
        {
            InitializeComponent();
            dgvPasscodeRequests.CellContentDoubleClick += dgvSlots_CellContentDoubleClick;
        }
        private void dgvSlots_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the DataBoundItem
                var dataBoundItem = dgvPasscodeRequests.Rows[e.RowIndex].DataBoundItem;
                if (dataBoundItem != null)
                {
                    int id = GetSelectedPasscodeRequestId(dataBoundItem);
                    PasscodeRequest ps = _passcodeRequestRepository.GetPasscodeRequestById(id);
                    if (ps != null)
                    {
                        if (ps.Status == "pending")
                        {
                            DialogResult result = MessageBox.Show("Review: accept this passcode request?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    PasscodeRequest passcodeRequest = _passcodeRequestRepository.GetPasscodeRequestById(id);
                                    passcodeRequest.Status = "Approved";
                                    passcodeRequest.ReviewedDate = DateTime.Now;
                                    passcodeRequest.Message = "Here is your passcode: " + GetSelectedPasscodeRequestPasscode(dataBoundItem);
                                    _passcodeRequestRepository.UpdatePasscodeRequest(passcodeRequest);
                                    MessageBox.Show("Successfully review passcode request with id: " + ps.Id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadPasscodeRequestList();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error occured in the process of review this passcode request with id: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (result == DialogResult.No)
                            {
                                try
                                {
                                    PasscodeRequest passcodeRequest = _passcodeRequestRepository.GetPasscodeRequestById(id);
                                    passcodeRequest.Status = "Rejected";
                                    passcodeRequest.ReviewedDate = DateTime.Now;
                                    passcodeRequest.Message = "This passcode request is rejected!";
                                    _passcodeRequestRepository.UpdatePasscodeRequest(passcodeRequest);
                                    MessageBox.Show("Successfully review passcode request with id: " + ps.Id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadPasscodeRequestList();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error occured in the process of review this passcode request with id: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (result == DialogResult.Cancel)
                            {

                            }
                        }
                        else if (ps.Status == "Approved" || ps.Status == "Rejected")
                        {
                            MessageBox.Show("Can't modify passcode request that had been reviewed: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passcode Request not existed in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        public string GetSelectedPasscodeRequestPasscode(Object selectRow)
        {
            var slotIdProperty = selectRow.GetType().GetProperty("SlotId");
            if (slotIdProperty != null && int.TryParse(slotIdProperty.GetValue(selectRow)?.ToString(), out int slotId))
            {
                Slot slot = _slotRepository.GetSlotById(slotId);
                if (slot != null)
                {
                    return slot.Passcode;
                }
            }
            return null;
        }
        private int GetSelectedPasscodeRequestId(Object selectRow)
        {
            var idProperty = selectRow.GetType().GetProperty("Id");

            if (idProperty != null && int.TryParse(idProperty.GetValue(selectRow)?.ToString(), out int id))
            {
                return id;
            }

            return -1;
        }

        private readonly Func<PasscodeRequest, object> passcodeRequestProjection = passcodeRequest => new
        {
            Id = passcodeRequest.Id,
            SlotId = passcodeRequest.SlotId,
            Student = passcodeRequest.Student.Name ?? "N/A",
            StudentEmail = passcodeRequest.Student.Email ?? "N/A",
            CreatedDate = passcodeRequest.CreatedDate,
            Status = passcodeRequest.Status,
            ReviewedDate = passcodeRequest.ReviewedDate,
            Message = passcodeRequest.Message,
        };
        public void LoadPasscodeRequestList()
        {
            try
            {
                MessageIsListEmpty.Visible = false;

                List<Slot> slots = _slotRepository.FilterSlots(CurrentUser.Current.Email, null, null, null, null);
                var passcodeRequestList = new List<PasscodeRequest>();
                foreach (Slot slot in slots)
                {
                    var slotId = slot.Id;
                    var passcodeRequestsForSlot = _passcodeRequestRepository.FilterPasscodeRequests(null, null, null, null, null, null, slotId);
                    passcodeRequestList.AddRange(passcodeRequestsForSlot);
                }
                passcodeRequestList = passcodeRequestList.OrderBy(pr => pr.CreatedDate).ToList();

                var presentedPasscodeRequestList = passcodeRequestList.Select(passcodeRequestProjection).ToList();

                int columnIndexToHide = 0;

                BindingSource source = new BindingSource();
                source.DataSource = presentedPasscodeRequestList;

                if (source.Count > 0)
                {
                    dgvPasscodeRequests.DataSource = source;
                    dgvPasscodeRequests.Columns[columnIndexToHide].Visible = false;
                }
                else
                {
                    dgvPasscodeRequests.DataSource = null;
                    MessageIsListEmpty.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of passcode requests: " + ex.Message, "Error");
            }
        }
        private void frmStudentPasscodeRequestForm_Load(object sender, EventArgs e)
        {
            LoadPasscodeRequestList();
        }
    }
}
