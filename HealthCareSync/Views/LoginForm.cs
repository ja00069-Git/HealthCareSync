using HealthCareSync.Enums;
using HealthCareSync.ViewModels;
using HealthCareSync.Views;

namespace HealthCareSync
{
    public partial class LoginForm : Form
    {
        private readonly LoginViewModel loginViewModel;
        public LoginForm()
        {
            InitializeComponent();
            loginViewModel = new LoginViewModel();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            loginViewModel.User.Username = usernameTB.Text;
            loginViewModel.User.Password = passwordTB.Text;

            if (loginViewModel.Login())
            {
                switch (loginViewModel.UserRole)
                {
                    case UserRole.ADMIN:
                        var adminHomePage = new AdminHomePage(loginViewModel.LoggedInUser);
                        adminHomePage.Show();
                        break;

                    case UserRole.NURSE:
                        var nurseHomePage = new NursesHomePage(loginViewModel.LoggedInUser);
                        nurseHomePage.Show();
                        break;

                    case UserRole.NONE:
                    default:
                        MessageBox.Show("You don't have permission to access this application.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

                this.Hide();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            var signup = new SignupForm();
            signup.Show();
            this.Hide();
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
