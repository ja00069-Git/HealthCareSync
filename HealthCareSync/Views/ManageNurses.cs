using HealthCareSync.Enums;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace HealthCareSync.Views
{
    public partial class ManageNurses : Form
    {
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

            // Disable buttons when the application first runs
            this.unselectNurseButton.Enabled = false;
            this.editNurseButton.Enabled = false;
            this.deleteNurseBTN.Enabled = false;
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
                this.BindTextBox(this.address1TextBox, this.viewModel, "Address_1");
                this.BindTextBox(this.zipTextBox, this.viewModel, "Zip");
                this.BindTextBox(this.cityTextBox, this.viewModel, "City");
                this.BindComboBox(this.stateComboBoxForNurse, this.viewModel, "State");
                this.BindComboBox(this.statusComboBox, this.viewModel, "FlagStatus");
                this.BindTextBox(this.address2TextBox, this.viewModel, "Address_2");

                // Set edit mode to true and disable fields
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
                this.passwordTextBox.Clear();
                MessageBox.Show("Nurse's Information Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this.errorMessages, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshListBox()
        {
            this.viewModel.LoadNursesFromDatabase();
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
                this.passwordTextBox.Clear();
                MessageBox.Show("Nurse Added Successfully In The System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this.errorMessages, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool inputsValid(string fname, string lname, string phoneNum, string address1, string city, string zip, string username, string password, bool isEditing)
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
            if (this.stateComboBoxForNurse.SelectedItem == null)
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
            if (!isEditing)
            {
                if (!this.viewModel.IsUsernameAvailable(username))
                {
                    this.errorMessages += $"\n {Constants.ERROR_USERNAME_TAKEN}";
                    isErrors = true;
                }
            }
            if (!Regex.IsMatch(password, Constants.PASSWORD_REGEX_PATTERN))
            {
                this.errorMessages += $"\n {Constants.ERROR_PASSWORD}";
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
                        MessageBox.Show($"Can't Delete Nurse {viewModel.SelectedNurse.FullName}, Nurse Marked As INACTIVE Instead", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            this.refreshListBox();
        }

    }
}
