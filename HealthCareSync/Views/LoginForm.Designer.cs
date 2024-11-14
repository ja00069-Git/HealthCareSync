namespace HealthCareSync
{
    partial class LoginForm
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            loginBTN = new Button();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            sigupLabel = new Label();
            exitAppBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_icon;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.red_user_icon;
            pictureBox2.Location = new Point(507, 76);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.ForeColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(507, 112);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 2);
            panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.security_icon;
            pictureBox3.Location = new Point(507, 148);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(102, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.ForeColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(507, 184);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 2);
            panel2.TabIndex = 5;
            // 
            // loginBTN
            // 
            loginBTN.BackColor = Color.IndianRed;
            loginBTN.FlatAppearance.BorderSize = 0;
            loginBTN.FlatStyle = FlatStyle.Flat;
            loginBTN.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBTN.ForeColor = Color.White;
            loginBTN.Location = new Point(569, 196);
            loginBTN.Margin = new Padding(2);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(178, 34);
            loginBTN.TabIndex = 3;
            loginBTN.Text = "Log In";
            loginBTN.UseVisualStyleBackColor = false;
            loginBTN.Click += loginBTN_Click;
            // 
            // usernameTB
            // 
            usernameTB.BackColor = Color.White;
            usernameTB.BorderStyle = BorderStyle.None;
            usernameTB.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTB.ForeColor = SystemColors.HotTrack;
            usernameTB.Location = new Point(620, 76);
            usernameTB.Margin = new Padding(2);
            usernameTB.Multiline = true;
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(205, 32);
            usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.White;
            passwordTB.BorderStyle = BorderStyle.None;
            passwordTB.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTB.ForeColor = SystemColors.HotTrack;
            passwordTB.Location = new Point(625, 148);
            passwordTB.Margin = new Padding(2);
            passwordTB.Multiline = true;
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.Size = new Size(200, 32);
            passwordTB.TabIndex = 2;
            // 
            // sigupLabel
            // 
            sigupLabel.AutoSize = true;
            sigupLabel.Font = new Font("MS UI Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            sigupLabel.ForeColor = SystemColors.HotTrack;
            sigupLabel.Location = new Point(522, 251);
            sigupLabel.Margin = new Padding(2, 0, 2, 0);
            sigupLabel.Name = "sigupLabel";
            sigupLabel.Size = new Size(194, 16);
            sigupLabel.TabIndex = 4;
            sigupLabel.Text = "You don't have an account?";
            sigupLabel.Click += label1_Click;
            // 
            // exitAppBTN
            // 
            exitAppBTN.BackgroundImage = Properties.Resources.close_form_icon;
            exitAppBTN.BackgroundImageLayout = ImageLayout.Zoom;
            exitAppBTN.FlatAppearance.BorderSize = 0;
            exitAppBTN.FlatStyle = FlatStyle.Flat;
            exitAppBTN.Location = new Point(869, 7);
            exitAppBTN.Margin = new Padding(2);
            exitAppBTN.Name = "exitAppBTN";
            exitAppBTN.Size = new Size(38, 32);
            exitAppBTN.TabIndex = 6;
            exitAppBTN.UseVisualStyleBackColor = true;
            exitAppBTN.Click += exitAppBTN_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(916, 369);
            Controls.Add(exitAppBTN);
            Controls.Add(sigupLabel);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(loginBTN);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button loginBTN;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Label sigupLabel;
        private Button exitAppBTN;
    }
}