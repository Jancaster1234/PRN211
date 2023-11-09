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

namespace MeetMyLecturerWinApp
{
    public partial class frmStudentPasscodeRequestForm : Form
    {
        IPasscodeRequestRepository _passcodeRequestRepository = new PasscodeRequestRepository();
        public frmStudentPasscodeRequestForm()
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
                            DialogResult result = MessageBox.Show("Do you want to delete this request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    _passcodeRequestRepository.DeletePasscodeRequest(ps);
                                    MessageBox.Show("Successfully delete passcode request with id: " + ps.Id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadPasscodeRequestList();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error occured in the process of delete this passcode request with id: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else if (ps.Status == "Approved" || ps.Status == "Rejected")
                        {
                            MessageBox.Show("Can't modify passcode request that had been viewed by teacher: " + ps.Id, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passcode Request not existed in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
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

                var passcodeRequestList = _passcodeRequestRepository.FilterPasscodeRequests(CurrentUser.Current.Id, null, null, null, null, null, null);

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
