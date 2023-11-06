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
        }
        public void LoadPasscodeRequestList()
        {
            try
            {
                var passcodeRequestList = _passcodeRequestRepository.FilterPasscodeRequests(CurrentUser.Current.Id, null, null, null, null, null, null);
                BindingSource source = new BindingSource();
                source.DataSource = passcodeRequestList;
                dgvPasscodeRequests.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of action records: " + ex.Message, "Error");
            }
        }
        private void frmStudentPasscodeRequestForm_Load(object sender, EventArgs e)
        {
            LoadPasscodeRequestList();
        }
    }
}
