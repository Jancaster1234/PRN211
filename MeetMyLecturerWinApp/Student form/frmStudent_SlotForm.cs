using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using BusinessObject.Models;
using MeetMyLecturerWinApp.Student_form;
using System.Xml.Linq;

namespace MeetMyLecturerWinApp
{
    public partial class frmStudent_SlotForm : Form
    {
        ISlotRepository _slotRepository = new SlotRepository();
        public frmStudent_SlotForm()
        {
            InitializeComponent();
            dgvSlots.CellContentDoubleClick += dgvSlots_CellContentDoubleClick;
        }

        private readonly Func<Slot, object> slotProjection = slot => new
        {
            Id = slot.Id,
            Teacher = slot.Teacher?.Name ?? "N/A",
            TeacherEmail = slot.Teacher?.Email ?? "N/A",
            Date = slot.Date ?? DateTime.MinValue,
            StartTime = slot.StartTime ?? TimeSpan.Zero,
            EndTime = slot.EndTime ?? TimeSpan.Zero,
            RequiredPasscode = slot.Passcode != null,
            CreatedDate = slot.CreatedDate ?? DateTime.MinValue,
            Message = slot.Message ?? "N/A",
            Subject = slot.Subject?.Name ?? "N/A",
            StudentLimit = slot.StudentLimit ?? 0,
        };

        private void dgvSlots_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the DataBoundItem
                var dataBoundItem = dgvSlots.Rows[e.RowIndex].DataBoundItem;
                if (dataBoundItem != null)
                {
                    frmEnrollInSlot frm = new frmEnrollInSlot(dataBoundItem);
                    frm.Show();
                }
            }
        }

        public void LoadSlotList()
        {
            try
            {
                var slotList = _slotRepository.FilterSlots(null, null, null, null, "Active");
                var presentedSlotList = slotList.Select(slotProjection).ToList();

                BindingSource source = new BindingSource();

                int columnIndexToHide = 0;

                source.DataSource = presentedSlotList;
                dgvSlots.DataSource = source;
                dgvSlots.Columns[columnIndexToHide].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of slots: " + ex.Message, "Error");
            }
        }
        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtTeacher.Text = "";
            txtSubject.Text = "";
            startDatePicker.Value = DateTime.Now;
            endDatePicker.Value = DateTime.Now;
            LoadSlotList();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

            string? email = string.IsNullOrWhiteSpace(txtTeacher.Text) ? null : txtTeacher.Text.Trim();
            string? major = string.IsNullOrWhiteSpace(txtSubject.Text) ? null : txtSubject.Text.Trim();
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            if (startDate <= endDate)
            {
                var searchResult = _slotRepository.FilterSlots(email, major, startDate, endDate, "Active");
                var presentedSlotList = searchResult.Select(slotProjection).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = presentedSlotList;
                dgvSlots.DataSource = source;
            }
            else
            {
                MessageBox.Show("startDate > endDate", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int? GetNullableIntValue(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            if (int.TryParse(input.Trim(), out int parsedValue))
            {
                return parsedValue;
            }

            MessageBox.Show("Invalid input. Please enter a valid number for the field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        private void frmStudent_SlotForm_Load(object sender, EventArgs e)
        {
            LoadSlotList();
        }
    }
}
