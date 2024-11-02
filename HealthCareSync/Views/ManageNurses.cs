using HealthCareSync.Enums;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareSync.Views
{
    public partial class ManageNurses : Form
    {
        private readonly string PHONE_NUMBER_REGEX_PATTERN = @"^(?:\+?(\d{1,3})[-.\s]?)?(\(?\d{3}\)?[-.\s]?)?\d{3}[-.\s]?\d{4}$";
        private readonly string ZIP_REGEX_PATTERN = @"^\d{5}$";
        private readonly string BIRTH_DATE_REGEX_PATTERN = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/([0-9]{4})$";
        private readonly string ERROR_FIRST_NAME = "First name cannot be blank.";
        private readonly string ERROR_LAST_NAME = "Last name cannot be blank.";
        private readonly string ERROR_BIRTH_DATE = "Birth date must be in the format MM/dd/yyyy";
        private readonly string ERROR_PHONE_NUMBER = "Phone number must be 10 digits";
        private readonly string ERROR_PHONE_NUMBER_DASH = "Phone number must be 10 digits without dash";
        private readonly string ERROR_ADDRESS_1 = "Address 1 cannot be blank";
        private readonly string ERROR_ZIP = "Zip must be 5 digits";
        private readonly string ERROR_CITY = "Enter a city";
        private readonly string ERROR_STATE = "Select a state";

        private string errorMessages = string.Empty;

        private ManageNursesViewModel viewModel;
       
        public ManageNurses()
        {
            InitializeComponent();
            this.viewModel = new ManageNursesViewModel();
            
            this.bindToViewModel();
            this.ClearAllBoxes();
            this.nurseListBox.SelectedIndex = -1;
        }

        private void bindToViewModel()
        {
            this.nurseListBox.DataSource = this.viewModel.Nurses;
           
            this.nurseListBox.DisplayMember = "FullName";
            List<string> items = new List<string> { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
                                            "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
                                            "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
                                            "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
                                            "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            stateComboBoxForNurse.Items.AddRange(items.ToArray());

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
            comboBox.DataBindings.Add("SelectedValue", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void ClearAllBoxes()
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.dateTimePickerForNurse.Value = DateTime.Now;   //DateTimePicker
            this.phoneNumTextBox.Clear();
            this.idTextBox.Text = string.Empty;
            this.address1TextBox.Clear();
            this.zipTextBox.Clear();
            this.cityTextBox.Clear();
            this.stateComboBoxForNurse.SelectedIndex = -1;
            this.address2TextBox.Clear();
            this.usernameTextBox.Clear();
            this.passwordTextBox.Clear();
        }
        private void NurseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.nurseListBox.SelectedItem is Nurse)
            {
                this.deleteNurseButton.Enabled = true;
                this.unselectNurseButton.Enabled = true;
                this.saveNurseButton.Enabled = true;
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
                this.BindTextBox(this.address2TextBox, this.viewModel, "Address_2");
            }
            else
            {
                this.deleteNurseButton.Enabled = false;
                this.unselectNurseButton.Enabled = false;
                this.saveNurseButton.Enabled = false;
                this.viewModel.SelectedNurse = null!;
                ClearAllBoxes();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Text = string.Empty;

                var fname = this.firstNameTextBox.Text;
                var lname = this.lastNameTextBox.Text;
                var formattedBDate = this.dateTimePickerForNurse.Text;
                var phoneNum = this.phoneNumTextBox.Text;
                var username = this.usernameTextBox.Text;
                var address1 = this.address1TextBox.Text;
                var zip = this.zipTextBox.Text;
                var city = this.cityTextBox.Text;
                var state = this.stateComboBoxForNurse.Text;
                var address2 = this.address2TextBox.Text;

                if (this.inputsValid(fname, lname, formattedBDate, phoneNum, address1, zip))
                {
                    this.viewModel.Save(fname, lname, formattedBDate, phoneNum, address1, zip, city, state, address2, username);
                    this.refreshListBox();
                    this.errorLabel.ForeColor = Color.Green;
                    this.errorLabel.Text = "Successfully edited nurse";
                }
            }
            catch (Exception)
            {

                this.errorLabel.Text = "User doesn't exists.";
            }
        }
        private void refreshListBox()
        {
            this.nurseListBox.DataSource = null;
            this.nurseListBox.DataSource = this.viewModel.Nurses;
            this.nurseListBox.DisplayMember = "FullName";
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

            return !isErrors;
        }
        private bool otherAddressFieldsThanAddress1HasText()
        {
            return this.zipTextBox.Text.Trim().Length > 0 || this.cityTextBox.Text.Trim().Length > 0
                || this.stateComboBoxForNurse.Text.Trim().Length > 0 || this.address2TextBox.Text.Trim().Length > 0;
        }
        private bool otherAddressFieldsThanZipHasText()
        {
            return this.address1TextBox.Text.Trim().Length > 0 || this.cityTextBox.Text.Trim().Length > 0
                || this.stateComboBoxForNurse.Text.Trim().Length > 0 || this.address2TextBox.Text.Trim().Length > 0;
        }
        private void addNurseButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Text = string.Empty;

                var fname = this.firstNameTextBox.Text;
                var lname = this.lastNameTextBox.Text;
                var formattedBDate = this.dateTimePickerForNurse.Text;
                var phoneNum = this.phoneNumTextBox.Text;
                var username = this.usernameTextBox.Text;
                var address1 = this.address1TextBox.Text;
                var zip = this.zipTextBox.Text;
                var city = this.cityTextBox.Text;
                var state = this.stateComboBoxForNurse.Text;
                var address2 = this.address2TextBox.Text;


                if (this.inputsValid(fname, lname, formattedBDate, phoneNum, address1, zip))
                {


                    this.viewModel.Add(fname, lname, formattedBDate, phoneNum, address1, zip, city, state, address2, username);
                    this.refreshListBox();
                    this.nurseListBox.SelectedItem = this.viewModel.Nurses.Last();
                    this.errorLabel.ForeColor = Color.Green;
                    this.errorLabel.Text = "Successfully added nurse";

                }
            }
            catch (Exception)
            {

                this.errorLabel.Text = "User doesn't exists.";
            }


        }

        private void deleteNurseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete the selected murse?",
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
                this.errorLabel.Text = "Successfully deleted nurse";
            }
        }

        private void unselectNurseButton_Click(object sender, EventArgs e)
        {
            this.nurseListBox.SelectedIndex = -1;
            this.ClearAllBoxes();
            this.errorLabel.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
