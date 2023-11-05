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
            btnForward = new Button();
            btnBack = new Button();
            btnBrowse = new Button();
            txtFilePath = new TextBox();
            btnSave = new Button();
            panel_header.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel_items
            // 
            flowPanel_items.Location = new Point(0, 89);
            flowPanel_items.Name = "flowPanel_items";
            flowPanel_items.Size = new Size(723, 426);
            flowPanel_items.TabIndex = 6;
            flowPanel_items.Paint += flowPanel_items_Paint;
            // 
            // panel_header
            // 
            panel_header.Controls.Add(btnForward);
            panel_header.Controls.Add(btnBack);
            panel_header.Controls.Add(btnBrowse);
            panel_header.Controls.Add(txtFilePath);
            panel_header.Controls.Add(btnSave);
            panel_header.Dock = DockStyle.Top;
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(723, 86);
            panel_header.TabIndex = 7;
            panel_header.Paint += panel_header_Paint;
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
            // frmTeacherSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 545);
            Controls.Add(panel_header);
            Controls.Add(flowPanel_items);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmTeacherSchedule";
            Text = "frmTeacherSchedule";
            Load += frmTeacherSchedule_Load;
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
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
    }
}