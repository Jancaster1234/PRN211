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
using BusinessObject.Models;

namespace MeetMyLecturerWinApp.Teacher_form
{
    public partial class frmChooseSlotForMeetingRequest : Form
    {
        ISlotRepository _slotRepository = new SlotRepository();
        public frmChooseSlotForMeetingRequest()
        {
            InitializeComponent();
        }

        private void frmChooseSlotForMeetingRequest_Load(object sender, EventArgs e)
        {

        }
        public int SelectedSlotId { get; private set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Set the selected slot ID from the textbox
            if (int.TryParse(txtSlotId.Text, out int slotId))
            {
                Slot slot = _slotRepository.GetSlotById(slotId);
                if (slot != null)
                {
                  


                }
                SelectedSlotId = slotId;
                this.Close(); // Close the form after setting the value
            }
            else
            {
                MessageBox.Show("Invalid slot ID. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
