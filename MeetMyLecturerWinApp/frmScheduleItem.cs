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
        public frmScheduleItem(string className, string room)
        {
            InitializeComponent();
            this.className = className;
            this.room = room;
        }


        private void frmScheduleItem_Load(object sender, EventArgs e)
        {
            lbClass.Text = className;
            lbRoom.Text = room;
        }
    }
}
