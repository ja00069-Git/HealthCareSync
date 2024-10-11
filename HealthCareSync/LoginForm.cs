namespace HealthCareSync
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            // Hardcoded valid username and password for this example
            string validUsername = "admin";
            string validPassword = "password123";

            // Get the input from textboxes
            string enteredUsername = usernameTB.Text;
            string enteredPassword = passwordTB.Text;

            // Simple validation
            if (string.IsNullOrWhiteSpace(enteredUsername))
            {
                MessageBox.Show("Please enter your username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please enter your password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the username and password are correct
            if (enteredUsername == validUsername && enteredPassword == validPassword)
            {
                // Proceed to the next form or dashboard
                var dashboard = new HomePage();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
