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
    public partial class frmTeacherActionRecordForm : Form
    {
        IActionRecordRepository _actionRecordRepository = new ActionRecordRepository();
        public frmTeacherActionRecordForm()
        {
            InitializeComponent();
        }

        private readonly Func<ActionRecord, object> actionRecordProjection = actionRecord => new
        {
            Id = actionRecord.Id,
            Action = actionRecord.Action,
            CreatedDate = actionRecord.CreatedTime,
        };

        public void LoadActionRecordList()
        {
            try
            {
                MessageIsListEmpty.Visible = false;

                var actionRecordList = _actionRecordRepository.FilterActionRecords(CurrentUser.Current.Id);
                var presentedActionRecordList = actionRecordList.Select(actionRecordProjection).ToList();

                int columnIndexToHide = 0;

                BindingSource source = new BindingSource();
                source.DataSource = presentedActionRecordList;

                if (source.Count > 0)
                {
                    dgvActionRecords.DataSource = source;
                    dgvActionRecords.Columns[columnIndexToHide].Visible = false;
                }
                else
                {
                    dgvActionRecords.DataSource = null;
                    MessageIsListEmpty.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of action records: " + ex.Message, "Error");
            }
        }

        private void frmStudentActionRecordForm_Load(object sender, EventArgs e)
        {
            LoadActionRecordList();
        }
    }
}
