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

namespace MeetMyLecturerWinApp.Admin_form
{
    public partial class frmAdminActionRecord : Form
    {
        IActionRecordRepository _actionRecordRepository = new ActionRecordRepository();
        public frmAdminActionRecord()
        {
            InitializeComponent();
        }
        public void LoadActionRecordList()
        {
            try
            {
                var actionRecordList = _actionRecordRepository.FilterActionRecords(CurrentUser.Current.Id);
                BindingSource source = new BindingSource();
                source.DataSource = actionRecordList;
                dgvActionRecords.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of action records: " + ex.Message, "Error");
            }
        }
        private void frmAdminActionRecord_Load(object sender, EventArgs e)
        {
            LoadActionRecordList();
        }
    }
}
