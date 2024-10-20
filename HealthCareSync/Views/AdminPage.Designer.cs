namespace HealthCareSync.Views
{
    partial class AdminPage
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
            mngVisitTimerForAdminPage = new System.Windows.Forms.Timer(components);
            logedInUserTextBoxForAdminPage = new TextBox();
            adminLogoutBTN = new Button();
            adminUserPictureBox = new PictureBox();
            logoutPanel = new Panel();
            sidebarTimerForAdminPage = new System.Windows.Forms.Timer(components);
            manageNurseBTN = new Button();
            adminMenuBTN = new PictureBox();
            adminMenuLabel = new Label();
            adminMenuPanel = new Panel();
            sidebar = new FlowLayoutPanel();
            adminManageVisitPanel = new Panel();
            manageNurseButton = new Button();
            manageDoctorBTN = new Button();
            adminExitAppBTN = new Button();
            adminMainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)adminUserPictureBox).BeginInit();
            logoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminMenuBTN).BeginInit();
            adminMenuPanel.SuspendLayout();
            sidebar.SuspendLayout();
            adminManageVisitPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mngVisitTimerForAdminPage
            // 
            mngVisitTimerForAdminPage.Interval = 10;
            // 
            // logedInUserTextBoxForAdminPage
            // 
            logedInUserTextBoxForAdminPage.BackColor = Color.White;
            logedInUserTextBoxForAdminPage.BorderStyle = BorderStyle.None;
            logedInUserTextBoxForAdminPage.Location = new Point(6, 34);
            logedInUserTextBoxForAdminPage.Margin = new Padding(2);
            logedInUserTextBoxForAdminPage.Multiline = true;
            logedInUserTextBoxForAdminPage.Name = "logedInUserTextBoxForAdminPage";
            logedInUserTextBoxForAdminPage.ReadOnly = true;
            logedInUserTextBoxForAdminPage.Size = new Size(134, 23);
            logedInUserTextBoxForAdminPage.TabIndex = 3;
            // 
            // adminLogoutBTN
            // 
            adminLogoutBTN.BackColor = Color.IndianRed;
            adminLogoutBTN.FlatAppearance.BorderSize = 0;
            adminLogoutBTN.FlatStyle = FlatStyle.Flat;
            adminLogoutBTN.ForeColor = Color.White;
            adminLogoutBTN.Location = new Point(53, 10);
            adminLogoutBTN.Margin = new Padding(2);
            adminLogoutBTN.Name = "adminLogoutBTN";
            adminLogoutBTN.Size = new Size(78, 20);
            adminLogoutBTN.TabIndex = 2;
            adminLogoutBTN.Text = "Log Out";
            adminLogoutBTN.UseVisualStyleBackColor = false;
            adminLogoutBTN.Click += adminLogoutBTN_Click;
            // 
            // adminUserPictureBox
            // 
            adminUserPictureBox.Image = Properties.Resources.Screenshot_2024_10_11_124514;
            adminUserPictureBox.Location = new Point(6, 4);
            adminUserPictureBox.Margin = new Padding(2);
            adminUserPictureBox.Name = "adminUserPictureBox";
            adminUserPictureBox.Size = new Size(34, 32);
            adminUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            adminUserPictureBox.TabIndex = 0;
            adminUserPictureBox.TabStop = false;
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(logedInUserTextBoxForAdminPage);
            logoutPanel.Controls.Add(adminLogoutBTN);
            logoutPanel.Controls.Add(adminUserPictureBox);
            logoutPanel.Location = new Point(2, 136);
            logoutPanel.Margin = new Padding(2);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(142, 59);
            logoutPanel.TabIndex = 5;
            // 
            // sidebarTimerForAdminPage
            // 
            sidebarTimerForAdminPage.Interval = 10;
            // 
            // manageNurseBTN
            // 
            manageNurseBTN.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageNurseBTN.Location = new Point(1, -2);
            manageNurseBTN.Margin = new Padding(0);
            manageNurseBTN.Name = "manageNurseBTN";
            manageNurseBTN.Size = new Size(146, 37);
            manageNurseBTN.TabIndex = 0;
            manageNurseBTN.Text = "Manage Nurses";
            manageNurseBTN.UseVisualStyleBackColor = false;
            manageNurseBTN.Click += manageNurseBTN_Click;
            // 
            // adminMenuBTN
            // 
            adminMenuBTN.Cursor = Cursors.Hand;
            adminMenuBTN.Image = Properties.Resources.Screenshot_2024_10_13_154443;
            adminMenuBTN.Location = new Point(2, 5);
            adminMenuBTN.Margin = new Padding(2);
            adminMenuBTN.Name = "adminMenuBTN";
            adminMenuBTN.Size = new Size(32, 22);
            adminMenuBTN.SizeMode = PictureBoxSizeMode.Zoom;
            adminMenuBTN.TabIndex = 0;
            adminMenuBTN.TabStop = false;
            adminMenuBTN.Click += adminMenuBTN_Click;
            // 
            // adminMenuLabel
            // 
            adminMenuLabel.AutoSize = true;
            adminMenuLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminMenuLabel.Location = new Point(46, 5);
            adminMenuLabel.Margin = new Padding(2, 0, 2, 0);
            adminMenuLabel.Name = "adminMenuLabel";
            adminMenuLabel.Size = new Size(46, 19);
            adminMenuLabel.TabIndex = 1;
            adminMenuLabel.Text = "Menu";
            // 
            // adminMenuPanel
            // 
            adminMenuPanel.Controls.Add(adminMenuBTN);
            adminMenuPanel.Controls.Add(adminMenuLabel);
            adminMenuPanel.Location = new Point(2, 2);
            adminMenuPanel.Margin = new Padding(2);
            adminMenuPanel.Name = "adminMenuPanel";
            adminMenuPanel.Size = new Size(145, 35);
            adminMenuPanel.TabIndex = 0;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(adminMenuPanel);
            sidebar.Controls.Add(adminManageVisitPanel);
            sidebar.Controls.Add(logoutPanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(2);
            sidebar.MaximumSize = new Size(147, 270);
            sidebar.MinimumSize = new Size(50, 270);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(147, 270);
            sidebar.TabIndex = 4;
            // 
            // adminManageVisitPanel
            // 
            adminManageVisitPanel.Controls.Add(manageNurseButton);
            adminManageVisitPanel.Controls.Add(manageDoctorBTN);
            adminManageVisitPanel.Location = new Point(2, 41);
            adminManageVisitPanel.Margin = new Padding(2);
            adminManageVisitPanel.MaximumSize = new Size(145, 91);
            adminManageVisitPanel.MinimumSize = new Size(145, 35);
            adminManageVisitPanel.Name = "adminManageVisitPanel";
            adminManageVisitPanel.Size = new Size(145, 91);
            adminManageVisitPanel.TabIndex = 4;
            // 
            // manageNurseButton
            // 
            manageNurseButton.BackgroundImageLayout = ImageLayout.Zoom;
            manageNurseButton.FlatAppearance.BorderSize = 0;
            manageNurseButton.FlatStyle = FlatStyle.Flat;
            manageNurseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageNurseButton.ImageAlign = ContentAlignment.MiddleLeft;
            manageNurseButton.Location = new Point(-2, 39);
            manageNurseButton.Margin = new Padding(2);
            manageNurseButton.Name = "manageNurseButton";
            manageNurseButton.Padding = new Padding(2, 0, 0, 0);
            manageNurseButton.Size = new Size(146, 35);
            manageNurseButton.TabIndex = 1;
            manageNurseButton.Text = "      Manage Nurse";
            manageNurseButton.TextAlign = ContentAlignment.MiddleLeft;
            manageNurseButton.UseVisualStyleBackColor = true;
            manageNurseButton.Click += button1_Click;
            // 
            // manageDoctorBTN
            // 
            manageDoctorBTN.BackgroundImageLayout = ImageLayout.Zoom;
            manageDoctorBTN.FlatAppearance.BorderSize = 0;
            manageDoctorBTN.FlatStyle = FlatStyle.Flat;
            manageDoctorBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageDoctorBTN.ImageAlign = ContentAlignment.MiddleLeft;
            manageDoctorBTN.Location = new Point(-2, 0);
            manageDoctorBTN.Margin = new Padding(2);
            manageDoctorBTN.Name = "manageDoctorBTN";
            manageDoctorBTN.Padding = new Padding(2, 0, 0, 0);
            manageDoctorBTN.Size = new Size(146, 35);
            manageDoctorBTN.TabIndex = 0;
            manageDoctorBTN.Text = "      Manage Doctor";
            manageDoctorBTN.TextAlign = ContentAlignment.MiddleLeft;
            manageDoctorBTN.UseVisualStyleBackColor = true;
            manageDoctorBTN.Click += manageDoctorBTN_Click;
            // 
            // adminExitAppBTN
            // 
            adminExitAppBTN.BackgroundImage = Properties.Resources.Screenshot_2024_10_13_132820;
            adminExitAppBTN.BackgroundImageLayout = ImageLayout.Zoom;
            adminExitAppBTN.FlatAppearance.BorderSize = 0;
            adminExitAppBTN.FlatStyle = FlatStyle.Flat;
            adminExitAppBTN.Location = new Point(514, 7);
            adminExitAppBTN.Margin = new Padding(2);
            adminExitAppBTN.Name = "adminExitAppBTN";
            adminExitAppBTN.Size = new Size(38, 32);
            adminExitAppBTN.TabIndex = 3;
            adminExitAppBTN.UseVisualStyleBackColor = true;
            adminExitAppBTN.Click += adminExitAppBTN_Click;
            // 
            // adminMainPanel
            // 
            adminMainPanel.Dock = DockStyle.Fill;
            adminMainPanel.ForeColor = Color.Black;
            adminMainPanel.Location = new Point(0, 0);
            adminMainPanel.Margin = new Padding(2);
            adminMainPanel.Name = "adminMainPanel";
            adminMainPanel.Size = new Size(560, 270);
            adminMainPanel.TabIndex = 5;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 270);
            Controls.Add(sidebar);
            Controls.Add(adminExitAppBTN);
            Controls.Add(adminMainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminPage";
            Text = "y";
            ((System.ComponentModel.ISupportInitialize)adminUserPictureBox).EndInit();
            logoutPanel.ResumeLayout(false);
            logoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminMenuBTN).EndInit();
            adminMenuPanel.ResumeLayout(false);
            adminMenuPanel.PerformLayout();
            sidebar.ResumeLayout(false);
            adminManageVisitPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer mngVisitTimerForAdminPage;
        private TextBox logedInUserTextBoxForAdminPage;
        private Button adminLogoutBTN;
        private PictureBox adminUserPictureBox;
        private Panel logoutPanel;
        private System.Windows.Forms.Timer sidebarTimerForAdminPage;
        private Button manageNurseBTN;
        private Panel mngPatientsPanel;
        private PictureBox adminMenuBTN;
        private Label adminMenuLabel;
        private Panel adminMenuPanel;
        private FlowLayoutPanel sidebar;
        private Button adminExitAppBTN;
        private Panel adminMainPanel;
        private Panel adminManageVisitPanel;
        private Button manageDoctorBTN;
        private Button manageNurseButton;
    }
}