namespace MeetMyLecturerWinApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panel1 = new Panel();
            btnActionRecord = new Button();
            btnTeachers = new Button();
            btnStudents = new Button();
            btnSchedule = new Button();
            btnManageSlot = new Button();
            btnMeeting = new Button();
            btnPasscode = new Button();
            btnSearchSlot = new Button();
            btnSearchTeacher = new Button();
            btnProfile = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLogout = new Button();
            lbNavigation = new Label();
            panel_body = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(btnActionRecord);
            panel1.Controls.Add(btnTeachers);
            panel1.Controls.Add(btnStudents);
            panel1.Controls.Add(btnSchedule);
            panel1.Controls.Add(btnManageSlot);
            panel1.Controls.Add(btnMeeting);
            panel1.Controls.Add(btnPasscode);
            panel1.Controls.Add(btnSearchSlot);
            panel1.Controls.Add(btnSearchTeacher);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 620);
            panel1.TabIndex = 0;
            // 
            // btnActionRecord
            // 
            btnActionRecord.BackColor = Color.MediumSlateBlue;
            btnActionRecord.Dock = DockStyle.Top;
            btnActionRecord.FlatAppearance.BorderSize = 0;
            btnActionRecord.FlatStyle = FlatStyle.Flat;
            btnActionRecord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActionRecord.ForeColor = SystemColors.ControlLightLight;
            btnActionRecord.Location = new Point(0, 418);
            btnActionRecord.Name = "btnActionRecord";
            btnActionRecord.Size = new Size(145, 39);
            btnActionRecord.TabIndex = 11;
            btnActionRecord.Text = "Action Record";
            btnActionRecord.UseVisualStyleBackColor = false;
            btnActionRecord.Click += btnActionRecord_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.BackColor = Color.MediumSlateBlue;
            btnTeachers.Dock = DockStyle.Top;
            btnTeachers.FlatAppearance.BorderSize = 0;
            btnTeachers.FlatStyle = FlatStyle.Flat;
            btnTeachers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeachers.ForeColor = SystemColors.ControlLightLight;
            btnTeachers.Location = new Point(0, 379);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(145, 39);
            btnTeachers.TabIndex = 10;
            btnTeachers.Text = "Manage Teachers";
            btnTeachers.UseVisualStyleBackColor = false;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.MediumSlateBlue;
            btnStudents.Dock = DockStyle.Top;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudents.ForeColor = SystemColors.ControlLightLight;
            btnStudents.Location = new Point(0, 340);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(145, 39);
            btnStudents.TabIndex = 9;
            btnStudents.Text = "Manage Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.MediumSlateBlue;
            btnSchedule.Dock = DockStyle.Top;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchedule.ForeColor = SystemColors.ControlLightLight;
            btnSchedule.Location = new Point(0, 301);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(145, 39);
            btnSchedule.TabIndex = 8;
            btnSchedule.Text = "Schedule";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnManageSlot
            // 
            btnManageSlot.BackColor = Color.MediumSlateBlue;
            btnManageSlot.Dock = DockStyle.Top;
            btnManageSlot.FlatAppearance.BorderSize = 0;
            btnManageSlot.FlatStyle = FlatStyle.Flat;
            btnManageSlot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnManageSlot.ForeColor = SystemColors.ControlLightLight;
            btnManageSlot.Location = new Point(0, 262);
            btnManageSlot.Name = "btnManageSlot";
            btnManageSlot.Size = new Size(145, 39);
            btnManageSlot.TabIndex = 7;
            btnManageSlot.Text = "Manage Slots";
            btnManageSlot.UseVisualStyleBackColor = false;
            btnManageSlot.Click += btnManageSlot_Click;
            // 
            // btnMeeting
            // 
            btnMeeting.BackColor = Color.MediumSlateBlue;
            btnMeeting.Dock = DockStyle.Top;
            btnMeeting.FlatAppearance.BorderSize = 0;
            btnMeeting.FlatStyle = FlatStyle.Flat;
            btnMeeting.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMeeting.ForeColor = SystemColors.ButtonHighlight;
            btnMeeting.Location = new Point(0, 223);
            btnMeeting.Name = "btnMeeting";
            btnMeeting.Size = new Size(145, 39);
            btnMeeting.TabIndex = 5;
            btnMeeting.Text = "Meeting request";
            btnMeeting.UseVisualStyleBackColor = false;
            btnMeeting.Click += btnMeeting_Click;
            // 
            // btnPasscode
            // 
            btnPasscode.BackColor = Color.MediumSlateBlue;
            btnPasscode.Dock = DockStyle.Top;
            btnPasscode.FlatAppearance.BorderSize = 0;
            btnPasscode.FlatStyle = FlatStyle.Flat;
            btnPasscode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPasscode.ForeColor = SystemColors.ButtonHighlight;
            btnPasscode.Location = new Point(0, 184);
            btnPasscode.Name = "btnPasscode";
            btnPasscode.Size = new Size(145, 39);
            btnPasscode.TabIndex = 4;
            btnPasscode.Text = "Passcode request";
            btnPasscode.UseVisualStyleBackColor = false;
            btnPasscode.Click += button3_Click;
            // 
            // btnSearchSlot
            // 
            btnSearchSlot.BackColor = Color.MediumSlateBlue;
            btnSearchSlot.Dock = DockStyle.Top;
            btnSearchSlot.FlatAppearance.BorderSize = 0;
            btnSearchSlot.FlatStyle = FlatStyle.Flat;
            btnSearchSlot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchSlot.ForeColor = SystemColors.ButtonHighlight;
            btnSearchSlot.Location = new Point(0, 145);
            btnSearchSlot.Name = "btnSearchSlot";
            btnSearchSlot.Size = new Size(145, 39);
            btnSearchSlot.TabIndex = 3;
            btnSearchSlot.Text = "Search Slot";
            btnSearchSlot.UseVisualStyleBackColor = false;
            btnSearchSlot.Click += btnSearchSlot_Click;
            // 
            // btnSearchTeacher
            // 
            btnSearchTeacher.BackColor = Color.MediumSlateBlue;
            btnSearchTeacher.Dock = DockStyle.Top;
            btnSearchTeacher.FlatAppearance.BorderSize = 0;
            btnSearchTeacher.FlatStyle = FlatStyle.Flat;
            btnSearchTeacher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchTeacher.ForeColor = SystemColors.ControlLightLight;
            btnSearchTeacher.Location = new Point(0, 106);
            btnSearchTeacher.Name = "btnSearchTeacher";
            btnSearchTeacher.Size = new Size(145, 39);
            btnSearchTeacher.TabIndex = 2;
            btnSearchTeacher.Text = "Search Teacher";
            btnSearchTeacher.UseVisualStyleBackColor = false;
            btnSearchTeacher.Click += btnSearchTeacher_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.MediumSlateBlue;
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = SystemColors.ControlLightLight;
            btnProfile.Location = new Point(0, 67);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(145, 39);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(lbNavigation);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(145, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 67);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(721, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 36);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbNavigation
            // 
            lbNavigation.AutoSize = true;
            lbNavigation.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNavigation.ForeColor = SystemColors.ButtonHighlight;
            lbNavigation.Location = new Point(22, 9);
            lbNavigation.Name = "lbNavigation";
            lbNavigation.Size = new Size(262, 40);
            lbNavigation.TabIndex = 0;
            lbNavigation.Text = "Meet My Lecturer";
            // 
            // panel_body
            // 
            panel_body.BackColor = Color.DarkSlateBlue;
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(145, 67);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(838, 553);
            panel_body.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(983, 620);
            Controls.Add(panel_body);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "frmMain";
            Text = "Meet My Lecturer";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel_body;
        private PictureBox pictureBox1;
        private Label lbNavigation;
        private Button btnProfile;
        private Button btnMeeting;
        private Button btnPasscode;
        private Button btnSearchSlot;
        private Button btnSearchTeacher;
        private Button btnLogout;
        private Button btnSchedule;
        private Button btnManageSlot;
        private Button btnActionRecord;
        private Button btnTeachers;
        private Button btnStudents;
    }
}