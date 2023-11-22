namespace MeetMyLecturerWinApp
{
    partial class frmRegister
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            txtPassConfirm = new TextBox();
            label3 = new Label();
            button1 = new Button();
            txtName = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users1;
            pictureBox1.Location = new Point(95, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 234);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(169, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 25);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(169, 274);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(229, 25);
            txtPass.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 277);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtPassConfirm
            // 
            txtPassConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassConfirm.Location = new Point(169, 318);
            txtPassConfirm.Name = "txtPassConfirm";
            txtPassConfirm.PasswordChar = '*';
            txtPassConfirm.Size = new Size(229, 25);
            txtPassConfirm.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 321);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(169, 424);
            button1.Name = "button1";
            button1.Size = new Size(87, 28);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(169, 361);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 25);
            txtName.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 364);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 9;
            label4.Text = "Name";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(444, 464);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtPassConfirm);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            Name = "frmRegister";
            Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtPassConfirm;
        private Label label3;
        private Button button1;
        private TextBox txtName;
        private Label label4;
    }
}