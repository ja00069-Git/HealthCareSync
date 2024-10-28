using HealthCareSync.Views;

namespace HealthCareSync
{
    public partial class NursesHomePage : Form
    {
        bool isCollapsed;
        bool isMngVisitCollapsed;
        public NursesHomePage()
        {
            InitializeComponent();
            isCollapsed = false;
            isMngVisitCollapsed = false;
            this.sidebarTimer.Start();
            this.mngVisitTimer.Start();
            this.openChildForm(new Manage_Patients());
        }

        public NursesHomePage(string logedInUser)
        {
            InitializeComponent();
            isCollapsed = false;
            isMngVisitCollapsed = false;
            this.sidebarTimer.Start();
            this.mngVisitTimer.Start();
            this.logedInUserTextBox.Text = "Welcome, " + logedInUser;
            this.openChildForm(new Manage_Patients());
        }

        public void openChildForm(Form childForm)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var login = new LoginForm();
            login.Show();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                sidebar.Width = sidebar.Width + 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarTimer.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                sidebar.Width = sidebar.Width - 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarTimer.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void mngVisitTimer_Tick(object sender, EventArgs e)
        {
            if (isMngVisitCollapsed)
            {
                manageVisitPanel.Height = manageVisitPanel.Height + 10;
                if (manageVisitPanel.Height == manageVisitPanel.MaximumSize.Height)
                {
                    mngVisitTimer.Stop();
                    isMngVisitCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                manageVisitPanel.Height = manageVisitPanel.Height - 10;
                if (manageVisitPanel.Height == manageVisitPanel.MinimumSize.Height)
                {
                    mngVisitTimer.Stop();
                    isMngVisitCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void manageVisit_Click(object sender, EventArgs e)
        {
            mngVisitTimer.Start();
        }

        private void managPatBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_Patients());
        }

        private void manageAppt_Click(object sender, EventArgs e)
        {
            this.LoadManageAppointments();
        }

        private void LoadManageAppointments()
        {
            ManageAppts manageAppts = new ManageAppts();
            manageAppts.Dock = DockStyle.None; // Ensure it doesn't dock to fill the panel
            mainPanel.Controls.Clear(); // Clear previous controls if necessary
            mainPanel.Controls.Add(manageAppts); // Add the UserControl to the main panel
        }

        private void visitsBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageVisits());
        }

        private void testsBTN_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageTests());
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            var login = new LoginForm();
            login.Show();
        }
    }
}
