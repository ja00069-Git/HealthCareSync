using System.ComponentModel;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;

namespace HealthCareSync.Views
{

    public partial class ManageAppts : UserControl
    {
        private readonly AppointmentViewModel viewModel;

        public ManageAppts()
        {
            InitializeComponent();
            viewModel = new AppointmentViewModel();
            BindControls();
            SubscribeToViewModelEvents();
            ClearSelectionsAndResetFields();
        }

        private void BindControls()
        {
            // Error message bindings
            this.generalErrorlLabel.DataBindings.Add(new Binding("Text", viewModel, "GeneralErrorMessage"));
            this.searchPatientApptsLabel.DataBindings.Add(new Binding("Text", viewModel, "SearchPatientApptsMessage"));
            this.patentNameErrorLabel.DataBindings.Add(new Binding("Text", viewModel, "PatientNameErrorMessage"));
            this.reasonErrorLabel.DataBindings.Add(new Binding("Text", viewModel, "ReasonErrorMessage"));
            this.searchPatientErrorLabel.DataBindings.Add(new Binding("Text", viewModel, "SearchPatientMessage"));
            this.doctorsNameErrorLabel.DataBindings.Add(new Binding("Text", viewModel, "DoctorNameErrorMessage"));
            this.appointmentTimeErrorLabel.DataBindings.Add(new Binding("Text", viewModel, "AppointmentTimeErrorMessage"));

            // Field bindings
            this.patientNameTextBox.DataBindings.Add(new Binding("Text", viewModel, "PatientName", true, DataSourceUpdateMode.OnPropertyChanged));
            this.searchPatientTextBox.DataBindings.Add(new Binding("Text", viewModel, "SearchPatient", true, DataSourceUpdateMode.OnPropertyChanged));
            this.doctorsNameTextBox.DataBindings.Add(new Binding("Text", viewModel, "DoctorName", true, DataSourceUpdateMode.OnPropertyChanged));
            this.searchPatientApptsTextBox.DataBindings.Add(new Binding("Text", viewModel, "SearchPatientApptsByName", true, DataSourceUpdateMode.OnPropertyChanged));
            this.reasonTextBox.DataBindings.Add(new Binding("Text", viewModel, "Reason", true, DataSourceUpdateMode.OnPropertyChanged));
            this.monthCalendar.DataBindings.Add(new Binding("SelectionRange", viewModel, "SelectedDate", true, DataSourceUpdateMode.OnPropertyChanged));
            this.appointmentTimeTextBox.DataBindings.Add(new Binding("Text", viewModel, "AppointmentTime", true, DataSourceUpdateMode.OnPropertyChanged));
            this.availableTimesComboBox.DataBindings.Add(new Binding("Text", viewModel, "SelectedTimeSlot", true, DataSourceUpdateMode.OnPropertyChanged));
            this.availableDocsComboBox.DataBindings.Add(new Binding("Text", viewModel, "SelectedDoctor", true, DataSourceUpdateMode.OnPropertyChanged));

            // ListBox data source bindings
            this.appointmentsListBox.DataSource = viewModel.Appointments;
            this.appointmentsListBox.DisplayMember = "DisplayInfo";

            // ComboBox data source bindings
            availableDocsComboBox.DataBindings.Add(new Binding("DataSource", viewModel, "AvailableDoctors"));
            availableTimesComboBox.DataBindings.Add(new Binding("DataSource", viewModel, "AvailableTimeSlots"));

            // Ensure nothing is selected by default
            availableDocsComboBox.SelectedIndex = -1;
            availableTimesComboBox.SelectedIndex = -1;
        }

        private void SubscribeToViewModelEvents()
        {
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(viewModel.Appointments):
                    appointmentsListBox.DataSource = null;
                    appointmentsListBox.DataSource = viewModel.Appointments;
                    appointmentsListBox.DisplayMember = "DisplayInfo";
                    appointmentsListBox.ClearSelected();
                    break;
                case nameof(viewModel.AvailableTimeSlots):
                    availableTimesComboBox.DataSource = null;
                    availableTimesComboBox.DataSource = viewModel.AvailableTimeSlots;
                    availableTimesComboBox.SelectedIndex = -1;
                    break;
                case nameof(viewModel.AvailableDoctors):
                    availableDocsComboBox.DataSource = null;
                    availableDocsComboBox.DataSource = viewModel.AvailableDoctors;
                    availableDocsComboBox.SelectedIndex = -1;
                    break;
            }
            SetLabelColors();
        }

        private void ClearSelectionsAndResetFields()
        {
            appointmentsListBox.ClearSelected();
            availableTimesComboBox.SelectedIndex = -1;
            availableDocsComboBox.SelectedIndex = -1;
            this.patientNameErrorLabel.Text = string.Empty;
            viewModel.ClearInputFields();
        }

        private void SetLabelColors()
        {
            SetLabelColor(generalErrorlLabel, viewModel.GeneralErrorMessage);
            SetLabelColor(patentNameErrorLabel, viewModel.PatientNameErrorMessage);
            SetLabelColor(reasonErrorLabel, viewModel.ReasonErrorMessage);
            SetLabelColor(searchPatientApptsLabel, viewModel.SearchPatientApptsMessage);
            SetLabelColor(doctorsNameErrorLabel, viewModel.DoctorNameErrorMessage);
            SetLabelColor(appointmentTimeErrorLabel, viewModel.AppointmentTimeErrorMessage);
            SetLabelColor(searchPatientErrorLabel, viewModel.SearchPatientMessage);
        }

        private void SetLabelColor(Label label, string message)
        {
            label.ForeColor = message.Contains("Error") ? Color.Red : Color.Green;
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scheduleBTN_Click(object sender, EventArgs e)
        {
            viewModel.ScheduleAppointment();
            viewModel.LoadAvailableDoctors();
            viewModel.PatientName = string.Empty;
            viewModel.Reason = string.Empty;
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            viewModel.SearchAppointments();
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            viewModel.EditAppointment();
            viewModel.LoadAvailableDoctors();
            viewModel.PatientName = string.Empty;
            viewModel.Reason = string.Empty;
            patientNameErrorLabel.Text = string.Empty;  
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            viewModel.SelectedDate = monthCalendar.SelectionRange.Start;
            viewModel.LoadAppointments();
            viewModel.LoadAvailableTimeSlots();
            viewModel.ClearInputFields();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            viewModel.SelectedDate = monthCalendar.SelectionRange.Start;
            viewModel.LoadAppointments();
            viewModel.LoadAvailableDoctors();

            if (viewModel.Appointments.Count == 0)
            {
                appointmentsListBox.DataSource = null;
            }

            availableDocsComboBox.DataSource = null;
            if (viewModel.AvailableDoctors.Count > 0)
            {
                availableDocsComboBox.DataSource = viewModel.AvailableDoctors;
                availableDocsComboBox.SelectedIndex = -1;
            }

            viewModel.PatientName = string.Empty;
            viewModel.Reason = string.Empty;

        }

        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appointmentsListBox.SelectedItem != null)
            {
                viewModel.SelectedAppointment = (Appointment)appointmentsListBox.SelectedItem;
                viewModel.PopulateFieldsFromSelectedAppointment();
                patientNameTextBox.ReadOnly = true;
            }
            else
            {
                patientNameTextBox.ReadOnly = false;
            }
        }

        private void availableDocsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (availableDocsComboBox.SelectedItem != null)
            {
                viewModel.DoctorName = availableDocsComboBox.SelectedItem.ToString() ?? string.Empty;
                viewModel.LoadAvailableTimeSlots();
                viewModel.PopulateFieldsFromSelectedDocAndTimeSlot();
            }
            else
            {
                viewModel.AvailableTimeSlots.Clear();
                viewModel.AppointmentTime = string.Empty;
                viewModel.DoctorName = string.Empty;
            }

            availableTimesComboBox.DataSource = null;
            availableTimesComboBox.DataSource = viewModel.AvailableTimeSlots;
        }


        private void availableTimesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (availableTimesComboBox.SelectedItem != null)
            {
                viewModel.AppointmentTime = availableTimesComboBox.SelectedItem?.ToString() ?? string.Empty;
                viewModel.PopulateFieldsFromSelectedDocAndTimeSlot();
            }

        }

        private void searchPatientBTN_Click(object sender, EventArgs e)
        {
            if (!patientNameTextBox.ReadOnly)
            {
                viewModel.SearchForAPatient();
                this.searchPatientTextBox.Text = string.Empty;
            }
            else
            {
                this.patientNameErrorLabel.Text = "You can not eddit the patient name";
                this.searchPatientTextBox.Text = string.Empty;
                this.patientNameErrorLabel.ForeColor = Color.Red;
            }
        }
    
    }
}
