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
            SlotId.Location = new Point(41, 40);
            SlotId.Name = "SlotId";
            SlotId.Size = new Size(48, 20);
            SlotId.TabIndex = 0;
            SlotId.Text = "SlotId";
            // 
            // txtSlotId
            // 
            txtSlotId.Location = new Point(105, 37);
            txtSlotId.Name = "txtSlotId";
            txtSlotId.Size = new Size(238, 27);
            txtSlotId.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(72, 110);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(230, 110);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmChooseSlotForMeetingRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 173);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtSlotId);
            Controls.Add(SlotId);
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