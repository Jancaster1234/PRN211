namespace MeetMyLecturerWinApp.Teacher_form
{
    partial class frmMainTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            selectFormToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            searchSlotToolStripMenuItem = new ToolStripMenuItem();
            passcodeRequestToolStripMenuItem = new ToolStripMenuItem();
            meetingRequestToolStripMenuItem = new ToolStripMenuItem();
            actionRecordToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { selectFormToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // selectFormToolStripMenuItem
            // 
            selectFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, searchSlotToolStripMenuItem, passcodeRequestToolStripMenuItem, meetingRequestToolStripMenuItem, actionRecordToolStripMenuItem });
            selectFormToolStripMenuItem.Name = "selectFormToolStripMenuItem";
            selectFormToolStripMenuItem.Size = new Size(97, 24);
            selectFormToolStripMenuItem.Text = "select form";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(207, 26);
            profileToolStripMenuItem.Text = "profile";
            profileToolStripMenuItem.Click += profileFormToolStripMenuItem_Click;
            // 
            // searchSlotToolStripMenuItem
            // 
            searchSlotToolStripMenuItem.Name = "searchSlotToolStripMenuItem";
            searchSlotToolStripMenuItem.Size = new Size(207, 26);
            searchSlotToolStripMenuItem.Text = "manage slot";
            searchSlotToolStripMenuItem.Click += slotFormToolStripMenuItem_Click;
            // 
            // passcodeRequestToolStripMenuItem
            // 
            passcodeRequestToolStripMenuItem.Name = "passcodeRequestToolStripMenuItem";
            passcodeRequestToolStripMenuItem.Size = new Size(207, 26);
            passcodeRequestToolStripMenuItem.Text = "passcode request";
            passcodeRequestToolStripMenuItem.Click += passcodeRequestFormToolStripMenuItem_Click;
            // 
            // meetingRequestToolStripMenuItem
            // 
            meetingRequestToolStripMenuItem.Name = "meetingRequestToolStripMenuItem";
            meetingRequestToolStripMenuItem.Size = new Size(207, 26);
            meetingRequestToolStripMenuItem.Text = "meeting request";
            meetingRequestToolStripMenuItem.Click += meetingRequestFormToolStripMenuItem_Click;
            // 
            // actionRecordToolStripMenuItem
            // 
            actionRecordToolStripMenuItem.Name = "actionRecordToolStripMenuItem";
            actionRecordToolStripMenuItem.Size = new Size(207, 26);
            actionRecordToolStripMenuItem.Text = "action record";
            actionRecordToolStripMenuItem.Click += actionRecordFormToolStripMenuItem_Click;
            // 
            // frmMainTeacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "frmMainTeacher";
            Text = "frmMainTeacher";
            Load += frmMainTeacher_Load;
            Click += frmMainTeacher_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem selectFormToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem searchSlotToolStripMenuItem;
        private ToolStripMenuItem passcodeRequestToolStripMenuItem;
        private ToolStripMenuItem meetingRequestToolStripMenuItem;
        private ToolStripMenuItem actionRecordToolStripMenuItem;
    }
}