namespace MeetMyLecturerWinApp
{
    partial class frmTeacherSchedule
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
            flowPanel_items = new FlowLayoutPanel();
            panel_header = new Panel();
            lbDateWeek = new Label();
            btnForward = new Button();
            btnBack = new Button();
            btnBrowse = new Button();
            txtFilePath = new TextBox();
            btnSave = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TUESDAY = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel_header.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel_items
            // 
            flowPanel_items.Location = new Point(85, 129);
            flowPanel_items.Name = "flowPanel_items";
            flowPanel_items.Size = new Size(723, 426);
            flowPanel_items.TabIndex = 6;
            // 
            // panel_header
            // 
            panel_header.BackColor = SystemColors.GradientInactiveCaption;
            panel_header.Controls.Add(lbDateWeek);
            panel_header.Controls.Add(btnForward);
            panel_header.Controls.Add(btnBack);
            panel_header.Controls.Add(btnBrowse);
            panel_header.Controls.Add(txtFilePath);
            panel_header.Controls.Add(btnSave);
            panel_header.Dock = DockStyle.Top;
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(849, 86);
            panel_header.TabIndex = 7;
            // 
            // lbDateWeek
            // 
            lbDateWeek.AutoSize = true;
            lbDateWeek.Location = new Point(494, 61);
            lbDateWeek.Name = "lbDateWeek";
            lbDateWeek.Size = new Size(122, 15);
            lbDateWeek.TabIndex = 11;
            lbDateWeek.Text = "1/1/1990 - 31/12/2023";
            // 
            // btnForward
            // 
            btnForward.Location = new Point(682, 53);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(29, 30);
            btnForward.TabIndex = 10;
            btnForward.Text = ">";
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(647, 53);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(29, 30);
            btnBack.TabIndex = 9;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(441, 12);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(32, 23);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(24, 13);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(411, 23);
            txtFilePath.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(24, 42);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TUESDAY);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 43);
            panel1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(702, 16);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(52, 15);
            label7.TabIndex = 6;
            label7.Text = "SUNDAY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(595, 16);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 5;
            label6.Text = "SATURDAY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 16);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "FRIDAY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 16);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "THURSDAY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 16);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "WEDNESDAY";
            // 
            // TUESDAY
            // 
            TUESDAY.AutoSize = true;
            TUESDAY.Location = new Point(206, 16);
            TUESDAY.Name = "TUESDAY";
            TUESDAY.Size = new Size(55, 15);
            TUESDAY.TabIndex = 1;
            TUESDAY.Text = "TUESDAY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 16);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "MONDAY";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(85, 444);
            panel2.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 369);
            label13.Name = "label13";
            label13.Size = new Size(72, 15);
            label13.TabIndex = 12;
            label13.Text = "16:00 - 17:30";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 300);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 11;
            label12.Text = "14:15 - 15:45";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 230);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 10;
            label11.Text = "12:30 - 14:00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 163);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 9;
            label10.Text = "10:30 - 12:00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 95);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(66, 15);
            label9.TabIndex = 8;
            label9.Text = "8:45 - 10:15";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 32);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 7;
            label8.Text = "7:00 - 8:30";
            // 
            // frmTeacherSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 573);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel_header);
            Controls.Add(flowPanel_items);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmTeacherSchedule";
            Text = "frmTeacherSchedule";
            Load += frmTeacherSchedule_Load;
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowPanel_items;
        private Panel panel_header;
        private Button btnBrowse;
        private TextBox txtFilePath;
        private Button btnSave;
        private Button btnBack;
        private Button btnForward;
        private Label lbDateWeek;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label TUESDAY;
        private Label label1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label13;
        private Label MONDAY;
    }
}