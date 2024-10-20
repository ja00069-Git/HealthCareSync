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
        private readonly string ERROR_BIRTH_DATE = "Birth date must be in the format MM/dd/yyyy";
        private readonly string ERROR_PHONE_NUMBER = "Phone number must be 10 digits";
        private readonly string ERROR_ADDRESS_1 = "Address 1 cannot be blank";
        private readonly string ERROR_ZIP = "Zip must be 5 digits";

        private ManagePatientsViewModel viewModel;


        public Manage_Patients()
        {
            InitializeComponent();
            this.viewModel = new ManagePatientsViewModel();

            this.BindToViewModel();
            this.ClearAllBoxes();
            this.patientListBox.SelectedIndex = -1;
            this.flagStatusComboBox.SelectedIndex = -1;
            this.stateComboBox.SelectedIndex = -1;
        }

        private void BindToViewModel()
        {
            this.patientListBox.DataSource = this.viewModel.Patients;
            this.patientListBox.DisplayMember = "FullName";
            this.flagStatusComboBox.DataSource = this.viewModel.FlagStatuses;
            this.stateComboBox.DataSource = this.viewModel.States;
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
            this.birthDateTextBox.Clear();
            this.phoneNumberTextBox.Clear();
            this.idTextBox.Text = string.Empty;
            this.address1TextBox.Clear();
            this.zipTextBox.Clear();
            this.cityTextBox.Clear();
            this.stateComboBox.SelectedIndex = -1;
            this.address2TextBox.Clear();
            this.flagStatusComboBox.SelectedIndex = -1;
        }

        private void PatientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errorLabel.Text = string.Empty;

            if (this.patientListBox.SelectedItem is Patient)
            {
                this.deleteButton.Enabled = true;
                this.unselectButton.Enabled = true;
                this.saveButton.Enabled = true;
                this.viewModel.SelectedPatient = (Patient)this.patientListBox.SelectedItem;

                this.BindTextBox(this.firstNameTextBox, this.viewModel, "FirstName");
                this.BindTextBox(this.lastNameTextBox, this.viewModel, "LastName");
                this.BindTextBox(this.birthDateTextBox, this.viewModel, "FormattedBirthDate");
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
                this.deleteButton.Enabled = false;
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
            var formattedBDate = this.birthDateTextBox.Text;
            var phoneNum = this.phoneNumberTextBox.Text;
            var address1 = this.address1TextBox.Text;
            var zip = this.zipTextBox.Text;
            var city = this.cityTextBox.Text;
            State? state = (State?)this.stateComboBox.SelectedItem;
            var address2 = this.address2TextBox.Text;
            FlagStatus? flag = (FlagStatus?)this.flagStatusComboBox.SelectedItem;

            if (this.inputsValid(fname, lname, formattedBDate, phoneNum, address1, zip))
            {
                this.viewModel.Save(fname, lname, formattedBDate, phoneNum, address1, zip, city, state, address2, flag);
                this.refreshListBox();
                this.errorLabel.ForeColor = Color.Green;
                this.errorLabel.Text = "Successfully edited patient";
            }
        }

        private void refreshListBox()
        {
            this.patientListBox.DataSource = null;
            this.patientListBox.DataSource = this.viewModel.Patients;
            this.patientListBox.DisplayMember = "FullName";
        }

        private bool inputsValid(string fname, string lname, string formattedBDate, string phoneNum, string address1, string zip)
        {
            if (string.IsNullOrWhiteSpace(fname))
            {
                this.errorLabel.Text = ERROR_FIRST_NAME;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lname))
            {
                this.errorLabel.Text = ERROR_LAST_NAME;
                return false;
            }
            else if (!Regex.IsMatch(formattedBDate, BIRTH_DATE_REGEX_PATTERN))
            {
                this.errorLabel.Text = ERROR_BIRTH_DATE;
                return false;
            }
            else if (phoneNum.Trim().Length > 0 && !Regex.IsMatch(phoneNum, PHONE_NUMBER_REGEX_PATTERN))
            {
                this.errorLabel.Text = ERROR_PHONE_NUMBER;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(address1) && this.otherAddressFieldsThanAddress1HasText())
            {
                this.errorLabel.Text = ERROR_ADDRESS_1;
                return false;
            }
            else if ((string.IsNullOrWhiteSpace(zip) || !Regex.IsMatch(zip, ZIP_REGEX_PATTERN)) && this.otherAddressFieldsThanZipHasText())
            {
                this.errorLabel.Text = ERROR_ZIP;
                return false;
            }

            return true;
        }

        private bool otherAddressFieldsThanAddress1HasText()
        {
            return this.zipTextBox.Text.Trim().Length > 0 || this.cityTextBox.Text.Trim().Length > 0
                || this.stateComboBox.SelectedItem != null || this.address2TextBox.Text.Trim().Length > 0;
        }
        private bool otherAddressFieldsThanZipHasText()
        {
            return this.address1TextBox.Text.Trim().Length > 0 || this.cityTextBox.Text.Trim().Length > 0
                || this.stateComboBox.SelectedItem != null || this.address2TextBox.Text.Trim().Length > 0;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete the selected patient?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                this.viewModel.Delete();
                this.ClearAllBoxes();
                this.refreshListBox();
                this.errorLabel.ForeColor = Color.Green;
                this.errorLabel.Text = "Successfully deleted patient";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.errorLabel.ForeColor = Color.Red;
            this.errorLabel.Text = string.Empty;

            var fname = this.firstNameTextBox.Text;
            var lname = this.lastNameTextBox.Text;
            var formattedBDate = this.birthDateTextBox.Text;
            var phoneNum = this.phoneNumberTextBox.Text;
            var address1 = this.address1TextBox.Text;
            var zip = this.zipTextBox.Text;
            var city = this.cityTextBox.Text;
            State? state = (State?)this.stateComboBox.SelectedItem;
            var address2 = this.address2TextBox.Text;
            FlagStatus? flag = (FlagStatus?)this.flagStatusComboBox.SelectedItem;

            if (this.inputsValid(fname, lname, formattedBDate, phoneNum, address1, zip))
            {
                this.viewModel.Add(fname, lname, formattedBDate, phoneNum, address1, zip, city, state, address2, flag);
                this.refreshListBox();
                this.patientListBox.SelectedItem = this.viewModel.Patients.Last();
                this.errorLabel.ForeColor = Color.Green;
                this.errorLabel.Text = "Successfully added patient";
            }
        }

        private void unselectButton_Click(object sender, EventArgs e)
        {
            this.patientListBox.SelectedIndex = -1;
            this.ClearAllBoxes();
            this.errorLabel.Text = string.Empty;
        }
    }
}
