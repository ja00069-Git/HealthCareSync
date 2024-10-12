using HealthCareSync.ViewModels;

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
            // Bind UI data to ViewModel
            loginViewModel.User.Username = usernameTB.Text;
            loginViewModel.User.Password = passwordTB.Text;

            // Call the Login method in the ViewModel
            bool loginSuccess = loginViewModel.Login();

            if (loginSuccess)
            {
                // Open the dashboard or next form
                var dashboard = new HomePage();
                this.Hide();
                dashboard.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }
    }
}
