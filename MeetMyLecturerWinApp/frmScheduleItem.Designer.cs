namespace MeetMyLecturerWinApp
{
    partial class frmScheduleItem
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
            lbClass = new Label();
            lbRoom = new Label();
            SuspendLayout();
            // 
            // lbClass
            // 
            lbClass.AutoSize = true;
            lbClass.Location = new Point(12, 9);
            lbClass.Name = "lbClass";
            lbClass.Size = new Size(66, 15);
            lbClass.TabIndex = 0;
            lbClass.Text = "ClassName";
            // 
            // lbRoom
            // 
            lbRoom.AutoSize = true;
            lbRoom.Location = new Point(12, 39);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new Size(39, 15);
            lbRoom.TabIndex = 1;
            lbRoom.Text = "Room";
            // 
            // frmScheduleItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(93, 63);
            Controls.Add(lbRoom);
            Controls.Add(lbClass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmScheduleItem";
            RightToLeft = RightToLeft.Yes;
            Text = "frmScheduleItem";
            Load += frmScheduleItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbClass;
        private Label lbRoom;
    }
}