using System.Diagnostics;
using System.Text.RegularExpressions;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;

namespace HealthCareSync.Views
{
    public partial class ManageVisits : Form
    {
        private readonly string NUMBER_REGEX = @"^\d{1,3}$";
        private readonly string DECIMAL_NUMBER_REGEX = @"^\d{1,3}(\.\d{1,2})?$";
        private readonly string ERROR_SYSTOLIC = "Systolic must be a integer number less than 1000.";
        private readonly string ERROR_DIASTOLIC = "Diastolic must be a integer number less than 1000.";
        private readonly string ERROR_TEMP = "Temperature must be a integer number less than 1000.";
        private readonly string ERROR_WEIGHT = "Weight must be a number les than 1000 with at most 2 decimals.";
        private readonly string ERROR_HEIGHT = "Height must be a number less than 1000 with at most 2 decimals.";
        private readonly string ERROR_BPM = "BPM must be a integer number less than 1000";
        private readonly string ERROR_SYMPTOMS = "Symptoms cannot be empty";
        private readonly string nurseUserName = string.Empty;

        private string errorMessages = string.Empty;


        private ManageVisitsViewModel viewModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageVisits"/> class.
        /// </summary>
        public ManageVisits(string loggedInUserName)
        {
            InitializeComponent();
            this.viewModel = new ManageVisitsViewModel();
            this.nurseUserName = loggedInUserName;
            this.bindToViewModel();
            this.bindSearchElements();
        }

        private void updateButtonState(object sender, EventArgs e)
        {
            this.searchButton.Enabled = this.searchByNameCheckBox.Checked;
            this.resetSearchButton.Enabled = this.searchByNameCheckBox.Checked;
        }

        private void bindSearchElements()
        {
            this.searchFirstNameTextBox.DataBindings.Add("Enabled", this.searchByNameCheckBox, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);
            this.searchLastNameTextBox.DataBindings.Add("Enabled", this.searchByNameCheckBox, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);

            this.searchByNameCheckBox.CheckedChanged += this.updateButtonState!;
        }

        private void clearAllBoxes()
        {
            this.systolicTextBox.Clear();
            this.diastolicTextBox.Clear();
            this.temperatureTextBox.Clear();
            this.weightTextBox.Clear();
            this.heightTextBox.Clear();
            this.bpmTextBox.Clear();
            this.symptomsTextBox.Clear();
            this.searchFirstNameTextBox.Clear();
            this.searchLastNameTextBox.Clear();
            this.searchByNameCheckBox.Checked = false;
        }

        private void disableBoxes()
        {
            this.systolicTextBox.Enabled = false;
            this.diastolicTextBox.Enabled = false;
            this.temperatureTextBox.Enabled = false;
            this.weightTextBox.Enabled = false;
            this.heightTextBox.Enabled = false;
            this.bpmTextBox.Enabled = false;
            this.symptomsTextBox.Enabled = false;
            this.clearButton.Enabled = false;
            this.saveButton.Enabled = false;
        }

        private void enableBoxes()
        {
            this.systolicTextBox.Enabled = true;
            this.diastolicTextBox.Enabled = true;
            this.temperatureTextBox.Enabled = true;
            this.weightTextBox.Enabled = true;
            this.heightTextBox.Enabled = true;
            this.bpmTextBox.Enabled = true;
            this.symptomsTextBox.Enabled = true;
            this.clearButton.Enabled = true;
            this.saveButton.Enabled = true;
        }

        private void bindToViewModel()
        {
            this.visitsListBox.DataSource = this.viewModel.Visits;
            this.visitsListBox.DisplayMember = "AppointmentInformation";
        }

        private void bindTextBox(TextBox textBox, object dataSource, string dataMember)
        {
            textBox.DataBindings.Clear();
            textBox.DataBindings.Add("Text", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetSearchButton_Click(object sender, EventArgs e)
        {
            this.viewModel.SearchByName(string.Empty, string.Empty);
            this.visitsListBox.DataSource = this.viewModel.Visits;
            this.visitsListBox.DisplayMember = "AppointmentInformation";

            this.visitsListBox.SelectedIndex = -1;
            this.clearAllBoxes();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool nameChecked = this.searchByNameCheckBox.Checked;

            if (nameChecked)
            {
                if (this.viewModel.SearchByName(this.searchFirstNameTextBox.Text, this.searchLastNameTextBox.Text))
                {
                    this.visitsListBox.DataSource = this.viewModel.Visits;
                    this.visitsListBox.DisplayMember = "AppointmentInformation";
                }
                else
                {
                    MessageBox.Show("Could not find any appointments with the given name", "Appointment(s) not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void visitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nurseNameTextBox.Clear();

            if (visitsListBox.SelectedItem is Appointment)
            {
                this.viewModel.SelectedVisit = (Appointment)visitsListBox.SelectedItem;

                this.successLabel.Text = string.Empty;
                this.visitDateTimePicker.DataBindings.Clear();
                this.visitDateTimePicker.DataBindings.Add("Value", this.viewModel, "VisitDate", true, DataSourceUpdateMode.OnPropertyChanged);
                this.bindTextBox(this.appointmentIdTextBox, this.viewModel, "AppointmentId");

                bool isDuringVisit = Math.Abs((this.visitDateTimePicker.Value - DateTime.Now).TotalMinutes) <= 30;

                if (isDuringVisit)
                {
                    this.enableBoxes();
                }
                else
                {
                    this.disableBoxes();
                }

                if (this.viewModel.VisitHasRoutineChecksEntered)
                {
                    this.bindTextBox(this.systolicTextBox, this.viewModel, "SystolicReading");
                    this.bindTextBox(this.diastolicTextBox, this.viewModel, "DiastolicReading");
                    this.bindTextBox(this.temperatureTextBox, this.viewModel, "BodyTemperature");
                    this.bindTextBox(this.weightTextBox, this.viewModel, "Weight");
                    this.bindTextBox(this.heightTextBox, this.viewModel, "Height");
                    this.bindTextBox(this.bpmTextBox, this.viewModel, "BPM");
                    this.bindTextBox(this.symptomsTextBox, this.viewModel, "Symptoms");
                    this.bindTextBox(this.nurseNameTextBox, this.viewModel, "PerformingNurseName");
                }

            }
            else
            {
                this.clearAllBoxes();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.clearAllBoxes();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool isDuringVisit = Math.Abs((this.visitDateTimePicker.Value - DateTime.Now).TotalMinutes) <= 30;

            if (isDuringVisit)
            {
                var systolic = this.systolicTextBox.Text;
                var diastolic = this.diastolicTextBox.Text;
                var temp = this.temperatureTextBox.Text;
                var bpm = this.bpmTextBox.Text;
                var symptoms = this.symptomsTextBox.Text;
                var weight = this.weightTextBox.Text;
                var height = this.heightTextBox.Text;

                if (this.isInputsValid(systolic, diastolic, temp, bpm, symptoms, weight, height))
                {
                    bool isEditing = this.viewModel.SelectedVisitRoutineChecks != null;

                    if (isEditing)
                    {
                        this.viewModel.Edit(systolic, diastolic, temp, bpm, symptoms, weight, height, this.nurseUserName);
                        this.successLabel.Text = "Successfully edited Routine Checks";
                    }
                    else
                    {
                        this.viewModel.Save(systolic, diastolic, temp, bpm, symptoms, weight, height, this.nurseUserName);
                        this.successLabel.Text = "Successfully entered Routine Checks";
                    }
                }
                else
                {
                    MessageBox.Show(this.errorMessages, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isInputsValid(string systolic, string diastolic, string temp, string bpm, string symptoms, string weight, string height)
        {
            this.errorMessages = string.Empty;
            bool isErrors = false;

            if (!Regex.IsMatch(systolic, NUMBER_REGEX))
            {
                this.errorMessages += $"\n {ERROR_SYSTOLIC}";
                isErrors = true;
            }
            if (!Regex.IsMatch(diastolic, NUMBER_REGEX))
            {
                this.errorMessages += $"\n {ERROR_DIASTOLIC}";
                isErrors = true;
            }
            if (!Regex.IsMatch(temp, NUMBER_REGEX))
            {
                this.errorMessages += $"\n {ERROR_TEMP}";
                isErrors = true;
            }
            if (!Regex.IsMatch(bpm, NUMBER_REGEX))
            {
                this.errorMessages += $"\n {ERROR_BPM}";
                isErrors = true;
            }
            if (string.IsNullOrWhiteSpace(symptoms))
            {
                this.errorMessages += $"\n {ERROR_SYMPTOMS}";
                isErrors = true;
            }
            if (!Regex.IsMatch(weight, DECIMAL_NUMBER_REGEX))
            {
                this.errorMessages += $"\n {ERROR_WEIGHT}";
                isErrors = true;
            }
            if (!Regex.IsMatch(height, DECIMAL_NUMBER_REGEX))
            {
                this.errorMessages += $"\n {ERROR_HEIGHT}";
                isErrors = true;
            }

            return !isErrors;
        }

        private void ManageVisits_Load(object sender, EventArgs e)
        {
            this.visitsListBox.SelectedIndexChanged -= this.visitsListBox_SelectedIndexChanged;
            this.visitDateTimePicker.Value = DateTime.Now;
            this.visitsListBox.SelectedIndex = -1;
            this.disableBoxes();
            this.visitsListBox.SelectedIndexChanged += this.visitsListBox_SelectedIndexChanged;
        }
    }
}
