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
        ISlotRepository slotRepository = new SlotRepository();
        int page = 0;
        int teacherId = 1;
        DateTime startDate = GetBeginningOfWeek(DateTime.Now);


        public frmTeacherSchedule()
        {
            InitializeComponent();
        }

        static DateTime GetBeginningOfWeek(DateTime date)
        {
            int daysToSubtract = (int)date.DayOfWeek - (int)DayOfWeek.Monday;
            if (daysToSubtract < 0)
            {
                daysToSubtract += 7;
            }
            DateTime beginningOfWeek = date.AddDays(-daysToSubtract);
            return beginningOfWeek;
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
                        btnSave.Visible = true;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadSchedule()
        {
            try
            {
                flowPanel_items.Controls.Clear();
                string room, className;
                int slot = 0;
                bool isSlot;
                TimeSpan additionalTimeSpan = TimeSpan.FromMinutes(90);
                string[] dayOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                string[] startTime = new string[] { "16:00:00", "14:15:00", "12:30:00", "10:30:00", "8:45:00", "7:00:00" };
                flowPanel_items.FlowDirection = FlowDirection.LeftToRight;
                lbDateWeek.Text = startDate.AddDays(page * 7).ToString("dd/MM/yyyy") + " - "
                    + startDate.AddDays(page * 7 + 6).ToString("dd/MM/yyyy");
                for (int i = 41; i >= 0; i--)
                {
                    isSlot = false;
                    if (i % 7 == 6)
                    {
                        slot += 1;
                    }
                    TimeSpan start = TimeSpan.Parse(startTime[slot - 1]);
                    DateTime date = startDate.AddDays(page * 7 + (i % 7));

                    ScheduleRecord scheduleRecord = scheduleRecordRepository
                    .GetScheduleRecordByTimeAndDate(start, dayOfWeek[i % 7], page, teacherId);
                    if (scheduleRecord != null)
                    {
                        room = scheduleRecord.Room;
                        className = scheduleRecord.ClassName;
                    }
                    else
                    {
                        room = "";
                        className = "";
                        Slot checkSlot = slotRepository.getSlot(teacherId, date, start);
                        if (checkSlot != null)
                        {
                            isSlot = true;
                            room = checkSlot.Room;
                        }
                    }
                    frmScheduleItem scheduleItem = new frmScheduleItem(
                        className,
                        room,
                        start,
                        start.Add(additionalTimeSpan),
                        date,
                        teacherId,
                        isSlot,
                        this
                        );
                    scheduleItem.TopLevel = false;
                    scheduleItem.FormBorderStyle = FormBorderStyle.None;
                    scheduleItem.Size = new Size(93, 63); // Adjust the size as per your requirements
                    flowPanel_items.Controls.Add(scheduleItem);
                    scheduleItem.BringToFront();
                    scheduleItem.Show();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                int id = 0;
                string startTimeStr;
                string endTimeStr;
                string room;
                string className;
                string dateStr = "";
                string courseName = "";
                scheduleRecordRepository.DeleteScheduleRecordByTeacherId(teacherId);
                DataTable ds = tableCollection["Sheet1"];
                foreach (DataRow row in ds.Rows)
                {
                    count += 1;
                    // Skip the last row if it is the new row    

                    // Retrieve the values from the row
                    if (count == 1)
                    {
                        courseName = row["Course Name"].ToString();
                        startDate = DateTime.Parse(row["Day"].ToString());
                        DateTime now = DateTime.Now;
                        TimeSpan timeDifferent = (now - startDate);
                        page = timeDifferent.Days / 7;
                    }
                    if ((count - 1) % 6 == 0)
                    {
                        dateStr = row["Day"].ToString();
                    }
                    startTimeStr = row["Start"].ToString();
                    endTimeStr = row["End"].ToString();
                    room = row["Room"].ToString();
                    className = row["Class"].ToString();
                    // Parse the date and time values
                    DateTime date = DateTime.Parse(dateStr);
                    TimeSpan startTime = TimeSpan.Parse(startTimeStr);
                    TimeSpan endTime = TimeSpan.Parse(endTimeStr);
                    if (className != "")
                    {
                        // Create the ScheduleRecord object
                        ScheduleRecord sr = new ScheduleRecord(
                            id: id, // Provide the appropriate value for the ID
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
                MessageBox.Show("Saved to database");
                loadSchedule();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void frmTeacherSchedule_Load(object sender, EventArgs e)
        {
            loadSchedule();
            btnSave.Visible = false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page -= 1;
                loadSchedule();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            page += 1;
            loadSchedule();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
