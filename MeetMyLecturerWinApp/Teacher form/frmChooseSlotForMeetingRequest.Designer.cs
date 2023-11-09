namespace MeetMyLecturerWinApp.Teacher_form
{
    partial class frmChooseSlotForMeetingRequest
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
            SlotId = new Label();
            txtSlotId = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // SlotId
            // 
            SlotId.AutoSize = true;
            SlotId.ForeColor = SystemColors.ButtonHighlight;
            SlotId.Location = new Point(36, 30);
            SlotId.Name = "SlotId";
            SlotId.Size = new Size(37, 15);
            SlotId.TabIndex = 0;
            SlotId.Text = "SlotId";
            // 
            // txtSlotId
            // 
            txtSlotId.Location = new Point(92, 28);
            txtSlotId.Margin = new Padding(3, 2, 3, 2);
            txtSlotId.Name = "txtSlotId";
            txtSlotId.Size = new Size(209, 23);
            txtSlotId.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(63, 82);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 22);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(201, 82);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmChooseSlotForMeetingRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(352, 130);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtSlotId);
            Controls.Add(SlotId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmChooseSlotForMeetingRequest";
            Text = "frmChooseSlotForMeetingRequest";
            Load += frmChooseSlotForMeetingRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SlotId;
        private TextBox txtSlotId;
        private Button btnOK;
        private Button btnCancel;
    }
}