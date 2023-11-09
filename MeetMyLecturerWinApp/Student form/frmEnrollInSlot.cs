using BusinessObject.Models;
using Microsoft.IdentityModel.Tokens;
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

namespace MeetMyLecturerWinApp.Student_form
{
    public partial class frmEnrollInSlot : Form
    {
        ISlotRepository _slotRepository = new SlotRepository();
        ISlotRecordRepository _slotRecordRepository = new SlotRecordRepository();
        IPasscodeRequestRepository _passcodeRequestRepository = new PasscodeRequestRepository();
        public frmEnrollInSlot()
        {
            InitializeComponent();
        }
        public frmEnrollInSlot(object selectedRow)
        {
            InitializeComponent();
            selectRow = selectedRow;
        }
        Object selectRow;
        private void frmEnrollInSlot_Load(object sender, EventArgs e)
        {
            LoadSelectedRow();
        }
        public void LoadSelectedRow()
        {
            if (selectRow != null)
            {
                var type = selectRow.GetType();

                var teacherProperty = type.GetProperty("Teacher");
                var teacherEmailProperty = type.GetProperty("TeacherEmail");
                var dateProperty = type.GetProperty("Date");
                var startTimeProperty = type.GetProperty("StartTime");
                var endTimeProperty = type.GetProperty("EndTime");
                var requiredPasscodeProperty = type.GetProperty("RequiredPasscode");
                var createdDateProperty = type.GetProperty("CreatedDate");
                var messageProperty = type.GetProperty("Message");
                var subjectProperty = type.GetProperty("Subject");
                var studentLimitProperty = type.GetProperty("StudentLimit");

                EnableText(false);

                if (teacherProperty != null)
                {
                    var teacherValue = teacherProperty.GetValue(selectRow)?.ToString() ?? "N/A";
                    txtTeacher.Text = teacherValue;
                }
                if (teacherEmailProperty != null)
                {
                    var teacherEmailValue = teacherEmailProperty.GetValue(selectRow)?.ToString() ?? "N/A";
                    txtTeacherEmail.Text = teacherEmailValue;
                }

                if (dateProperty != null)
                {
                    var dateValue = (DateTime)(dateProperty.GetValue(selectRow) ?? DateTime.MinValue);
                    txtDate.Text = dateValue.ToString("dd/MM/yyyy");
                }

                if (startTimeProperty != null)
                {
                    var startTimeValue = (TimeSpan)(startTimeProperty.GetValue(selectRow) ?? TimeSpan.Zero);
                    txtStartTime.Text = startTimeValue.ToString("hh\\:mm\\:ss");
                }

                if (endTimeProperty != null)
                {
                    var endTimeValue = (TimeSpan)(endTimeProperty.GetValue(selectRow) ?? TimeSpan.Zero);
                    txtEndTime.Text = endTimeValue.ToString("hh\\:mm\\:ss");
                }

                if (requiredPasscodeProperty != null)
                {
                    var requiredPasscodeValue = (bool)(requiredPasscodeProperty.GetValue(selectRow) ?? false);
                    if (requiredPasscodeValue == true)
                    {
                        rabtnRequiredPasscode.Checked = true;
                        btnRequestPasscode.Enabled = true;
                        txtEnterPasscode.Enabled = true;
                    }
                    else if (requiredPasscodeValue == false)
                    {
                        rabtnRequiredPasscode.Checked = false;
                        btnRequestPasscode.Enabled = false;
                        txtEnterPasscode.Enabled = false;
                        txtEnterPasscode.Text = "No need to input";
                    }
                }
                List<PasscodeRequest> pc = _passcodeRequestRepository
                    .FilterPasscodeRequests(CurrentUser.Current.Id, null, null
                    , "pending", null, null, GetSelectedSlotId());
                if (!pc.IsNullOrEmpty())
                {
                    btnRequestPasscode.Enabled = false;
                    RequestPasscodeMessage.Visible = true;
                }

                if (createdDateProperty != null)
                {
                    var createdDateValue = (DateTime)(createdDateProperty.GetValue(selectRow) ?? DateTime.MinValue);
                    txtCreatedDate.Text = createdDateValue.ToString("dd/MM/yyyy");
                }

                if (messageProperty != null)
                {
                    var messageValue = messageProperty.GetValue(selectRow)?.ToString() ?? "None";
                    txtMessage.Text = messageValue;
                }

                if (subjectProperty != null)
                {
                    var subjectValue = subjectProperty.GetValue(selectRow)?.ToString() ?? "N/A";
                    txtSubject.Text = subjectValue;
                }

                if (studentLimitProperty != null)
                {
                    var studentLimitValue = studentLimitProperty.GetValue(selectRow) ?? 0;
                    txtStudentLimit.Text = studentLimitValue.ToString();
                }
            }
        }
        public void EnableText(bool status)
        {
            txtTeacher.Enabled = status;
            txtTeacherEmail.Enabled = status;
            txtDate.Enabled = status;
            txtCreatedDate.Enabled = status;
            txtMessage.Enabled = status;
            txtSubject.Enabled = status;
            txtStudentLimit.Enabled = status;
            txtEndTime.Enabled = status;
            txtStartTime.Enabled = status;
            rabtnRequiredPasscode.Enabled = status;
            txtEnterPasscode.Enabled = status;
            RequestPasscodeMessage.Visible = status;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (rabtnRequiredPasscode.Checked)
            {
                EnrollWithPasscode();
            }
            else
            {
                EnrollWithoutPasscode();
            }
        }

        private void EnrollWithPasscode()
        {
            try
            {
                string passcode = txtEnterPasscode.Text;
                int slotId = GetSelectedSlotId();

                if (slotId != -1)
                {
                    Slot slot = _slotRepository.GetSlotById(slotId);

                    if (passcode == slot.Passcode)
                    {
                        int userId = CurrentUser.Current.Id;
                        DateTime createdDate = DateTime.Now;

                        SlotRecord slotRecord = new SlotRecord()
                        {
                            SlotId = slotId,
                            StudentId = userId,
                            CreatedDate = createdDate
                        };

                        _slotRecordRepository.AddSlotRecord(slotRecord);
                    }
                    else
                    {
                        ShowErrorMessage("Your passcode " + passcode + " is not correct");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error in the enrollment process: " + ex.Message);
            }
        }

        private void EnrollWithoutPasscode()
        {
            int slotId = GetSelectedSlotId();

            if (slotId != -1)
            {
                SlotRecord slotRecord = new SlotRecord()
                {
                    SlotId = slotId,
                    StudentId = CurrentUser.Current.Id,
                    CreatedDate = DateTime.Now
                };

                _slotRecordRepository.AddSlotRecord(slotRecord);
            }
        }

        private int GetSelectedSlotId()
        {
            var idProperty = selectRow.GetType().GetProperty("Id");

            if (idProperty != null && int.TryParse(idProperty.GetValue(selectRow)?.ToString(), out int id))
            {
                return id;
            }

            return -1;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnRequestPasscode_Click(object sender, EventArgs e)
        {
            try
            {
                PasscodeRequest passcodeRequest = new PasscodeRequest()
                {
                    SlotId = GetSelectedSlotId(),
                    StudentId = CurrentUser.Current.Id,
                    CreatedDate = DateTime.Now,
                    Status = "pending",
                    ReviewedDate = null,
                    Message = null
                };
                _passcodeRequestRepository.AddPasscodeRequest(passcodeRequest);
                MessageBox.Show("Passcode request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<PasscodeRequest> pc = _passcodeRequestRepository
    .FilterPasscodeRequests(CurrentUser.Current.Id, null, null
    , "pending", null, null, GetSelectedSlotId());
                if (!pc.IsNullOrEmpty())
                {
                    btnRequestPasscode.Enabled = false;
                    RequestPasscodeMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
