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
using System.Xml.Linq;

namespace MeetMyLecturerWinApp
{
    public partial class frmStudent_SlotForm : Form
    {
        ISlotRepository _slotRepository = new SlotRepository();
        public frmStudent_SlotForm()
        {
            InitializeComponent();
        }
        public void LoadSlotList()
        {
            try
            {
                var slotList = _slotRepository.GetSlots();
                BindingSource source = new BindingSource();
                source.DataSource = slotList;
                dgvSlots.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of products: " + ex.Message, "Error");
            }
        }
        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtTeacher.Text = "";
            txtSubject.Text = "";
            startDatePicker.Value = DateTime.Now;
            endDatePicker.Value = DateTime.Now;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {

            string? email = string.IsNullOrWhiteSpace(txtTeacher.Text) ? null : txtTeacher.Text.Trim();
            string? major = string.IsNullOrWhiteSpace(txtSubject.Text) ? null : txtSubject.Text.Trim();
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            if (startDate <= endDate)
            {
                var searchResult = _slotRepository.FilterSlots(email, major, startDate, endDate);
                BindingSource source = new BindingSource();
                source.DataSource = searchResult;
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
