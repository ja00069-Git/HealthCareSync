using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace HealthCareSync.Views
{
    public partial class ManageVisits : Form
    {
        private static readonly string NUMBER_REGEX = @"^\d{1,3}$";
        private static readonly string DECIMAL_NUMBER_REGEX = @"^\d{1,3}(\.\d{1,2})?$";
        private static readonly string ERROR_SYSTOLIC = "Systolic must be a integer number less than 1000.";
        private static readonly string ERROR_DIASTOLIC = "Diastolic must be a integer number less than 1000.";
        private static readonly string ERROR_TEMP = "Temperature must be a number less than 1000 with at most 2 decimals.";
        private static readonly string ERROR_WEIGHT = "Weight must be a number les than 1000 with at most 2 decimals.";
        private static readonly string ERROR_HEIGHT = "Height must be a number less than 1000 with at most 2 decimals.";
        private static readonly string ERROR_BPM = "BPM must be a integer number less than 1000";
        private static readonly string ERROR_SYMPTOMS = "Symptoms cannot be empty";
        private static readonly string ERROR_TEST = "Cannot order same test on the same date and time, Please pick a new time.";
        private static readonly string ERROR_TEST_DATE = "Order date cannot be before current date.";
        private static readonly string ERROR_INITIAL_DIAGNOSES = "Initial Diagnoses cannot be empty.";
        private static readonly string ERROR_FINAL_DIAGNOSES = "Final Diagnoses cannot be empty.";
        private static readonly string ERROR_ORDERED_TEST = "Cannot delete ordered tests where results are already appended.";
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
            this.assignTests();
            this.setDefaultRadioBtnCheckedChanged();
            this.disableTextFieldValidations();
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void disableTextFieldValidations()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.CausesValidation = false;
                }
            }
        }

        private void enableLabTestBoxes()
        {

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox cb && cb.Tag is LabTest)
                {
                    cb.Enabled = true;
                }
            }

            this.orderTestDatePicker.Enabled = true;
            this.orderTestTimePicker.Enabled = true;
        }

        private void disableLabTestBoxes()
        {

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox cb && cb.Tag is LabTest)
                {
                    cb.Enabled = false;
                }
            }

            this.orderTestDatePicker.Enabled = false;
            this.orderTestTimePicker.Enabled = false;
        }

        private void setDefaultRadioBtnCheckedChanged()
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox cb && cb.Tag is LabTest)
                {
                    cb.CheckedChanged += (s, e) => bindAllOrderButton();
                }
            }
        }

        private void bindAllOrderButton()
        {
            bool anyChecked = false;

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox cb && cb.Tag is LabTest && cb.Checked)
                {
                    anyChecked = true;
                    break;
                }
            }

            this.order_test_button.Enabled = anyChecked;
        }

        private void updateSearchButtonState(object sender, EventArgs e)
        {
            this.searchButton.Enabled = this.searchByNameCheckBox.Checked;
            this.resetSearchButton.Enabled = this.searchByNameCheckBox.Checked;
        }

        private void bindSearchElements()
        {
            this.searchFirstNameTextBox.DataBindings.Add("Enabled", this.searchByNameCheckBox, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);
            this.searchLastNameTextBox.DataBindings.Add("Enabled", this.searchByNameCheckBox, "Checked", true, DataSourceUpdateMode.OnPropertyChanged);

            this.searchByNameCheckBox.CheckedChanged += this.updateSearchButtonState!;
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
            this.nurseNameTextBox.Clear();
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

        private void testsOrderedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.deleteButton.Enabled = true;

            if (this.testsOrderedListBox.SelectedItem is LabTestOperation)
            {
                this.viewModel.SelectedLabTestOperation = (LabTestOperation)this.testsOrderedListBox.SelectedItem;

                this.testsOrderedDatePicker.DataBindings.Clear();
                this.testsOrderedTimePicker.DataBindings.Clear();
                this.testsOrderedDatePicker.DataBindings.Add("Value", this.viewModel, "SelectedLabTestOperationDateTime", true, DataSourceUpdateMode.OnPropertyChanged);
                this.testsOrderedTimePicker.DataBindings.Add("Value", this.viewModel, "SelectedLabTestOperationDateTime", true, DataSourceUpdateMode.OnPropertyChanged);
            }

        }

        private void visitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nurseNameTextBox.Clear();

            if (visitsListBox.SelectedItem is Appointment)
            {
                this.viewModel.SelectedVisit = (Appointment)visitsListBox.SelectedItem;

                this.nurseNameTextBox.Text = this.viewModel.GetNurseWithUsername(this.nurseUserName);
                this.testsOrderedListBox.DataSource = this.viewModel.OrderedTests;
                this.testsOrderedListBox.DisplayMember = "LabTestName";
                if (this.testsOrderedListBox.SelectedItem == null)
                {
                    this.deleteButton.Enabled = false;
                }
                this.successLabel.Text = string.Empty;
                this.visitDateTimePicker.DataBindings.Clear();
                this.visitDateTimePicker.DataBindings.Add("Value", this.viewModel, "VisitDate", true, DataSourceUpdateMode.OnPropertyChanged);

                bool isDuringVisit = Math.Abs((this.visitDateTimePicker.Value - DateTime.Now).TotalMinutes) <= 30;

                if (isDuringVisit)
                {
                    this.enableBoxes();
                    this.enableLabTestBoxes();
                }
                else
                {
                    this.disableBoxes();
                    this.disableLabTestBoxes();
                    this.initialDiagnosesTextBox.Enabled = false;
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

                    this.bindTextBox(this.initialDiagnosesTextBox, this.viewModel, "SelectedVisitInitialDiagnoses");
                    this.bindTextBox(this.finalDiagnosesTextBox, this.viewModel, "SelectedVisitFinalDiagnoses");

                    if (isDuringVisit)
                    {
                        this.initialDiagnosesTextBox.Enabled = true;
                        this.initial_diagnoses_enter_btn.Enabled = true;
                    }
                    else
                    {
                        this.initialDiagnosesTextBox.Enabled = false;
                        this.initial_diagnoses_enter_btn.Enabled = false;
                    }

                    if (this.viewModel.FinalDiagnosesIsEntered)
                    {
                        this.finalDiagnosesTextBox.Enabled = false;
                        this.final_diagnosis_enter_btn.Enabled = false;
                        this.disableBoxes();
                        this.disableLabTestBoxes();
                        this.initialDiagnosesTextBox.Enabled = false;
                    }
                    else
                    {
                        this.finalDiagnosesTextBox.Enabled = true;
                        this.final_diagnosis_enter_btn.Enabled = true;
                    }
                }
                else
                {
                    this.finalDiagnosesTextBox.Enabled = false;
                    this.final_diagnosis_enter_btn.Enabled = false;
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

        private void initial_diagnoses_enter_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(initialDiagnosesTextBox.Text))
            {
                MessageBox.Show(ERROR_INITIAL_DIAGNOSES, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.viewModel.EnterDiagnoses(initialDiagnosesTextBox.Text.Trim(), finalDiagnosesTextBox.Text.Trim());
                MessageBox.Show("Initial Diagnoses successfully entered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void final_diagnosis_enter_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(finalDiagnosesTextBox.Text))
            {
                MessageBox.Show(ERROR_FINAL_DIAGNOSES, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to enter the Final Diagnoses?\nOnce entered all visit information associated with the patient is read-only, therefore cannot be changed", "Confirm Final Diagnoses", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.viewModel.EnterDiagnoses(initialDiagnosesTextBox.Text.Trim(), finalDiagnosesTextBox.Text.Trim());
                    this.finalDiagnosesTextBox.Enabled = false;
                    this.final_diagnosis_enter_btn.Enabled = false;
                    this.disableBoxes();
                    this.order_test_button.Enabled = false;
                    this.deleteButton.Enabled = false;
                    this.initial_diagnoses_enter_btn.Enabled = false;
                    this.disableLabTestBoxes();
                    this.initialDiagnosesTextBox.Enabled = false;
                    MessageBox.Show("Final Diagnoses successfully entered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
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
            if (!Regex.IsMatch(temp, DECIMAL_NUMBER_REGEX))
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
            this.testsOrderedListBox.SelectedIndex = -1;
            this.disableBoxes();
            this.disableLabTestBoxes();
            this.initial_diagnoses_enter_btn.Enabled = false;
            this.initialDiagnosesTextBox.Enabled = false;
            this.finalDiagnosesTextBox.Enabled = false;
            this.final_diagnosis_enter_btn.Enabled = false;
            this.clearAllBoxes();
            this.visitsListBox.SelectedIndexChanged += this.visitsListBox_SelectedIndexChanged;
        }

        private void assignTests()
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox cb)
                {
                    if (cb.Text.Contains("Test") || cb.Text.Contains("Panel"))
                    {
                        string labTestName = cb.Text.Substring(0, cb.Text.IndexOf("[")).Trim();
                        cb.Tag = this.viewModel.GetLabTest(labTestName);
                    }

                }
            }
        }

        private void order_test_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (this.isDateTimeBeforeCurrent(this.orderTestDatePicker.Value.Date + this.orderTestTimePicker.Value.TimeOfDay))
                {
                    MessageBox.Show(ERROR_TEST_DATE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedTests = (this.Controls.Cast<Control>().ToList()).Where(control => control is CheckBox cb && cb.Tag is LabTest && cb.Checked).Cast<CheckBox>();
                var selectedDate = this.orderTestDatePicker.Value.Date;
                var selectedTime = this.orderTestTimePicker.Value.TimeOfDay;
                var selectedDateTime = selectedDate + selectedTime;
                bool isSuccessful = this.viewModel.OrderTest(selectedTests, selectedDateTime);
                if (isSuccessful)
                {
                    this.visitsListBox_SelectedIndexChanged(this.visitsListBox, EventArgs.Empty);
                    MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ERROR_TEST, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Order cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isDateTimeBeforeCurrent(DateTime dt)
        {
            return dt < DateTime.Now;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the ordered test?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (this.viewModel.DeleteOrderedTest((LabTestOperation)this.testsOrderedListBox.SelectedItem!))
                {
                    this.visitsListBox_SelectedIndexChanged(this.visitsListBox, EventArgs.Empty);
                    MessageBox.Show("Successfully deleted ordered test.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ERROR_ORDERED_TEST, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
