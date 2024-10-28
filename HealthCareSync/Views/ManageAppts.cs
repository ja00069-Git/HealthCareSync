using HealthCareSync.DAL;
using HealthCareSync.Models;

namespace HealthCareSync.Views
{
    public partial class ManageAppts : UserControl
    {
        private AppointmentDAL appointmentDAL = new AppointmentDAL();

        public ManageAppts()
        {
            InitializeComponent();
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scheduleBTN_Click(object sender, EventArgs e)
        {
            string patientName = patientNameTextBox.Text.Trim();
            string reason = reasonTextBox.Text.Trim();
            string doctorName = doctorsNameTextBox.Text.Trim();
            string appointmentTime = appointmentTimeTextBox.Text.Trim();

            if (string.IsNullOrEmpty(appointmentTime))
            {
                generalErrorlLabel.Text = "Error: Please select a time slot.";
                generalErrorlLabel.ForeColor = Color.Red;
                return;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                generalErrorlLabel.Text = "Error: Please select a time slot.";
                generalErrorlLabel.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(reason))
            {
                reasonErrorLabel.Text = "Error: Reason for appointment cannot be empty.";
                reasonErrorLabel.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(patientName))
            {
                patentNameErrorLabel.Text = "Error: Patient name cannot be empty.";
                patentNameErrorLabel.ForeColor = Color.Red;
                return;
            }



            int patientId = appointmentDAL.GetPatientIdByName(patientName);

            if (patientId == 0)
            {
                patentNameErrorLabel.Text = "Error: Patient not found.";
                patentNameErrorLabel.ForeColor = Color.Red;
                return;
            }

            if (docsTimesListBox.SelectedItem != null)
            {
                string? selectedTimeSlot = docsTimesListBox.SelectedItem.ToString();
                string? startTimeString = selectedTimeSlot?.Split(" | ")[1].Split(" - ")[0];

                if (TimeSpan.TryParse(startTimeString, out TimeSpan startTime))
                {
                    DateTime appointmentDateTime = monthCalendar.SelectionRange.Start.Date.Add(startTime);

                    var selectedAvailability = appointmentDAL.GetAvailableTimeSlots(monthCalendar.SelectionRange.Start);
                    var selectedSlot = selectedAvailability.Find(slot =>
                        $"{monthCalendar.SelectionRange.Start:MM/dd/yyyy} | {slot.TimeSlot}" == selectedTimeSlot);

                    if (selectedSlot != default)
                    {
                        if (!appointmentDAL.IsTimeSlotAvailable(patientId, selectedSlot.DoctorId, appointmentDateTime))
                        {
                            generalErrorlLabel.Text = "Error: Time slot is not available.";
                            generalErrorlLabel.ForeColor = Color.Red;
                            return;
                        }

                        Appointment newAppointment = new Appointment
                        {
                            PatientId = patientId,
                            DoctorId = selectedSlot.DoctorId, // Use DoctorId instead of AvailabilityId
                            DateTime = appointmentDateTime,
                            Reason = reason
                        };

                        appointmentDAL.ScheduleAppointment(newAppointment);
                        searchLabel.Text = "Appointment scheduled successfully!";
                        searchLabel.ForeColor = Color.Green;
                        ClearInputs();
                        PopulateAvailableTimeSlots(monthCalendar.SelectionRange.Start);
                    }
                }
            }
            else
            {
                generalErrorlLabel.Text = "Error: Please select a time slot.";
                generalErrorlLabel.ForeColor = Color.Red;
            }
        }


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


        private void EditBTN_Click(object sender, EventArgs e)
        {

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionRange.Start;
            PopulateAvailableTimeSlots(selectedDate);
            PopulateAppointments();
        }

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

        private void PopulateAppointments()
        {
            DateTime selectedDate = monthCalendar.SelectionRange.Start;
            var appointments = appointmentDAL.GetAppointmentsByDate(selectedDate);

            appointmentsListBox.Items.Clear();

            foreach (var appointment in appointments)
            {
                string formattedAppointment = $"{appointment.DateTime:MM/dd/yyyy hh:mm}  with " +
                    $"{appointment.DoctorName} | {appointment.PatientName}";
                appointmentsListBox.Items.Add(formattedAppointment);
            }
        }

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
                }
            }
        }

    }
}
