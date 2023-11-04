using BusinessObject.Models;
using DataAccess;
using ExcelDataReader;
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
    public partial class frmTeacherSchedule : Form
    {
        DataTableCollection tableCollection;
        IScheduleRecordRepository scheduleRecordRepository = new ScheduleRecordRepository();
        public frmTeacherSchedule()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ds = tableCollection["Sheet1"];
                dataGridView1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtFilePath.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration()
                            {
                                FallbackEncoding = Encoding.GetEncoding(1252)
                            }))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                int count = 0;
                string startTimeStr;
                string endTimeStr;
                string room;
                string className;
                string dateStr = "";
                string courseName = "";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    count += 1;
                    // Skip the last row if it is the new row
                    if (!row.IsNewRow)
                    {
                        ;
                        // Retrieve the values from the row
                        if (count == 1)
                        {
                            courseName = row.Cells["Course Name"].Value.ToString();
                        }
                        if ((count - 1) % 6 == 0)
                        {
                            dateStr = row.Cells["Day"].Value.ToString();
                        }
                        startTimeStr = row.Cells["Start"].Value.ToString();
                        endTimeStr = row.Cells["End"].Value.ToString();
                        room = row.Cells["Room"].Value.ToString();
                        className = row.Cells["Class"].Value.ToString();

                        // Parse the date and time values
                        DateTime date = DateTime.Parse(dateStr);
                        TimeSpan startTime = TimeSpan.Parse(startTimeStr);
                        TimeSpan endTime = TimeSpan.Parse(endTimeStr);
                        int teacherId = 1;

                        if (className != "")
                        {
                            // Create the ScheduleRecord object
                            ScheduleRecord sr = new ScheduleRecord(
                                id: 0, // Provide the appropriate value for the ID
                                location: null, // Provide the appropriate value for the location
                                room: room,
                                className: className,
                                courseName: courseName,
                                date: date,
                                startTime: startTime,
                                endTime: endTime,
                                createdDate: DateTime.Now, // Provide the appropriate value for the created date
                                teacherId: teacherId // Provide the appropriate value for the teacher ID
                            );

                            // Add the ScheduleRecord to the list
                            scheduleRecordRepository.AddScheduleRecord(sr);
                        }
                    }
                }
                MessageBox.Show("Saved to database");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
