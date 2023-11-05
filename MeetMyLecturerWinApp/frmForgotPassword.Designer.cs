namespace MeetMyLecturerWinApp
{
    partial class frmForgotPassword
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
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            GetPassBut = new Button();
            ExitBut = new Button();
            result = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Users1;
            pictureBox1.Location = new Point(97, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(170, 234);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 25);
            txtEmail.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 237);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 4;
            label1.Text = "Registered Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 286);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 6;
            label2.Text = "Result";
            // 
            // GetPassBut
            // 
            GetPassBut.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            GetPassBut.Location = new Point(97, 320);
            GetPassBut.Name = "GetPassBut";
            GetPassBut.Size = new Size(117, 32);
            GetPassBut.TabIndex = 7;
            GetPassBut.Text = "Get Password";
            GetPassBut.UseVisualStyleBackColor = true;
            GetPassBut.Click += GetPassBut_Click;
            // 
            // ExitBut
            // 
            ExitBut.Location = new Point(230, 320);
            ExitBut.Name = "ExitBut";
            ExitBut.Size = new Size(110, 32);
            ExitBut.TabIndex = 8;
            ExitBut.Text = "Exit";
            ExitBut.UseVisualStyleBackColor = true;
            ExitBut.Click += ExitBut_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(170, 286);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 9;
            // 
            // frmForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(444, 375);
            Controls.Add(result);
            Controls.Add(ExitBut);
            Controls.Add(GetPassBut);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmForgotPassword";
            Text = "frmForgotPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Button GetPassBut;
        private Button ExitBut;
        private Label result;
    }
}