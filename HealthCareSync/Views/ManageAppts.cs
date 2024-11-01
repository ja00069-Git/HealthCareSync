using System;
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
            this.reasonTextBox.DataBindings.Add(new Binding("Text", viewModel, "Reason", true, DataSourceUpdateMode.OnPropertyChanged));
            this.monthCalendar.DataBindings.Add(new Binding("SelectionRange", viewModel, "SelectedDate", true, DataSourceUpdateMode.OnPropertyChanged));
            this.appointmentTimeTextBox.DataBindings.Add(new Binding("Text", viewModel, "AppointmentTime", true, DataSourceUpdateMode.OnPropertyChanged));

            // ListBox data source bindings
            this.appointmentsListBox.DataSource = viewModel.Appointments;
            this.appointmentsListBox.DisplayMember = "DisplayInfo";
            this.appointmentsListBox.ClearSelected();
            this.docsTimesListBox.DataSource = viewModel.AvailableTimeSlots;
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scheduleBTN_Click(object sender, EventArgs e)
        {
            // Call the ScheduleAppointment method in the ViewModel
           viewModel.ScheduleAppointment();
 
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            // Call the SearchAppointments method in the ViewModel
            viewModel.SearchAppointments();
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            // Call the EditAppointment method in the ViewModel
            viewModel.EditAppointment();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            // Clear search results and refresh available time slots
            viewModel.SelectedDate = monthCalendar.SelectionRange.Start;
            viewModel.LoadAppointments();
            viewModel.LoadAvailableTimeSlots();
            viewModel.ClearInputFields();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Update available time slots based on the selected date
            viewModel.SelectedDate = monthCalendar.SelectionRange.Start;
            viewModel.LoadAppointments();
            viewModel.LoadAvailableTimeSlots();
            viewModel.ClearInputFields();
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
            // Set the selected appointment in the ViewModel when an appointment is selected in the ListBox
            if (appointmentsListBox.SelectedItem is Appointment selectedAppointment)
            {
                viewModel.SelectedAppointment = selectedAppointment;
                viewModel.PopulateFieldsFromSelectedAppointment();
            }
        }
    }
}
