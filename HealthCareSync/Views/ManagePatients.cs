using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HealthCareSync.Enums;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;

namespace HealthCareSync.Views
{
    public partial class Manage_Patients : Form
    {
        private readonly string PHONE_NUMBER_REGEX_PATTERN = @"^\d{10}$";
        private readonly string ZIP_REGEX_PATTERN = @"^\d{5}$";
        private readonly string BIRTH_DATE_REGEX_PATTERN = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/([0-9]{4})$";
        private readonly string ERROR_FIRST_NAME = "First name cannot be blank.";
        private readonly string ERROR_LAST_NAME = "Last name cannot be blank.";
        private readonly string ERROR_PHONE_NUMBER = "Phone number must be 10 digits";
        private readonly string ERROR_ADDRESS_1 = "Address 1 cannot be blank";
        private readonly string ERROR_ZIP = "Zip must be 5 digits";
        private readonly string ERROR_GENDER = "Must select a gender";
        private readonly string ERROR_CITY = "Enter a city";
        private readonly string ERROR_STATE = "Select a state";

        private string errorMessages = string.Empty;

        private ManagePatientsViewModel viewModel;


        public Manage_Patients()
        {
            InitializeComponent();
            this.viewModel = new ManagePatientsViewModel();

            this.BindToViewModel();
            this.ClearAllBoxes();
            this.SetupBirthDateTimePicker();
            this.patientListBox.SelectedIndex = -1;
            this.flagStatusComboBox.Enabled = false;
            this.errorMessages = string.Empty;
        }

        private void SetupBirthDateTimePicker()
        {
            this.birthDateTimePicker.MaxDate = DateTime.Today;
        }

        private void BindToViewModel()
        {
            this.patientListBox.DataSource = this.viewModel.Patients;
            this.patientListBox.DisplayMember = "FullName";
            this.flagStatusComboBox.DataSource = this.viewModel.FlagStatuses;
            this.stateComboBox.DataSource = this.viewModel.States;
            this.genderComboBox.DataSource = this.viewModel.Genders;
        }

        private void BindTextBox(TextBox textBox, object dataSource, string dataMember)
        {
            textBox.DataBindings.Clear();
            textBox.DataBindings.Add("Text", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ClearAllBoxes()
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.birthDateTimePicker.Value = DateTime.Today;
            this.phoneNumberTextBox.Clear();
            this.idTextBox.Text = string.Empty;
            this.address1TextBox.Clear();
            this.zipTextBox.Clear();
            this.cityTextBox.Clear();
            this.stateComboBox.SelectedIndex = -1;
            this.address2TextBox.Clear();
            this.genderComboBox.SelectedIndex = -1;
        }

        private void PatientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errorLabel.Text = string.Empty;

            if (this.patientListBox.SelectedItem is Patient)
            {
                this.unselectButton.Enabled = true;
                this.saveButton.Enabled = true;
                this.flagStatusComboBox.Enabled = true;
                this.viewModel.SelectedPatient = (Patient)this.patientListBox.SelectedItem;

                this.BindTextBox(this.firstNameTextBox, this.viewModel, "FirstName");
                this.BindTextBox(this.lastNameTextBox, this.viewModel, "LastName");
                this.birthDateTimePicker.DataBindings.Clear();
                this.birthDateTimePicker.DataBindings.Add("Value", this.viewModel, "BirthDate", true, DataSourceUpdateMode.OnPropertyChanged);
                this.BindTextBox(this.phoneNumberTextBox, this.viewModel, "PhoneNumber");
                this.BindTextBox(this.idTextBox, this.viewModel, "Patient_Id");
                this.flagStatusComboBox.DataBindings.Clear();
                this.flagStatusComboBox.DataBindings.Add("SelectedItem", this.viewModel, "FlagStatus", true, DataSourceUpdateMode.OnPropertyChanged);
                this.BindTextBox(this.address1TextBox, this.viewModel, "Address_1");
                this.BindTextBox(this.zipTextBox, this.viewModel, "Zip");
                this.BindTextBox(this.cityTextBox, this.viewModel, "City");
                this.stateComboBox.DataBindings.Clear();
                this.stateComboBox.DataBindings.Add("SelectedItem", this.viewModel, "State", true, DataSourceUpdateMode.OnPropertyChanged);
                this.BindTextBox(this.address2TextBox, this.viewModel, "Address_2");
                this.genderComboBox.DataBindings.Clear();
                this.genderComboBox.DataBindings.Add("SelectedItem", this.viewModel, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

                if (this.viewModel.FlagStatus == null)
                {
                    this.flagStatusComboBox.SelectedItem = null;
                }
                if (this.viewModel.Patient_Id == 0)
                {
                    this.idTextBox.Text = string.Empty;
                }
            }
            else
            {
                this.flagStatusComboBox.DataBindings.Clear();
                this.unselectButton.Enabled = false;
                this.saveButton.Enabled = false;
                this.viewModel.SelectedPatient = null!;
                ClearAllBoxes();
            }
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.errorLabel.ForeColor = Color.Red;
            this.errorLabel.Text = string.Empty;

            var fname = this.firstNameTextBox.Text;
            var lname = this.lastNameTextBox.Text;
            var bDate = this.birthDateTimePicker.Value;
            var phoneNum = this.phoneNumberTextBox.Text;
            var address1 = this.address1TextBox.Text;
            var zip = this.zipTextBox.Text;
            var city = this.cityTextBox.Text;
            var address2 = this.address2TextBox.Text;
            FlagStatus flag = (FlagStatus)this.flagStatusComboBox.SelectedItem!;

            if (this.inputsValid(fname, lname, phoneNum, address1, city, zip))
            {
                Gender gender = (Gender)this.genderComboBox.SelectedItem!;
                State state = (State)this.stateComboBox.SelectedItem!;
                this.viewModel.Save(fname, lname, bDate, gender, phoneNum, address1, zip, city, state, address2, flag);
                this.refreshListBox();
                this.errorLabel.ForeColor = Color.Green;
                this.errorLabel.Text = "Successfully edited patient";
            }
            else
            {
                MessageBox.Show(this.errorMessages, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.errorLabel.ForeColor = Color.Red;
            this.errorLabel.Text = string.Empty;

            var fname = this.firstNameTextBox.Text;
            var lname = this.lastNameTextBox.Text;
            var bDate = this.birthDateTimePicker.Value;
            var phoneNum = this.phoneNumberTextBox.Text;
            var address1 = this.address1TextBox.Text;
            var zip = this.zipTextBox.Text;
            var city = this.cityTextBox.Text;
            var address2 = this.address2TextBox.Text;
            FlagStatus flag = (FlagStatus)this.flagStatusComboBox.SelectedItem!;

            if (this.inputsValid(fname, lname, phoneNum, address1, city, zip))
            {
                Gender gender = (Gender)this.genderComboBox.SelectedItem!;
                State state = (State)this.stateComboBox.SelectedItem!;
                this.viewModel.Add(fname, lname, bDate, gender, phoneNum, address1, zip, city, state, address2, flag);
                this.refreshListBox();
                this.patientListBox.SelectedItem = this.viewModel.Patients.Last();
                this.errorLabel.ForeColor = Color.Green;
                this.errorLabel.Text = "Successfully added patient";
            }
            else
            {
                MessageBox.Show(this.errorMessages, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void unselectButton_Click(object sender, EventArgs e)
        {
            this.patientListBox.SelectedIndex = -1; 
            this.flagStatusComboBox.SelectedIndex = 0;
            this.flagStatusComboBox.Enabled = false;
            this.ClearAllBoxes();
            this.errorLabel.Text = string.Empty;
        }

        private void refreshListBox()
        {
            this.patientListBox.DataSource = null;
            this.patientListBox.DataSource = this.viewModel.Patients;
            this.patientListBox.DisplayMember = "FullName";
        }

        private bool inputsValid(string fname, string lname, string phoneNum, string address1, string city, string zip)
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
            if (this.genderComboBox.SelectedItem == null)
            {
                this.errorMessages += $"\n {ERROR_GENDER}";
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
            if (this.stateComboBox.SelectedItem == null)
            {
                this.errorMessages += $"\n {ERROR_STATE}";
                isErrors = true;
            }
            if (!Regex.IsMatch(zip, ZIP_REGEX_PATTERN))
            {
                this.errorMessages += $"\n {ERROR_ZIP}";
                isErrors = true;
            }

            return !isErrors;
        }
    }
}
