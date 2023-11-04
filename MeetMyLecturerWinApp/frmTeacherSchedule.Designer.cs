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
            dataGridView1 = new DataGridView();
            btnImport = new Button();
            btnSave = new Button();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(452, 304);
            dataGridView1.TabIndex = 0;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(28, 12);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 1;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(28, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(109, 13);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(306, 23);
            txtFilePath.TabIndex = 4;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(432, 13);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(32, 23);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // frmTeacherSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 435);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(btnSave);
            Controls.Add(btnImport);
            Controls.Add(dataGridView1);
            Name = "frmTeacherSchedule";
            Text = "frmTeacherSchedule";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnImport;
        private Button btnSave;
        private TextBox txtFilePath;
        private Button btnBrowse;
    }
}