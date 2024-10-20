using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareSync.Views
{
    public partial class AdminPage : Form
    {
        bool isCollapsedAd;
        bool isMngVisitCollapsedAd;
        public AdminPage()
        {
            InitializeComponent();
            isCollapsedAd = false;
            isMngVisitCollapsedAd = false;
            this.sidebarTimerForAdminPage.Start();
            this.mngVisitTimerForAdminPage.Start();
            this.openChildFormAd(new ManageNurses());
        }
        public AdminPage(string logedInUser)
        {
            InitializeComponent();
            isCollapsedAd = false;
            isMngVisitCollapsedAd = false;
            this.sidebarTimerForAdminPage.Start();
            this.mngVisitTimerForAdminPage.Start();
            this.logedInUserTextBoxForAdminPage.Text = "Welcome, " + logedInUser;
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

        private void manageNurseBTN_Click(object sender, EventArgs e)
        {
            openChildFormAd(new ManageNurses());
        }

        private void adminMenuBTN_Click(object sender, EventArgs e)
        {
            sidebarTimerForAdminPage.Start();
        }

        private void mngVisitTimerForAdminPage_Tick(object sender, EventArgs e)
        {
            if (isMngVisitCollapsedAd)
            {
                adminManageVisitPanel.Height = adminManageVisitPanel.Height + 10;
                if (adminManageVisitPanel.Height == adminManageVisitPanel.MaximumSize.Height)
                {
                    mngVisitTimerForAdminPage.Stop();
                    isMngVisitCollapsedAd = false;
                    this.Refresh();
                }
            }
            else
            {
                adminManageVisitPanel.Height = adminManageVisitPanel.Height - 10;
                if (adminManageVisitPanel.Height == adminManageVisitPanel.MinimumSize.Height)
                {
                    mngVisitTimerForAdminPage.Stop();
                    isMngVisitCollapsedAd = true;
                    this.Refresh();
                }
            }
        }

        private void sidebarTimerForAdminPage_Tick(object sender, EventArgs e)
        {
            if (isCollapsedAd)
            {
                sidebar.Width = sidebar.Width + 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarTimerForAdminPage.Stop();
                    isCollapsedAd = false;
                    this.Refresh();
                }
            }
            else
            {
                sidebar.Width = sidebar.Width - 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarTimerForAdminPage.Stop();
                    isCollapsedAd = true;
                    this.Refresh();
                }
            }
        }

        private void adminExitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var login = new LoginForm();
            login.Show();
        }

        private void adminLogoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            var login = new LoginForm();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormAd(new ManageNurses());
        }

        private void manageDoctorBTN_Click(object sender, EventArgs e)
        {
            openChildFormAd(new ManageDoctor());
        }
    }
}
