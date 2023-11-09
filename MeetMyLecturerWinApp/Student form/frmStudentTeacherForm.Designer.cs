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
            btnClearText.Location = new Point(138, 112);
            btnClearText.Margin = new Padding(3, 2, 3, 2);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(82, 22);
            btnClearText.TabIndex = 0;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(432, 112);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 22);
            btnOK.TabIndex = 22;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // dgvTeachers
            // 
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Location = new Point(28, 148);
            dgvTeachers.Margin = new Padding(3, 2, 3, 2);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.RowTemplate.Height = 29;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(633, 181);
            dgvTeachers.TabIndex = 23;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.ForeColor = SystemColors.ControlLightLight;
            Name.Location = new Point(22, 18);
            Name.Name = "Name";
            Name.Size = new Size(39, 15);
            Name.TabIndex = 24;
            Name.Text = "Name";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.ForeColor = SystemColors.ControlLightLight;
            Email.Location = new Point(22, 51);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 25;
            Email.Text = "Email";
            // 
            // Major
            // 
            Major.AutoSize = true;
            Major.ForeColor = SystemColors.ControlLightLight;
            Major.Location = new Point(343, 18);
            Major.Name = "Major";
            Major.Size = new Size(38, 15);
            Major.TabIndex = 26;
            Major.Text = "Major";
            // 
            // txtName
            // 
            txtName.Location = new Point(93, 19);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 23);
            txtName.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 51);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 27;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(402, 18);
            txtMajor.Margin = new Padding(3, 2, 3, 2);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(178, 23);
            txtMajor.TabIndex = 27;
            // 
            // frmStudentTeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(txtMajor);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(Major);
            Controls.Add(Email);
            Controls.Add(Name);
            Controls.Add(dgvTeachers);
            Controls.Add(btnOK);
            Controls.Add(btnClearText);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmStudentTeacherForm";
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