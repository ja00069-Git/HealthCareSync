using HealthCareSync.Models;
using HealthCareSync.ViewModels;
using System.Text.RegularExpressions;

namespace HealthCareSync.Views
{
    public partial class SignupForm : Form
    {
        private AdministratorViewModel viewModel;

        public SignupForm()
        {
            InitializeComponent();
            this.viewModel = new AdministratorViewModel();
            this.stateComboBox.DataSource = viewModel.States;
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNurseButton_Click(object sender, EventArgs e)
        {
            var fname = this.firstNameTextBox.Text;
            var lname = this.lastNameTextBox.Text;
            var bDate = this.dateTimePicker.Value;
            var phoneNum = this.phoneNumTextBox.Text;
            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;
            var address1 = this.address1TextBox.Text;
            var zip = this.zipTextBox.Text;
            var city = this.cityTextBox.Text;
            var state = this.stateComboBox.Text;
            var address2 = this.address2TextBox.Text;

            if (this.inputsValid(fname, lname, phoneNum, address1, city, zip, username, password))
            {
                this.viewModel.Add(fname, lname, bDate, phoneNum, address1, zip, city, state, address2, username, password);
                MessageBox.Show("Admin Added Successfully In The System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                var loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show(this.errorMessages, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string errorMessages = string.Empty;

        private bool inputsValid(string fname, string lname, string phoneNum, string address1, string city, string zip, string username, string password)
        {
            this.errorMessages = string.Empty;
            bool isErrors = false;

            if (string.IsNullOrWhiteSpace(fname))
            {
                this.errorMessages += $"\n {Constants.ERROR_FIRST_NAME}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(lname))
            {
                this.errorMessages += $"\n {Constants.ERROR_LAST_NAME}";
                isErrors = true;
            }
            if (!Regex.IsMatch(phoneNum, Constants.PHONE_NUMBER_REGEX_PATTERN))
            {
                this.errorMessages += $"\n {Constants.ERROR_PHONE_NUMBER}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(address1))
            {
                this.errorMessages += $"\n {Constants.ERROR_ADDRESS_1}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                this.errorMessages += $"\n {Constants.ERROR_CITY}";
                isErrors = true;
            }
            if (this.stateComboBox.SelectedItem == null)
            {
                this.errorMessages += $"\n {Constants.ERROR_STATE}";
                isErrors = true;
            }
            if (!Regex.IsMatch(zip, Constants.ZIP_REGEX_PATTERN))
            {
                this.errorMessages += $"\n {Constants.ERROR_ZIP}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                this.errorMessages += $"\n {Constants.ERROR_USERNAME}";
                isErrors = true;
            }
            if (!this.viewModel.IsUsernameAvailable(username))
            {
                this.errorMessages += $"\n {Constants.ERROR_USERNAME_TAKEN}";
                isErrors = true;
            }
            if (!Regex.IsMatch(password, Constants.PASSWORD_REGEX_PATTERN))
            {
                this.errorMessages += $"\n {Constants.ERROR_PASSWORD}";
                isErrors = true;
            }

            return !isErrors;
        }
    }
}
