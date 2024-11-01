using System;
using System.ComponentModel;
using System.Windows.Forms;
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
        }

        private void BindControls()
        {
            // Error message bindings
            this.generalErrorlLabel.DataBindings.Add(new Binding("Text", viewModel, "GeneralErrorMessage"));
            this.searchLabel.DataBindings.Add(new Binding("Text", viewModel, "SearchMessage"));
            this.patentNameErrorLabel.DataBindings.Add(new Binding("Text", viewModel, "PatientNameErrorMessage"));
            this.reasonErrorLabel.DataBindings.Add(new Binding("Text", viewModel, "ReasonErrorMessage"));

            // Field bindings
            this.patientNameTextBox.DataBindings.Add(new Binding("Text", viewModel, "PatientName", true, DataSourceUpdateMode.OnPropertyChanged));
            this.doctorsNameTextBox.DataBindings.Add(new Binding("Text", viewModel, "DoctorName", true, DataSourceUpdateMode.OnPropertyChanged));
            this.searchTextBox.DataBindings.Add(new Binding("Text", viewModel, "PatientSearchName", true, DataSourceUpdateMode.OnPropertyChanged));
            this.reasonTextBox.DataBindings.Add(new Binding("Text", viewModel, "Reason", true, DataSourceUpdateMode.OnPropertyChanged));
            this.monthCalendar.DataBindings.Add(new Binding("SelectionRange", viewModel, "SelectedDate", true, DataSourceUpdateMode.OnPropertyChanged));
            this.appointmentTimeTextBox.DataBindings.Add(new Binding("Text", viewModel, "AppointmentTime", true, DataSourceUpdateMode.OnPropertyChanged));

            // ListBox data source bindings
            this.appointmentsListBox.DataSource = viewModel.Appointments;
            this.appointmentsListBox.DisplayMember = "DisplayInfo";
            this.appointmentsListBox.ClearSelected();
            this.docsTimesListBox.DataSource = viewModel.AvailableTimeSlots;

            // Set initial colors
            SetLabelColors();
        }

        private void SubscribeToViewModelEvents()
        {
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(viewModel.Appointments) || e.PropertyName == nameof(viewModel.AvailableTimeSlots))
            {
                appointmentsListBox.DataSource = null;
                appointmentsListBox.DataSource = viewModel.Appointments;
                appointmentsListBox.DisplayMember = "DisplayInfo";

                docsTimesListBox.DataSource = null;
                docsTimesListBox.DataSource = viewModel.AvailableTimeSlots;
            }
            SetLabelColors();
        }

        private void SetLabelColors()
        {
            generalErrorlLabel.ForeColor = string.IsNullOrEmpty(viewModel.GeneralErrorMessage) ? Color.Red : Color.Green;
            searchLabel.ForeColor = string.IsNullOrEmpty(viewModel.SearchMessage) ? Color.Red : Color.Green;
            patentNameErrorLabel.ForeColor = string.IsNullOrEmpty(viewModel.PatientNameErrorMessage) ? Color.Red : Color.Green;
            reasonErrorLabel.ForeColor = string.IsNullOrEmpty(viewModel.ReasonErrorMessage) ? Color.Red : Color.Green;
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scheduleBTN_Click(object sender, EventArgs e)
        {
            viewModel.ScheduleAppointment();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            viewModel.SearchAppointments();
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            viewModel.EditAppointment();
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
        }

        private void docsTimesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (docsTimesListBox.SelectedItem != null)
            {
                viewModel.SelectedTimeSlot = docsTimesListBox.SelectedItem?.ToString() ?? string.Empty;
                viewModel.PopulateFieldsFromSelectedTimeSlot();
            }
        }

        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appointmentsListBox.SelectedItem != null)
            {
                viewModel.SelectedAppointment = (Appointment)appointmentsListBox.SelectedItem;
                viewModel.PopulateFieldsFromSelectedAppointment();
            }
        }
    }
}
