namespace HealthCareSync.Views
{
    partial class AdminHomePage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomePage));
            logedInUserTextBox = new TextBox();
            adminLogoutBTN = new Button();
            adminUserPictureBox = new PictureBox();
            logoutPanel = new Panel();
            adminMenuLabel = new Label();
            adminMenuPanel = new Panel();
            menuBTN = new PictureBox();
            sidebar = new FlowLayoutPanel();
            manageNursePanel = new Panel();
            manageNurseButton = new Button();
            manageDoctorPanel = new Panel();
            manageDoctorBTN = new Button();
            generateReportPnl = new Panel();
            generateReportBTN = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            adminMainPanel = new Panel();
            exitAppBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)adminUserPictureBox).BeginInit();
            logoutPanel.SuspendLayout();
            adminMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuBTN).BeginInit();
            sidebar.SuspendLayout();
            manageNursePanel.SuspendLayout();
            manageDoctorPanel.SuspendLayout();
            generateReportPnl.SuspendLayout();
            SuspendLayout();
            // 
            // logedInUserTextBox
            // 
            logedInUserTextBox.BackColor = Color.White;
            logedInUserTextBox.BorderStyle = BorderStyle.None;
            logedInUserTextBox.Location = new Point(2, 58);
            logedInUserTextBox.Margin = new Padding(2);
            logedInUserTextBox.Multiline = true;
            logedInUserTextBox.Name = "logedInUserTextBox";
            logedInUserTextBox.ReadOnly = true;
            logedInUserTextBox.Size = new Size(134, 26);
            logedInUserTextBox.TabIndex = 3;
            // 
            // adminLogoutBTN
            // 
            adminLogoutBTN.BackColor = Color.IndianRed;
            adminLogoutBTN.FlatAppearance.BorderSize = 0;
            adminLogoutBTN.FlatStyle = FlatStyle.Flat;
            adminLogoutBTN.ForeColor = Color.White;
            adminLogoutBTN.Location = new Point(59, 21);
            adminLogoutBTN.Margin = new Padding(2);
            adminLogoutBTN.Name = "adminLogoutBTN";
            adminLogoutBTN.Size = new Size(74, 29);
            adminLogoutBTN.TabIndex = 2;
            adminLogoutBTN.Text = "Log Out";
            adminLogoutBTN.UseVisualStyleBackColor = false;
            adminLogoutBTN.Click += adminLogoutBTN_Click;
            // 
            // adminUserPictureBox
            // 
            adminUserPictureBox.Image = Properties.Resources.blue_user_icon;
            adminUserPictureBox.Location = new Point(2, 12);
            adminUserPictureBox.Margin = new Padding(2);
            adminUserPictureBox.Name = "adminUserPictureBox";
            adminUserPictureBox.Size = new Size(52, 43);
            adminUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            adminUserPictureBox.TabIndex = 0;
            adminUserPictureBox.TabStop = false;
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(adminUserPictureBox);
            logoutPanel.Controls.Add(adminLogoutBTN);
            logoutPanel.Controls.Add(logedInUserTextBox);
            logoutPanel.Location = new Point(2, 222);
            logoutPanel.Margin = new Padding(2);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(142, 86);
            logoutPanel.TabIndex = 5;
            // 
            // adminMenuLabel
            // 
            adminMenuLabel.AutoSize = true;
            adminMenuLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminMenuLabel.Location = new Point(46, 16);
            adminMenuLabel.Margin = new Padding(2, 0, 2, 0);
            adminMenuLabel.Name = "adminMenuLabel";
            adminMenuLabel.Size = new Size(64, 25);
            adminMenuLabel.TabIndex = 1;
            adminMenuLabel.Text = "Menu";
            // 
            // adminMenuPanel
            // 
            adminMenuPanel.Controls.Add(menuBTN);
            adminMenuPanel.Controls.Add(adminMenuLabel);
            adminMenuPanel.Location = new Point(2, 2);
            adminMenuPanel.Margin = new Padding(2);
            adminMenuPanel.Name = "adminMenuPanel";
            adminMenuPanel.Size = new Size(145, 51);
            adminMenuPanel.TabIndex = 0;
            // 
            // menuBTN
            // 
            menuBTN.Cursor = Cursors.Hand;
            menuBTN.Image = (Image)resources.GetObject("menuBTN.Image");
            menuBTN.Location = new Point(3, 13);
            menuBTN.Margin = new Padding(3, 2, 3, 2);
            menuBTN.Name = "menuBTN";
            menuBTN.Size = new Size(38, 29);
            menuBTN.SizeMode = PictureBoxSizeMode.Zoom;
            menuBTN.TabIndex = 2;
            menuBTN.TabStop = false;
            menuBTN.Click += menuBTN_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(adminMenuPanel);
            sidebar.Controls.Add(manageNursePanel);
            sidebar.Controls.Add(manageDoctorPanel);
            sidebar.Controls.Add(generateReportPnl);
            sidebar.Controls.Add(logoutPanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(2);
            sidebar.MaximumSize = new Size(147, 369);
            sidebar.MinimumSize = new Size(49, 270);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(147, 369);
            sidebar.TabIndex = 4;
            // 
            // manageNursePanel
            // 
            manageNursePanel.Controls.Add(manageNurseButton);
            manageNursePanel.Location = new Point(2, 57);
            manageNursePanel.Margin = new Padding(2);
            manageNursePanel.MaximumSize = new Size(145, 91);
            manageNursePanel.MinimumSize = new Size(145, 35);
            manageNursePanel.Name = "manageNursePanel";
            manageNursePanel.Size = new Size(145, 51);
            manageNursePanel.TabIndex = 4;
            // 
            // manageNurseButton
            // 
            manageNurseButton.BackgroundImageLayout = ImageLayout.Zoom;
            manageNurseButton.FlatAppearance.BorderSize = 0;
            manageNurseButton.FlatStyle = FlatStyle.Flat;
            manageNurseButton.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageNurseButton.Image = Properties.Resources.doc_stethoscope;
            manageNurseButton.ImageAlign = ContentAlignment.MiddleLeft;
            manageNurseButton.Location = new Point(4, 2);
            manageNurseButton.Margin = new Padding(2);
            manageNurseButton.Name = "manageNurseButton";
            manageNurseButton.Padding = new Padding(6, 0, 0, 0);
            manageNurseButton.Size = new Size(139, 47);
            manageNurseButton.TabIndex = 1;
            manageNurseButton.Text = "       Manage Nurse";
            manageNurseButton.UseVisualStyleBackColor = true;
            manageNurseButton.Click += manageNurseButton_Click;
            // 
            // manageDoctorPanel
            // 
            manageDoctorPanel.Controls.Add(manageDoctorBTN);
            manageDoctorPanel.Location = new Point(2, 112);
            manageDoctorPanel.Margin = new Padding(2);
            manageDoctorPanel.Name = "manageDoctorPanel";
            manageDoctorPanel.Size = new Size(145, 51);
            manageDoctorPanel.TabIndex = 6;
            // 
            // manageDoctorBTN
            // 
            manageDoctorBTN.BackgroundImageLayout = ImageLayout.Zoom;
            manageDoctorBTN.FlatAppearance.BorderSize = 0;
            manageDoctorBTN.FlatStyle = FlatStyle.Flat;
            manageDoctorBTN.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageDoctorBTN.Image = Properties.Resources.nurse_icon;
            manageDoctorBTN.ImageAlign = ContentAlignment.MiddleLeft;
            manageDoctorBTN.Location = new Point(4, 2);
            manageDoctorBTN.Margin = new Padding(2);
            manageDoctorBTN.Name = "manageDoctorBTN";
            manageDoctorBTN.Padding = new Padding(2, 0, 0, 0);
            manageDoctorBTN.Size = new Size(139, 47);
            manageDoctorBTN.TabIndex = 0;
            manageDoctorBTN.Text = "          Manage Doctor";
            manageDoctorBTN.UseVisualStyleBackColor = true;
            manageDoctorBTN.Click += manageDoctorBTN_Click;
            // 
            // generateReportPnl
            // 
            generateReportPnl.Controls.Add(generateReportBTN);
            generateReportPnl.Location = new Point(2, 167);
            generateReportPnl.Margin = new Padding(2);
            generateReportPnl.Name = "generateReportPnl";
            generateReportPnl.Size = new Size(143, 51);
            generateReportPnl.TabIndex = 0;
            // 
            // generateReportBTN
            // 
            generateReportBTN.FlatAppearance.BorderSize = 0;
            generateReportBTN.FlatStyle = FlatStyle.Flat;
            generateReportBTN.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateReportBTN.Image = Properties.Resources.books_icon;
            generateReportBTN.ImageAlign = ContentAlignment.MiddleLeft;
            generateReportBTN.Location = new Point(3, 2);
            generateReportBTN.Margin = new Padding(2);
            generateReportBTN.Name = "generateReportBTN";
            generateReportBTN.Padding = new Padding(5, 0, 0, 0);
            generateReportBTN.Size = new Size(139, 47);
            generateReportBTN.TabIndex = 1;
            generateReportBTN.Text = "            Generate Reports";
            generateReportBTN.UseVisualStyleBackColor = true;
            generateReportBTN.Click += generateReportBTN_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // adminMainPanel
            // 
            adminMainPanel.Dock = DockStyle.Fill;
            adminMainPanel.Location = new Point(0, 0);
            adminMainPanel.Margin = new Padding(2);
            adminMainPanel.Name = "adminMainPanel";
            adminMainPanel.Size = new Size(916, 369);
            adminMainPanel.TabIndex = 8;
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
            exitAppBTN.TabIndex = 7;
            exitAppBTN.UseVisualStyleBackColor = true;
            exitAppBTN.Click += exitAppBTN_Click_1;
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(916, 369);
            Controls.Add(exitAppBTN);
            Controls.Add(sidebar);
            Controls.Add(adminMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "y";
            ((System.ComponentModel.ISupportInitialize)adminUserPictureBox).EndInit();
            logoutPanel.ResumeLayout(false);
            logoutPanel.PerformLayout();
            adminMenuPanel.ResumeLayout(false);
            adminMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuBTN).EndInit();
            sidebar.ResumeLayout(false);
            manageNursePanel.ResumeLayout(false);
            manageDoctorPanel.ResumeLayout(false);
            generateReportPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox logedInUserTextBox;
        private Button adminLogoutBTN;
        private PictureBox adminUserPictureBox;
        private Panel logoutPanel;
        private Label adminMenuLabel;
        private Panel adminMenuPanel;
        private FlowLayoutPanel sidebar;
        private Panel manageNursePanel;
        private Button manageDoctorBTN;
        private Button manageNurseButton;
        private Panel manageDoctorPanel;
        private PictureBox menuBTN;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel adminMainPanel;
        private Panel generateReportPnl;
        private Button generateReportBTN;
        private Button exitAppBTN;
    }
}