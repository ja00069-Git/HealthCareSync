using HealthCareSync.Enums;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace HealthCareSync.Views
{
    public partial class ManageNurses : Form
    {
        private readonly string PHONE_NUMBER_REGEX_PATTERN = @"^(?:\+?(\d{1,3})[-.\s]?)?(\(?\d{3}\)?[-.\s]?)?\d{3}[-.\s]?\d{4}$";
        private readonly string ZIP_REGEX_PATTERN = @"^\d{5}$";
        private readonly string BIRTH_DATE_REGEX_PATTERN = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/([0-9]{4})$";
        private readonly string PASSWORD_REGEX_PATTERN = @"^[A-Za-z0-9]{6,}$";
        private readonly string ERROR_FIRST_NAME = "First name cannot be blank.";
        private readonly string ERROR_LAST_NAME = "Last name cannot be blank.";
        private readonly string ERROR_BIRTH_DATE = "Birth date must be in the format MM/dd/yyyy";
        private readonly string ERROR_PHONE_NUMBER = "Phone number must be 10 digits";
        private readonly string ERROR_PHONE_NUMBER_DASH = "Phone number must be 10 digits without dash";
        private readonly string ERROR_ADDRESS_1 = "Address 1 cannot be blank";
        private readonly string ERROR_ZIP = "Zip must be 5 digits";
        private readonly string ERROR_CITY = "Enter a city";
        private readonly string ERROR_STATE = "Select a state";
        private readonly string ERROR_USERNAME = "Username cannot be blank";
        private readonly string ERROR_USERNAME_TAKEN = "Username is already taken";
        private readonly string ERROR_PASSWORD = "Password must be more than 5 characters, letters and digits only";

        private string errorMessages = string.Empty;

        private ManageNursesViewModel viewModel;

        public ManageNurses()
        {
            InitializeComponent();
            this.viewModel = new ManageNursesViewModel();
            this.SubscribeToViewModelEvents();

            this.bindToViewModel();
            this.nurseListBox.SelectedIndex = -1;
            this.statusComboBox.Enabled = false;

            // Ensure fields are enabled when the application first runs
            this.firstNameTextBox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.dateTimePickerForNurse.Enabled = true;
        }

        private void bindToViewModel()
        {
            this.nurseListBox.DataSource = this.viewModel.Nurses;
            this.nurseListBox.DisplayMember = "FullName";

            this.stateComboBoxForNurse.DataSource = this.viewModel.States;
            this.statusComboBox.DataSource = this.viewModel.FlagStatuses;
        }

        private void BindTextBox(TextBox textBox, object dataSource, string dataMember)
        {
            textBox.DataBindings.Clear();
            textBox.DataBindings.Add("Text", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindDateTimePicker(DateTimePicker dateTimePicker, object dataSource, string dataMember)
        {
            dateTimePicker.DataBindings.Clear();
            dateTimePicker.DataBindings.Add("Value", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindComboBox(ComboBox comboBox, object dataSource, string dataMember)
        {
            comboBox.DataBindings.Clear();
            comboBox.DataBindings.Add("SelectedItem", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SubscribeToViewModelEvents()
        {
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            this.nurseListBox.DataSource = this.viewModel.Nurses;
            this.nurseListBox.DisplayMember = "FullName";

            this.stateComboBoxForNurse.DataSource = this.viewModel.States;
            this.statusComboBox.DataSource = this.viewModel.FlagStatuses;
        }

        private void ClearAllBoxes()
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.dateTimePickerForNurse.Value = DateTime.Now;
            this.phoneNumTextBox.Clear();
            this.idTextBox.Text = string.Empty;
            this.address1TextBox.Clear();
            this.zipTextBox.Clear();
            this.cityTextBox.Clear();
            this.stateComboBoxForNurse.SelectedIndex = -1;
            this.statusComboBox.SelectedIndex = -1;
            this.address2TextBox.Clear();
            this.usernameTextBox.Clear();
            this.passwordTextBox.Clear();
        }

        private void NurseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.nurseListBox.SelectedItem is Nurse)
            {
                this.unselectNurseButton.Enabled = true;
                this.statusComboBox.Enabled = true;
                this.editNurseButton.Enabled = true;
                this.deleteNurseBTN.Enabled = true;
                this.viewModel.SelectedNurse = (Nurse)this.nurseListBox.SelectedItem;

                this.BindTextBox(this.firstNameTextBox, this.viewModel, "FirstName");
                this.BindTextBox(this.lastNameTextBox, this.viewModel, "LastName");
                this.BindDateTimePicker(this.dateTimePickerForNurse, this.viewModel, "FormattedBirthDate");
                this.BindTextBox(this.phoneNumTextBox, this.viewModel, "PhoneNumber");
                this.BindTextBox(this.idTextBox, this.viewModel, "Nurse_Id");
                this.BindTextBox(this.usernameTextBox, this.viewModel, "Username");
                this.BindTextBox(this.passwordTextBox, this.viewModel, "Password");
                this.BindTextBox(this.address1TextBox, this.viewModel, "Address_1");
                this.BindTextBox(this.zipTextBox, this.viewModel, "Zip");
                this.BindTextBox(this.cityTextBox, this.viewModel, "City");
                this.BindComboBox(this.stateComboBoxForNurse, this.viewModel, "State");
                this.BindComboBox(this.statusComboBox, this.viewModel, "FlagStatus");
                this.BindTextBox(this.address2TextBox, this.viewModel, "Address_2");

                // Set edit mode to true and disable fields
                this.firstNameTextBox.Enabled = false;
                this.lastNameTextBox.Enabled = false;
                this.dateTimePickerForNurse.Enabled = false;

                if (this.viewModel.FlagStatus == null)
                {
                    this.statusComboBox.SelectedItem = null;
                }
            }
            else
            {
                this.statusComboBox.DataBindings.Clear();
                this.unselectNurseButton.Enabled = false;
                this.editNurseButton.Enabled = false;
                this.deleteNurseBTN.Enabled = false;
                this.viewModel.SelectedNurse = null!;
            }
        }

        private void editNurseButton_Click(object sender, EventArgs e)
        {
            var fname = this.firstNameTextBox.Text;
            var lname = this.lastNameTextBox.Text;
            var bDate = this.dateTimePickerForNurse.Value;
            var phoneNum = this.phoneNumTextBox.Text;
            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;
            var address1 = this.address1TextBox.Text;
            var zip = this.zipTextBox.Text;
            var city = this.cityTextBox.Text;
            var state = this.stateComboBoxForNurse.Text;
            var address2 = this.address2TextBox.Text;
            var isEditing = this.viewModel.SelectedNurse.Username.Equals(username);
            FlagStatus flag = (FlagStatus)this.statusComboBox.SelectedItem!;

            if (this.inputsValid(fname, lname, phoneNum, address1, city, zip, username, password, isEditing))
            {
                this.viewModel.Save(fname, lname, bDate, phoneNum, address1, zip, city, state, address2, username, password, flag);
                this.refreshListBox();
                MessageBox.Show("Nurse's Information Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An Error Occured While Editing Nurse's Information", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshListBox()
        {
            this.nurseListBox.DataSource = null;
            this.nurseListBox.DataSource = this.viewModel.Nurses;
            this.nurseListBox.DisplayMember = "FullName";
        }

        private void addNurseButton_Click(object sender, EventArgs e)
        {
            var fname = this.firstNameTextBox.Text;
            var lname = this.lastNameTextBox.Text;
            var bDate = this.dateTimePickerForNurse.Value;
            var phoneNum = this.phoneNumTextBox.Text;
            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;
            var address1 = this.address1TextBox.Text;
            var zip = this.zipTextBox.Text;
            var city = this.cityTextBox.Text;
            var state = this.stateComboBoxForNurse.Text;
            var address2 = this.address2TextBox.Text;
            FlagStatus flag = (FlagStatus)this.statusComboBox.SelectedItem!;

            if (this.inputsValid(fname, lname, phoneNum, address1, city, zip, username, password, false))
            {
                this.viewModel.Add(fname, lname, bDate, phoneNum, address1, zip, city, state, address2, username, password, flag);
                this.refreshListBox();
                this.nurseListBox.SelectedItem = this.viewModel.Nurses.Last();
                MessageBox.Show("Nurse Added Successfully In The System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An Error Occured While Adding Nurse To The System", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool inputsValid(string fname, string lname, string phoneNum, string address1, string city, string zip, string username, string password, bool isEditing)
        {
            this.errorMessages = string.Empty;
            bool isErrors = false;

            if (string.IsNullOrWhiteSpace(fname))
            {
                this.errorMessages += $"\n {ERROR_FIRST_NAME}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(lname))
            {
                this.errorMessages += $"\n {ERROR_LAST_NAME}";
                isErrors = true;
            }
            if (!Regex.IsMatch(phoneNum, PHONE_NUMBER_REGEX_PATTERN))
            {
                this.errorMessages += $"\n {ERROR_PHONE_NUMBER}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(address1))
            {
                this.errorMessages += $"\n {ERROR_ADDRESS_1}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                this.errorMessages += $"\n {ERROR_CITY}";
                isErrors = true;
            }
            if (this.stateComboBoxForNurse.SelectedItem == null)
            {
                this.errorMessages += $"\n {ERROR_STATE}";
                isErrors = true;
            }
            if (!Regex.IsMatch(zip, ZIP_REGEX_PATTERN))
            {
                this.errorMessages += $"\n {ERROR_ZIP}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                this.errorMessages += $"\n {ERROR_USERNAME}";
                isErrors = true;
            }
            if (!isEditing)
            {
                if (!this.viewModel.IsUsernameAvailable(username))
                {
                    this.errorMessages += $"\n {ERROR_USERNAME_TAKEN}";
                    isErrors = true;
                }
            }
            if (!Regex.IsMatch(password, PASSWORD_REGEX_PATTERN))
            {
                this.errorMessages += $"\n {ERROR_PASSWORD}";
                isErrors = true;
            }

            return !isErrors;
        }

        private void unselectNurseButton_Click(object sender, EventArgs e)
        {
            this.nurseListBox.SelectedIndex = -1;
            this.ClearAllBoxes();
            this.statusComboBox.SelectedIndex = 0;
            this.statusComboBox.Enabled = false;
            this.firstNameTextBox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.dateTimePickerForNurse.Enabled = true;

        }

        private void deleteNurseBTN_Click(object sender, EventArgs e)
        {
            if (this.nurseListBox.SelectedItem is not Nurse)
            {
                MessageBox.Show("Please select a nurse to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.viewModel.SelectedNurse != null)
            {
                if (this.viewModel.DeleteNurse())
                {
                    this.refreshListBox();
                    this.ClearAllBoxes();
                    MessageBox.Show($"Nurse {viewModel.SelectedNurse.FullName} Was Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (this.viewModel.SelectedNurse.FlagStatus == FlagStatus.INACTIVE)
                {
                    MessageBox.Show($"Nurse {viewModel.SelectedNurse.FullName} Could Not Be Deleted And Is Already Marked As Inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.viewModel.DeactivateNurse())
                    {
                        this.refreshListBox();
                        this.ClearAllBoxes();
                        MessageBox.Show($"Can't Delete Nurse {viewModel.SelectedNurse.FullName}, Nurse Marked As INACTIVE Instead", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
