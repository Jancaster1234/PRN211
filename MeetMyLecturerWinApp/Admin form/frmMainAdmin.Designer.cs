namespace MeetMyLecturerWinApp.Admin_form
{
    partial class frmMainAdmin
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
            searchToolStripMenuItem = new ToolStripMenuItem();
            manageTeacherToolStripMenuItem = new ToolStripMenuItem();
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
            selectFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, searchToolStripMenuItem, manageTeacherToolStripMenuItem, actionRecordToolStripMenuItem });
            selectFormToolStripMenuItem.Name = "selectFormToolStripMenuItem";
            selectFormToolStripMenuItem.Size = new Size(97, 24);
            selectFormToolStripMenuItem.Text = "select form";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(224, 26);
            profileToolStripMenuItem.Text = "profile";
            profileToolStripMenuItem.Click += adminProfileToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(224, 26);
            searchToolStripMenuItem.Text = "manage student";
            searchToolStripMenuItem.Click += manageStudentToolStripMenuItem_Click;
            // 
            // manageTeacherToolStripMenuItem
            // 
            manageTeacherToolStripMenuItem.Name = "manageTeacherToolStripMenuItem";
            manageTeacherToolStripMenuItem.Size = new Size(224, 26);
            manageTeacherToolStripMenuItem.Text = "manage teacher";
            manageTeacherToolStripMenuItem.Click += manageTeacherToolStripMenuItem_Click;
            // 
            // actionRecordToolStripMenuItem
            // 
            actionRecordToolStripMenuItem.Name = "actionRecordToolStripMenuItem";
            actionRecordToolStripMenuItem.Size = new Size(224, 26);
            actionRecordToolStripMenuItem.Text = "action record";
            actionRecordToolStripMenuItem.Click += adminActionRecordToolStripMenuItem_Click;
            // 
            // frmMainAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "frmMainAdmin";
            Text = "frmMainAdmin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem selectFormToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem manageTeacherToolStripMenuItem;
        private ToolStripMenuItem actionRecordToolStripMenuItem;
    }
}