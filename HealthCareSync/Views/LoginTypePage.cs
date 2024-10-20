using HealthCareSync.ViewModels;
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
    public partial class LoginTypePage : Form
    {
        private readonly LoginViewModel loginViewModel;
        public LoginTypePage()
        {
            InitializeComponent();
        }
        public LoginTypePage(String logedInUser)
        {
            InitializeComponent();
            this.logInTypePageUserLabel.Text = "Hello " + logedInUser + "!, Select a profile.";

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loginSuccess = loginViewModel.Login();

            if (loginSuccess)
            {
                var dashboard = new HomePage(loginViewModel.LogedInUser);
                this.Hide();
                dashboard.Show();
            }
        }
    }
}
