namespace MeetMyLecturerWinApp.Teacher_form
{
    partial class frmSlotDialog
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
            label1 = new Label();
            txtDate = new TextBox();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboSubject = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtMessage = new TextBox();
            btnGenerate = new Button();
            txtPasscode = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtStudentLimit = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            linkHide = new LinkLabel();
            label9 = new Label();
            gbStatus = new GroupBox();
            rbInactive = new RadioButton();
            rdActive = new RadioButton();
            gbStatus.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "FREE SLOT";
            // 
            // txtDate
            // 
            txtDate.Enabled = false;
            txtDate.Location = new Point(81, 41);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(100, 23);
            txtDate.TabIndex = 1;
            // 
            // txtStart
            // 
            txtStart.Enabled = false;
            txtStart.Location = new Point(231, 41);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(100, 23);
            txtStart.TabIndex = 2;
            // 
            // txtEnd
            // 
            txtEnd.Enabled = false;
            txtEnd.Location = new Point(393, 41);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(100, 23);
            txtEnd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 44);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 44);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "End";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 44);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Date";
            // 
            // cboSubject
            // 
            cboSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubject.FormattingEnabled = true;
            cboSubject.Location = new Point(81, 86);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(205, 23);
            cboSubject.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 89);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Subject";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 130);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 9;
            label6.Text = "Message";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(81, 130);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(412, 68);
            txtMessage.TabIndex = 10;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(337, 217);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(156, 23);
            btnGenerate.TabIndex = 12;
            btnGenerate.Text = "Generate Passcode";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtPasscode
            // 
            txtPasscode.Location = new Point(81, 218);
            txtPasscode.Name = "txtPasscode";
            txtPasscode.ReadOnly = true;
            txtPasscode.Size = new Size(250, 23);
            txtPasscode.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 221);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 14;
            label7.Text = "Passcode";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(309, 89);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 15;
            label8.Text = "Student Limit";
            // 
            // txtStudentLimit
            // 
            txtStudentLimit.Location = new Point(393, 86);
            txtStudentLimit.Name = "txtStudentLimit";
            txtStudentLimit.Size = new Size(100, 23);
            txtStudentLimit.TabIndex = 16;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(328, 304);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "OK";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(418, 304);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // linkHide
            // 
            linkHide.AutoSize = true;
            linkHide.Location = new Point(81, 244);
            linkHide.Name = "linkHide";
            linkHide.Size = new Size(32, 15);
            linkHide.TabIndex = 19;
            linkHide.TabStop = true;
            linkHide.Text = "Hide";
            linkHide.LinkClicked += linkHide_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 287);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 20;
            label9.Text = "Status";
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(rbInactive);
            gbStatus.Controls.Add(rdActive);
            gbStatus.Location = new Point(81, 266);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(219, 49);
            gbStatus.TabIndex = 21;
            gbStatus.TabStop = false;
            gbStatus.Enter += gbStatus_Enter;
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Location = new Point(131, 19);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(66, 19);
            rbInactive.TabIndex = 1;
            rbInactive.TabStop = true;
            rbInactive.Text = "Inactive";
            rbInactive.UseVisualStyleBackColor = true;
            // 
            // rdActive
            // 
            rdActive.AutoSize = true;
            rdActive.Location = new Point(6, 19);
            rdActive.Name = "rdActive";
            rdActive.Size = new Size(58, 19);
            rdActive.TabIndex = 0;
            rdActive.TabStop = true;
            rdActive.Text = "Active";
            rdActive.UseVisualStyleBackColor = true;
            // 
            // frmSlotDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 339);
            Controls.Add(gbStatus);
            Controls.Add(label9);
            Controls.Add(linkHide);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtStudentLimit);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPasscode);
            Controls.Add(btnGenerate);
            Controls.Add(txtMessage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cboSubject);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(txtDate);
            Controls.Add(label1);
            Name = "frmSlotDialog";
            Text = "frmSlotDialog";
            Load += frmSlotDialog_Load;
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDate;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboSubject;
        private Label label5;
        private Label label6;
        private TextBox txtMessage;
        private Button btnGenerate;
        private TextBox txtPasscode;
        private Label label7;
        private Label label8;
        private TextBox txtStudentLimit;
        private Button btnSubmit;
        private Button btnCancel;
        private LinkLabel linkHide;
        private Label label9;
        private GroupBox gbStatus;
        private RadioButton rbInactive;
        private RadioButton rdActive;
    }
}