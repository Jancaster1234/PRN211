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
    public partial class frmSlotDialog : Form
    {
        ISubjectRepository subjectRepository = new SubjectRepository();
        ISlotRepository slotRepository = new SlotRepository();
        int teacherId;
        DateTime date;
        TimeSpan start;
        TimeSpan end;
        bool hidePass = false;
        public frmSlotDialog(int teacherId, DateTime date, TimeSpan start, TimeSpan end)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            this.date = date;
            this.start = start;
            this.end = end;
        }
        private string generateRandomString(int lenght)
        {
            Random random = new Random();
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < lenght; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }
            return stringBuilder.ToString();
        }
        private void frmSlotDialog_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = subjectRepository.GetSubjects();

            cboSubject.DisplayMember = "Name"; // Display the Name property
            cboSubject.ValueMember = "Id";    // Use the Id property as the actual value
            // Add subjects to the ComboBox
            cboSubject.DataSource = subjects;

            txtDate.Text = date.ToString("dd/MM/yyyy");
            txtStart.Text = start.ToString();
            txtEnd.Text = end.ToString();

            rdActive.Checked = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPasscode.Text = generateRandomString(10);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (hidePass)
            {
                linkHide.Text = "Show";
                txtPasscode.UseSystemPasswordChar = true;
                hidePass = false;
            }
            else
            {
                linkHide.Text = "Hide";
                txtPasscode.UseSystemPasswordChar = false;
                hidePass = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int subjectId = (int)cboSubject.SelectedValue;
                string status = rdActive.Checked ? "Active" : "Inactive";
                Slot slot = new Slot(
                        0,
                        teacherId,
                        date,
                        start,
                        end,
                        txtPasscode.Text,
                        DateTime.Now,
                        txtMessage.Text,
                        status,
                        subjectId,
                        int.Parse(txtStudentLimit.Text)
                    );
                slotRepository.AddSlot(slot);
                this.Close();
                MessageBox.Show("Slot Added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gbStatus_Enter(object sender, EventArgs e)
        {

        }
    }
}
