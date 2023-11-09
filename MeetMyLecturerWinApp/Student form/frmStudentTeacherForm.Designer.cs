namespace MeetMyLecturerWinApp
{
    partial class frmStudentTeacherForm
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
            btnClearText = new Button();
            btnOK = new Button();
            dgvTeachers = new DataGridView();
            Name = new Label();
            Email = new Label();
            Major = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtMajor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(158, 149);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 0;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(494, 149);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 22;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // dgvTeachers
            // 
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Location = new Point(32, 197);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.RowTemplate.Height = 29;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(723, 241);
            dgvTeachers.TabIndex = 23;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(25, 24);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 24;
            Name.Text = "Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(25, 68);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 25;
            Email.Text = "Email";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.Location = new Point(392, 24);
            Major.Name = "Major";
            Major.Size = new Size(48, 20);
            Major.TabIndex = 26;
            Major.Text = "Major";
            // 
            // txtName
            // 
            txtName.Location = new Point(106, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 27);
            txtName.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(106, 68);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 27;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(460, 24);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(203, 27);
            txtMajor.TabIndex = 27;
            // 
            // frmStudentTeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMajor);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(Major);
            Controls.Add(Email);
            Controls.Add(Name);
            Controls.Add(dgvTeachers);
            Controls.Add(btnOK);
            Controls.Add(btnClearText);
            Text = "frmStudentTeacherForm";
            Load += frmStudentTeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClearText;
        public Button btnOK;
        private DataGridView dgvTeachers;
        private Label Name;
        private Label Email;
        private Label Major;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtMajor;
    }
}