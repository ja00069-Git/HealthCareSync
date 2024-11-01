using HealthCareSync.DAL;
using HealthCareSync.Models;

namespace HealthCareSync.Views
{
    public partial class ManageAppts : UserControl
    {
        private readonly AppointmentDAL appointmentDAL = new AppointmentDAL();
        private int currentAvailabilityId;

        public ManageAppts()
        {
            InitializeComponent();
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Scheduling an appointment and saving it in the database
        private void scheduleBTN_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            string patientName = patientNameTextBox.Text.Trim();
            string reason = reasonTextBox.Text.Trim();

            int patientId = appointmentDAL.GetPatientIdByName(patientName);
            if (patientId == 0)
            {
                SetELabel(patentNameErrorLabel, "Error: Patient not found.");
                return;
            }

            if (!TryGetSelectedTimeSlot(patientId, out var doctorId, out var appointmentDateTime, out var availabilityId)) return;

            CreateAppointment(patientId, doctorId, appointmentDateTime, reason, availabilityId);
            appointmentDAL.UpdateAvailabilityStatus(availabilityId, 1);
        }

        // Getting the selected time slot from the listbox
        private bool TryGetSelectedTimeSlot(int patientId, out int doctorId, out DateTime appointmentDateTime, out int availabilityId)
        {
            doctorId = 0;
            appointmentDateTime = DateTime.MinValue;
            availabilityId = 0;

            if (docsTimesListBox.SelectedItem == null)
            {
                SetELabel(generalErrorlLabel, "Error: Please select a time slot.");
                return false;
            }

            string? selectedTimeSlot = docsTimesListBox.SelectedItem.ToString();
            string? startTimeString = selectedTimeSlot?.Split(" | ")[1].Split(" - ")[0];

            if (!TimeSpan.TryParse(startTimeString, out TimeSpan startTime))
            {
                SetELabel(generalErrorlLabel, "Error: Invalid time slot format.");
                return false;
            }

            appointmentDateTime = monthCalendar.SelectionRange.Start.Date.Add(startTime);

            var selectedAvailability = appointmentDAL.GetAvailableTimeSlots(monthCalendar.SelectionRange.Start);
            var selectedSlot = selectedAvailability.Find(slot =>
                $"{monthCalendar.SelectionRange.Start:MM/dd/yyyy} | {slot.TimeSlot}" == selectedTimeSlot);

            if (selectedSlot.Equals(default) || !appointmentDAL.IsTimeSlotAvailable(patientId, selectedSlot.DoctorId, appointmentDateTime))
            {
                SetELabel(generalErrorlLabel, "Error: Time slot is not available.");
                return false;
            }

            doctorId = selectedSlot.DoctorId;
            availabilityId = selectedSlot.AvailabilityId;
            return true;
        }

        // Creating an appointment in the database
        private void CreateAppointment(int patientId, int doctorId, DateTime appointmentDateTime, string reason, int availabilityId)
        {
            Appointment newAppointment = new Appointment
            {
                PatientId = patientId,
                DoctorId = doctorId,
                DateTime = appointmentDateTime,
                Reason = reason
            };

            appointmentDAL.ScheduleAppointment(newAppointment, availabilityId);
            SetELabel(searchLabel, "Appointment scheduled successfully!", Color.Green);

            ClearInputs();
            PopulateAvailableTimeSlots(monthCalendar.SelectionRange.Start);
            PopulateAppointments();
        }

        // Setting the error label in the form
        private void SetELabel(Label label, string message, Color? color = null)
        {
            label.Text = message;
            label.ForeColor = color ?? Color.Red;
        }

        // Validating the input fields in the form
        private bool ValidateFields()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(appointmentTimeTextBox.Text) || string.IsNullOrEmpty(doctorsNameTextBox.Text))
            {
                SetELabel(generalErrorlLabel, "Error: Please select a time slot and doctor.");
                isValid = false;
            }
            if (string.IsNullOrEmpty(reasonTextBox.Text.Trim()))
            {
                SetELabel(reasonErrorLabel, "Error: Reason for appointment cannot be empty.");
                isValid = false;
            }
            if (string.IsNullOrEmpty(patientNameTextBox.Text.Trim()))
            {
                SetELabel(patentNameErrorLabel, "Error: Patient name cannot be empty.");
                isValid = false;
            }

            return isValid;
        }

        // Clearing the input fields in the form
        private void ClearInputs()
        {
            patientNameTextBox.Clear();
            reasonTextBox.Clear();
            doctorsNameTextBox.Clear();
            appointmentTimeTextBox.Clear();
            docsTimesListBox.ClearSelected();
            generalErrorlLabel.Text = "";
            reasonErrorLabel.Text = "";
            patentNameErrorLabel.Text = "";
        }

        // Searching for an appointment by patient name
        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchPatientName = searchTextBox.Text.Trim();
            if (string.IsNullOrEmpty(searchPatientName))
            {
                SetELabel(searchLabel, "Error: Enter a patient name to search.");
                return;
            }

            var appointments = appointmentDAL.GetAppointmentsByPatientName(searchPatientName);
            if (appointments == null || appointments.Count == 0)
            {
                SetELabel(searchLabel, "Error: No appointments found for this patient.");
                return;
            }

            var appointment = appointments[0];
            PopulateAppointmentDetails(appointment);

            appointmentsListBox.Items.Clear();
            appointmentsListBox.Items.Add($"{appointment.DateTime:MM/dd/yyyy hh:mm} with {appointment.DoctorName} | {appointment.PatientName}");
        }

        // Populating the appointment details in the form
        private void PopulateAppointmentDetails(Appointment appointment)
        {
            monthCalendar.SetDate(appointment.DateTime);
            doctorsNameTextBox.Text = appointment.DoctorName;
            appointmentTimeTextBox.Text = $"{appointment.DateTime:MM/dd/yyyy hh:mm tt}";
            reasonTextBox.Text = appointment.Reason;
            patientNameTextBox.Text = appointment.PatientName;
            currentAvailabilityId = appointmentDAL.GetAvailabilityId(appointment.DoctorId, appointment.DateTime);
        }

        // Editing an appointment from the database
        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (!IsAppointmentSelected()) return;

            var selectedAppointment = (Appointment?)appointmentsListBox.SelectedItem;

            if (selectedAppointment == null || !CanEditAppointment(selectedAppointment)) return;

            if (!ValidateFields()) return;

            if (!TryGetNewAppointmentDetails(selectedAppointment, out var doctorId, out var appointmentDateTime, out var newAvailabilityId)) return;

            int previousAvailabilityId = appointmentDAL.GetAvailabilityId(selectedAppointment.DoctorId, selectedAppointment.DateTime);
            UpdatePreviousAvailability(previousAvailabilityId);

            UpdateAppointment(selectedAppointment, doctorId, appointmentDateTime, newAvailabilityId);

            SetELabel(generalErrorlLabel, "Appointment updated successfully!", Color.Green);
            RefreshAppointments(newAvailabilityId);
        }

        // Checking if an appointment is selected in the listbox
        private bool IsAppointmentSelected()
        {
            if (appointmentsListBox.SelectedItem == null)
            {
                SetELabel(generalErrorlLabel, "Error: Select an appointment to edit.");
                return false;
            }
            return true;
        }

        // Checking if the selected appointment is in the past
        private bool CanEditAppointment(Appointment selectedAppointment)
        {
            if (selectedAppointment.DateTime <= DateTime.Now)
            {
                SetELabel(generalErrorlLabel, "Error: Cannot edit a past appointment.");
                return false;
            }
            return true;
        }

        // Getting the new appointment details from the form
        private bool TryGetNewAppointmentDetails(Appointment selectedAppointment, out int doctorId, out DateTime appointmentDateTime, out int newAvailabilityId)
        {
            doctorId = 0;
            appointmentDateTime = DateTime.MinValue;
            newAvailabilityId = 0;

            if (docsTimesListBox.SelectedItem == null)
            {
                SetELabel(generalErrorlLabel, "Error: Please select a time slot from the list.");
                return false;
            }

            if (!TryGetSelectedTimeSlot(selectedAppointment.PatientId, out doctorId, out appointmentDateTime, out newAvailabilityId))
            {
                SetELabel(generalErrorlLabel, "Error: Invalid selection in time slot.");
                return false;
            }

            return true;
        }

        // Updating the availability status in the database
        private void UpdatePreviousAvailability(int previousAvailabilityId)
        {
            if (previousAvailabilityId != 0)
            {
                appointmentDAL.UpdateAvailabilityStatus(previousAvailabilityId, 0);
            }
        }

        // Updating the appointment details in the database
        private void UpdateAppointment(Appointment selectedAppointment, int doctorId, DateTime appointmentDateTime, int newAvailabilityId)
        {
            selectedAppointment.Reason = reasonTextBox.Text.Trim();
            selectedAppointment.DoctorId = doctorId;
            selectedAppointment.DateTime = appointmentDateTime;

            appointmentDAL.UpdateAppointment(selectedAppointment, newAvailabilityId, appointmentDAL.GetAvailabilityId(selectedAppointment.DoctorId, selectedAppointment.DateTime));
            appointmentDAL.UpdateAvailabilityStatus(newAvailabilityId, 1);
        }

        private void RefreshAppointments(int newAvailabilityId)
        {
            currentAvailabilityId = newAvailabilityId;
            PopulateAppointments();
            ClearInputs();
        }

        // Clearing the search filter  
        private void clearBTN_Click(object sender, EventArgs e)
        {
            ClearInputs();
            PopulateAvailableTimeSlots(monthCalendar.SelectionRange.Start);
            PopulateAppointments();
            SetELabel(searchLabel, "Search cleared.", Color.Green);
        }

        // Populating the available time slots listbox and appointments listbox when the form loads
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionRange.Start;
            PopulateAvailableTimeSlots(selectedDate);
            PopulateAppointments();
            ClearInputs();
        }

        // Populating the available time slots listbox with available time slots for the selected date
        private void PopulateAvailableTimeSlots(DateTime date)
        {
            docsTimesListBox.Items.Clear();
            var timeSlots = appointmentDAL.GetAvailableTimeSlots(date);

            foreach (var slot in timeSlots)
            {
                string formattedTimeSlot = $"{date:MM/dd/yyyy} | {slot.TimeSlot}";
                docsTimesListBox.Items.Add(formattedTimeSlot);
            }
        }

        // Populating the appointments listbox with appointments for the selected date
        private void PopulateAppointments()
        {
            DateTime selectedDate = monthCalendar.SelectionRange.Start;
            var appointments = appointmentDAL.GetAppointmentsByDate(selectedDate);

            appointmentsListBox.Items.Clear();

            foreach (var appointment in appointments)
            {
                appointmentsListBox.Items.Add(appointment);
            }
        }

        // Selecting a time slot from the listbox and updating the details in the form
        private void docsTimesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (docsTimesListBox.SelectedItem != null)
            {
                string? selectedTimeSlot = docsTimesListBox.SelectedItem.ToString();

                var selectedAvailability = appointmentDAL.GetAvailableTimeSlots(monthCalendar.SelectionRange.Start);

                var selectedSlot = selectedAvailability.Find(slot =>
                    $"{monthCalendar.SelectionRange.Start:MM/dd/yyyy} | {slot.TimeSlot}" == selectedTimeSlot);

                if (selectedSlot != default)
                {
                    string doctorName = appointmentDAL.GetDoctorNameByAvailabilityId(selectedSlot.AvailabilityId);
                    doctorsNameTextBox.Text = doctorName;
                    appointmentTimeTextBox.Text = $"{monthCalendar.SelectionRange.Start:MM/dd/yyyy} | {selectedSlot.TimeSlot}";
                    currentAvailabilityId = selectedSlot.AvailabilityId;
                }
            }
        }

        // Selecting an appointment from the listbox and updating the details in the form
        private void appointmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appointmentsListBox.SelectedItem is Appointment selectedAppointment)
            {
                PopulateAppointmentDetails(selectedAppointment);
            }
            else
            {
                SetELabel(generalErrorlLabel, "Error: Could not retrieve appointment details.");
            }
        }

    }
}
