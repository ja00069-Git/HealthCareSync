namespace HealthCareSync.Views
{
    partial class LoginTypePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTypePage));
            saveFileDialog1 = new SaveFileDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            logInTypePageUserLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 98);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(314, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 98);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("ModeNine", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(82, 155);
            button1.Name = "button1";
            button1.Size = new Size(154, 34);
            button1.TabIndex = 2;
            button1.Text = "As a Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("ModeNine", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(314, 155);
            button2.Name = "button2";
            button2.Size = new Size(154, 34);
            button2.TabIndex = 3;
            button2.Text = "As a Nurse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // logInTypePageUserLabel
            // 
            logInTypePageUserLabel.AutoSize = true;
            logInTypePageUserLabel.Location = new Point(32, 15);
            logInTypePageUserLabel.Name = "logInTypePageUserLabel";
            logInTypePageUserLabel.Size = new Size(0, 15);
            logInTypePageUserLabel.TabIndex = 4;
            // 
            // LoginTypePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(logInTypePageUserLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "LoginTypePage";
            Size = new Size(551, 264);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Label logInTypePageUserLabel;
    }
}
