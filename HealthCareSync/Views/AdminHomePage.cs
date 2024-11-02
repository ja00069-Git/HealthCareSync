namespace HealthCareSync.Views
{
    public partial class AdminHomePage : Form
    {
        bool isCollapsedAd;
        bool isMngVisitCollapsedAd;
        public AdminHomePage()
        {
            InitializeComponent();
            isCollapsedAd = false;
            this.sideBarTimer.Start();
            this.openChildFormAd(new ManageNurses());
        }
        public AdminHomePage(string logedInUser)
        {
            InitializeComponent();
            isCollapsedAd = false;
            this.sideBarTimer.Start();
            this.logedInUserTextBox.Text = "Welcome, " + logedInUser;
            this.openChildFormAd(new ManageNurses());
        }
        public void openChildFormAd(Form childForm)
        {
            if (this.adminMainPanel.Controls.Count > 0)
            {
                this.adminMainPanel.Controls.RemoveAt(0);
            }
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.adminMainPanel.Controls.Add(childForm);
            this.adminMainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void manageDoctorBTN_Click(object sender, EventArgs e)
        {
            openChildFormAd(new ManageDoctor());
        }

        private void manageNurseButton_Click(object sender, EventArgs e)
        {
            openChildFormAd(new ManageNurses());
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsedAd)
            {
                sidebar.Width = sidebar.Width + 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    this.sideBarTimer.Stop();
                    isCollapsedAd = false;
                    this.Refresh();
                }
            }
            else
            {
                sidebar.Width = sidebar.Width - 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    this.sideBarTimer.Stop();
                    isCollapsedAd = true;
                    this.Refresh();
                }
            }
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            this.sideBarTimer.Start();
        }

        private void adminLogoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            var login = new LoginForm();
            login.Show();
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var login = new LoginForm();
            login.Show();
        }

        private void generateReportBTN_Click(object sender, EventArgs e)
        {
            openChildFormAd(new GenerateReport());
        }

        private void exitAppBTN_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
