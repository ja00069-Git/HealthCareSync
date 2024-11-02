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
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 613);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.red_user_icon;
            pictureBox2.Location = new Point(724, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.ForeColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(724, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 3);
            panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.security_icon;
            pictureBox3.Location = new Point(724, 247);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(146, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.ForeColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(724, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 3);
            panel2.TabIndex = 5;
            // 
            // loginBTN
            // 
            loginBTN.BackColor = Color.IndianRed;
            loginBTN.FlatAppearance.BorderSize = 0;
            loginBTN.FlatStyle = FlatStyle.Flat;
            loginBTN.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBTN.ForeColor = Color.White;
            loginBTN.Location = new Point(813, 326);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(255, 56);
            loginBTN.TabIndex = 3;
            loginBTN.Text = "Log In";
            loginBTN.UseVisualStyleBackColor = false;
            loginBTN.Click += loginBTN_Click;
            // 
            // usernameTB
            // 
            usernameTB.BackColor = Color.White;
            usernameTB.BorderStyle = BorderStyle.None;
            usernameTB.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTB.ForeColor = SystemColors.HotTrack;
            usernameTB.Location = new Point(885, 127);
            usernameTB.Multiline = true;
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(293, 53);
            usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.White;
            passwordTB.BorderStyle = BorderStyle.None;
            passwordTB.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTB.ForeColor = SystemColors.HotTrack;
            passwordTB.Location = new Point(893, 247);
            passwordTB.Multiline = true;
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.Size = new Size(285, 53);
            passwordTB.TabIndex = 2;
            // 
            // sigupLabel
            // 
            sigupLabel.AutoSize = true;
            sigupLabel.Font = new Font("MS UI Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            sigupLabel.ForeColor = SystemColors.HotTrack;
            sigupLabel.Location = new Point(746, 418);
            sigupLabel.Name = "sigupLabel";
            sigupLabel.Size = new Size(284, 24);
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
            exitAppBTN.Location = new Point(1242, 12);
            exitAppBTN.Name = "exitAppBTN";
            exitAppBTN.Size = new Size(54, 54);
            exitAppBTN.TabIndex = 6;
            exitAppBTN.UseVisualStyleBackColor = true;
            exitAppBTN.Click += exitAppBTN_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1308, 615);
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