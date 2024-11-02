using System.Diagnostics;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;

namespace HealthCareSync.Views
{
    public partial class ManageVisits : Form
    {
        private readonly string ERROR_SYSTOLIC = "Systolic must be a number up to 3 digits.";
        private readonly string ERROR_DIASTOLIC = "Diastolic must be a number up to 3 digits.";
        private readonly string ERROR_TEMP = "Temperature must be a number up to 3 digits.";
        private readonly string ERROR_WEIGHT = "Weight must be a number up to 3 digits.";
        private readonly string ERROR_HEIGHT = "Height must be a number up to 3 digits.";
        private readonly string ERROR_BPM = "BPM must be a number up to 3 digits";
        private readonly string ERROR_SYMPTOMS = "Symptoms cannot be empty";

        private string errorMessages = string.Empty;

        private ManageVisitsViewModel viewModel;

        public ManageVisits()
        {
            InitializeComponent();
            this.viewModel = new ManageVisitsViewModel();
            this.visitsListBox.SelectedIndex = -1;
            this.bindToViewModel();
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
        }

        private void bindToViewModel()
        {
            this.visitsListBox.DataSource = this.viewModel.Visits;
            this.visitsListBox.DisplayMember = "PatientName";
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

        private void visitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visitsListBox.SelectedItem is Appointment)
            {
                this.viewModel.SelectedVisit = (Appointment)visitsListBox.SelectedItem;

                this.visitDateTimePicker.DataBindings.Clear();
                this.visitDateTimePicker.DataBindings.Add("Value", this.viewModel, "VisitDate", true, DataSourceUpdateMode.OnPropertyChanged);
                this.bindTextBox(this.appointmentIdTextBox, this.viewModel, "AppointmentId");

                if (this.viewModel.VisitHasRoutineChecksEntered)
                {
                    this.bindTextBox(this.systolicTextBox, this.viewModel, "SystolicReading");
                    this.bindTextBox(this.diastolicTextBox, this.viewModel, "DiastolicReading");
                    this.bindTextBox(this.temperatureTextBox, this.viewModel, "BodyTemperature");
                    this.bindTextBox(this.weightTextBox, this.viewModel, "Weight");
                    this.bindTextBox(this.heightTextBox, this.viewModel, "Height");
                    this.bindTextBox(this.bpmTextBox, this.viewModel, "BPM");
                    this.bindTextBox(this.symptomsTextBox, this.viewModel, "Symptoms");
                    
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
            var appointment_id = this.appointmentIdTextBox.Text;
            var systolic_reading = this.systolicTextBox.Text;
            var diastolic_reading = this.diastolicTextBox.Text;
            var body_temperature = this.temperatureTextBox.Text;
            var pulse_bpm = this.bpmTextBox.Text;
            var symptoms = this.symptomsTextBox.Text;
            var weight  = this.weightTextBox.Text;
            var height = this.heightTextBox.Text;

            this.viewModel.Save(appointment_id, systolic_reading, diastolic_reading, body_temperature, pulse_bpm, symptoms, weight, height);
        }
    }
}
