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

            bool loginSuccess = loginViewModel.Login();

            if (loginSuccess)
            {
                //var dashboard = new HomePage(loginViewModel.LogedInUser);

                var dashboard = new AdminPage(loginViewModel.LogedInUser);
                this.Hide();
                dashboard.Show();
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
