namespace HealthCareSync
{
    partial class NursesHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NursesHomePage));
            exitAppBTN = new Button();
            sidebar = new FlowLayoutPanel();
            menuPanel = new Panel();
            menuBTN = new PictureBox();
            menuLabel = new Label();
            mngPatientsPanel = new Panel();
            managPatBTN = new Button();
            mngApptsPanel = new Panel();
            manageAppt = new Button();
            manageVisitPanel = new Panel();
            testsBTN = new Button();
            visitsBTN = new Button();
            manageVisit = new Button();
            logoutPanel = new Panel();
            logedInUserTextBox = new TextBox();
            logoutBTN = new Button();
            userPictureBox = new PictureBox();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            mngVisitTimer = new System.Windows.Forms.Timer(components);
            mainPanel = new Panel();
            manageNurseBTN = new Button();
            sidebar.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuBTN).BeginInit();
            mngPatientsPanel.SuspendLayout();
            mngApptsPanel.SuspendLayout();
            manageVisitPanel.SuspendLayout();
            logoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            SuspendLayout();
            // 
            // exitAppBTN
            // 
            exitAppBTN.BackgroundImage = (Image)resources.GetObject("exitAppBTN.BackgroundImage");
            exitAppBTN.BackgroundImageLayout = ImageLayout.Zoom;
            exitAppBTN.FlatAppearance.BorderSize = 0;
            exitAppBTN.FlatStyle = FlatStyle.Flat;
            exitAppBTN.Location = new Point(734, 11);
            exitAppBTN.Margin = new Padding(2, 4, 2, 4);
            exitAppBTN.Name = "exitAppBTN";
            exitAppBTN.Size = new Size(38, 32);
            exitAppBTN.TabIndex = 0;
            exitAppBTN.UseVisualStyleBackColor = true;
            exitAppBTN.Click += button1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(menuPanel);
            sidebar.Controls.Add(mngPatientsPanel);
            sidebar.Controls.Add(mngApptsPanel);
            sidebar.Controls.Add(manageVisitPanel);
            sidebar.Controls.Add(logoutPanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(2, 4, 2, 4);
            sidebar.MaximumSize = new Size(210, 450);
            sidebar.MinimumSize = new Size(71, 450);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(147, 270);
            sidebar.TabIndex = 1;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(menuBTN);
            menuPanel.Controls.Add(menuLabel);
            menuPanel.Location = new Point(2, 4);
            menuPanel.Margin = new Padding(2, 4, 2, 4);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(208, 59);
            menuPanel.TabIndex = 0;
            // 
            // menuBTN
            // 
            menuBTN.Cursor = Cursors.Hand;
            menuBTN.Image = (Image)resources.GetObject("menuBTN.Image");
            menuBTN.Location = new Point(4, 11);
            menuBTN.Margin = new Padding(4);
            menuBTN.Name = "menuBTN";
            menuBTN.Size = new Size(46, 36);
            menuBTN.SizeMode = PictureBoxSizeMode.Zoom;
            menuBTN.TabIndex = 0;
            menuBTN.TabStop = false;
            menuBTN.Click += menuBTN_Click;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(66, 9);
            menuLabel.Margin = new Padding(2, 0, 2, 0);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(46, 19);
            menuLabel.TabIndex = 1;
            menuLabel.Text = "Menu";
            // 
            // mngPatientsPanel
            // 
            mngPatientsPanel.Controls.Add(manageNurseBTN);
            mngPatientsPanel.Controls.Add(managPatBTN);
            mngPatientsPanel.Location = new Point(2, 71);
            mngPatientsPanel.Margin = new Padding(2, 4, 2, 4);
            mngPatientsPanel.Name = "mngPatientsPanel";
            mngPatientsPanel.Size = new Size(202, 59);
            mngPatientsPanel.TabIndex = 2;
            // 
            // managPatBTN
            // 
            managPatBTN.FlatAppearance.BorderSize = 0;
            managPatBTN.FlatStyle = FlatStyle.Flat;
            managPatBTN.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managPatBTN.Image = Properties.Resources.manage_patients_icon;
            managPatBTN.ImageAlign = ContentAlignment.MiddleLeft;
            managPatBTN.Location = new Point(-1, -4);
            managPatBTN.Margin = new Padding(4);
            managPatBTN.Name = "managPatBTN";
            managPatBTN.Size = new Size(209, 65);
            managPatBTN.TabIndex = 0;
            managPatBTN.Text = "Manage Patients";
            managPatBTN.TextAlign = ContentAlignment.MiddleRight;
            managPatBTN.UseVisualStyleBackColor = true;
            managPatBTN.Click += managPatBTN_Click;
            // 
            // mngApptsPanel
            // 
            mngApptsPanel.Controls.Add(manageAppt);
            mngApptsPanel.Location = new Point(2, 138);
            mngApptsPanel.Margin = new Padding(2, 4, 2, 4);
            mngApptsPanel.Name = "mngApptsPanel";
            mngApptsPanel.Size = new Size(202, 59);
            mngApptsPanel.TabIndex = 3;
            // 
            // manageAppt
            // 
            manageAppt.BackgroundImageLayout = ImageLayout.Zoom;
            manageAppt.FlatAppearance.BorderSize = 0;
            manageAppt.FlatStyle = FlatStyle.Flat;
            manageAppt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageAppt.Image = (Image)resources.GetObject("manageAppt.Image");
            manageAppt.ImageAlign = ContentAlignment.MiddleLeft;
            manageAppt.Location = new Point(-1, 0);
            manageAppt.Margin = new Padding(2, 4, 2, 4);
            manageAppt.Name = "manageAppt";
            manageAppt.Padding = new Padding(2, 0, 0, 0);
            manageAppt.Size = new Size(209, 59);
            manageAppt.TabIndex = 0;
            manageAppt.Text = "            Manage Appt";
            manageAppt.TextAlign = ContentAlignment.MiddleLeft;
            manageAppt.UseVisualStyleBackColor = true;
            manageAppt.Click += manageAppt_Click;
            // 
            // manageVisitPanel
            // 
            manageVisitPanel.Controls.Add(testsBTN);
            manageVisitPanel.Controls.Add(visitsBTN);
            manageVisitPanel.Controls.Add(manageVisit);
            manageVisitPanel.Location = new Point(2, 205);
            manageVisitPanel.Margin = new Padding(2, 4, 2, 4);
            manageVisitPanel.MaximumSize = new Size(208, 151);
            manageVisitPanel.MinimumSize = new Size(208, 59);
            manageVisitPanel.Name = "manageVisitPanel";
            manageVisitPanel.Size = new Size(208, 151);
            manageVisitPanel.TabIndex = 4;
            // 
            // testsBTN
            // 
            testsBTN.BackgroundImageLayout = ImageLayout.Zoom;
            testsBTN.FlatAppearance.BorderSize = 0;
            testsBTN.FlatStyle = FlatStyle.Flat;
            testsBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testsBTN.Image = (Image)resources.GetObject("testsBTN.Image");
            testsBTN.ImageAlign = ContentAlignment.MiddleLeft;
            testsBTN.Location = new Point(0, 99);
            testsBTN.Margin = new Padding(2, 4, 2, 4);
            testsBTN.Name = "testsBTN";
            testsBTN.Padding = new Padding(10, 0, 0, 0);
            testsBTN.Size = new Size(208, 59);
            testsBTN.TabIndex = 0;
            testsBTN.Text = "            Tests";
            testsBTN.TextAlign = ContentAlignment.MiddleLeft;
            testsBTN.UseVisualStyleBackColor = true;
            testsBTN.Click += testsBTN_Click;
            // 
            // visitsBTN
            // 
            visitsBTN.BackgroundImageLayout = ImageLayout.Zoom;
            visitsBTN.FlatAppearance.BorderSize = 0;
            visitsBTN.FlatStyle = FlatStyle.Flat;
            visitsBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            visitsBTN.Image = (Image)resources.GetObject("visitsBTN.Image");
            visitsBTN.ImageAlign = ContentAlignment.MiddleLeft;
            visitsBTN.Location = new Point(0, 49);
            visitsBTN.Margin = new Padding(2, 4, 2, 4);
            visitsBTN.Name = "visitsBTN";
            visitsBTN.Padding = new Padding(14, 0, 0, 0);
            visitsBTN.Size = new Size(208, 59);
            visitsBTN.TabIndex = 0;
            visitsBTN.Text = "          Visits";
            visitsBTN.TextAlign = ContentAlignment.MiddleLeft;
            visitsBTN.UseVisualStyleBackColor = true;
            visitsBTN.Click += visitsBTN_Click;
            // 
            // manageVisit
            // 
            manageVisit.BackgroundImageLayout = ImageLayout.Zoom;
            manageVisit.FlatAppearance.BorderSize = 0;
            manageVisit.FlatStyle = FlatStyle.Flat;
            manageVisit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageVisit.Image = (Image)resources.GetObject("manageVisit.Image");
            manageVisit.ImageAlign = ContentAlignment.MiddleLeft;
            manageVisit.Location = new Point(0, 0);
            manageVisit.Margin = new Padding(2, 4, 2, 4);
            manageVisit.Name = "manageVisit";
            manageVisit.Padding = new Padding(1, 0, 0, 0);
            manageVisit.Size = new Size(208, 59);
            manageVisit.TabIndex = 0;
            manageVisit.Text = "            Manage Visit";
            manageVisit.TextAlign = ContentAlignment.MiddleLeft;
            manageVisit.UseVisualStyleBackColor = true;
            manageVisit.Click += manageVisit_Click;
            // 
            // logoutPanel
            // 
            logoutPanel.Controls.Add(logedInUserTextBox);
            logoutPanel.Controls.Add(logoutBTN);
            logoutPanel.Controls.Add(userPictureBox);
            logoutPanel.Location = new Point(2, 364);
            logoutPanel.Margin = new Padding(2, 4, 2, 4);
            logoutPanel.Name = "logoutPanel";
            logoutPanel.Size = new Size(202, 86);
            logoutPanel.TabIndex = 5;
            // 
            // logedInUserTextBox
            // 
            logedInUserTextBox.BackColor = Color.White;
            logedInUserTextBox.BorderStyle = BorderStyle.None;
            logedInUserTextBox.Location = new Point(9, 60);
            logedInUserTextBox.Margin = new Padding(2, 4, 2, 4);
            logedInUserTextBox.Multiline = true;
            logedInUserTextBox.Name = "logedInUserTextBox";
            logedInUserTextBox.ReadOnly = true;
            logedInUserTextBox.Size = new Size(191, 39);
            logedInUserTextBox.TabIndex = 3;
            // 
            // logoutBTN
            // 
            logoutBTN.BackColor = Color.IndianRed;
            logoutBTN.FlatAppearance.BorderSize = 0;
            logoutBTN.FlatStyle = FlatStyle.Flat;
            logoutBTN.ForeColor = Color.White;
            logoutBTN.Location = new Point(76, 16);
            logoutBTN.Margin = new Padding(2, 4, 2, 4);
            logoutBTN.Name = "logoutBTN";
            logoutBTN.Size = new Size(78, 20);
            logoutBTN.TabIndex = 2;
            logoutBTN.Text = "Log Out";
            logoutBTN.UseVisualStyleBackColor = false;
            logoutBTN.Click += logoutBTN_Click;
            // 
            // userPictureBox
            // 
            userPictureBox.Image = (Image)resources.GetObject("userPictureBox.Image");
            userPictureBox.Location = new Point(11, 8);
            userPictureBox.Margin = new Padding(4);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(49, 54);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 0;
            userPictureBox.TabStop = false;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // mngVisitTimer
            // 
            mngVisitTimer.Interval = 10;
            mngVisitTimer.Tick += mngVisitTimer_Tick;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.ForeColor = Color.Black;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(2, 4, 2, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(560, 270);
            mainPanel.TabIndex = 2;
            // 
            // NursesHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 270);
            Controls.Add(sidebar);
            Controls.Add(exitAppBTN);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "NursesHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            sidebar.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuBTN).EndInit();
            mngPatientsPanel.ResumeLayout(false);
            mngApptsPanel.ResumeLayout(false);
            manageVisitPanel.ResumeLayout(false);
            logoutPanel.ResumeLayout(false);
            logoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitAppBTN;
        private FlowLayoutPanel sidebar;
        private Panel mngPatientsPanel;
        private Button managPatBTN;
        private Panel menuPanel;
        private Panel mngApptsPanel;
        private Button manageAppt;
        private Button manageVisit;
        private PictureBox menuBTN;
        private Label menuLabel;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel manageVisitPanel;
        private Button visitsBTN;
        private Button testsBTN;
        private System.Windows.Forms.Timer mngVisitTimer;
        private Panel mainPanel;
        private Panel logoutPanel;
        private PictureBox userPictureBox;
        private Button logoutBTN;
        private TextBox logedInUserTextBox;
        private Button manageNurseBTN;
    }
}