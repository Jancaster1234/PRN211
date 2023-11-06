using MeetMyLecturerWinApp.Teacher_form;
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
    public partial class frmScheduleItem : Form
    {
        string className = "";
        string room = "";
        TimeSpan start;
        TimeSpan end;
        DateTime date;
        int teacherId;
        public frmScheduleItem(string className, string room, TimeSpan start, TimeSpan end, DateTime date, int teacherId)
        {
            InitializeComponent();
            this.className = className;
            this.room = room;
            this.start = start;
            this.end = end;
            this.date = date;
            this.teacherId = teacherId;
        }


        private void frmScheduleItem_Load(object sender, EventArgs e)
        {
            lbClass.Text = className;
            lbRoom.Text = room;
            if (className != "")
            {
                this.BackColor = Color.FromArgb(191, 200, 165);
            }

        }

        private void frmScheduleItem_Click(object sender, EventArgs e)
        {
            if (className == "")
            {
                frmSlotDialog slotDialog = new frmSlotDialog(teacherId, date, start, end);
                slotDialog.Show();
            }

        }

        private void frmScheduleItem_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void frmScheduleItem_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
