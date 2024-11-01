using HealthCareSync.DAL;
using HealthCareSync.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;

namespace HealthCareSync.ViewModels
{
    public class AppointmentViewModel : INotifyPropertyChanged
    {
        private readonly AppointmentDAL appointmentDAL = new AppointmentDAL();
        public event PropertyChangedEventHandler? PropertyChanged;

        // Error message properties
        private string generalErrorMessage = string.Empty;
        public string GeneralErrorMessage
        {
            get => generalErrorMessage;
            set { generalErrorMessage = value; OnPropertyChanged(nameof(GeneralErrorMessage)); }
        }

        private string patientNameErrorMessage = string.Empty;
        public string PatientNameErrorMessage
        {
            get => patientNameErrorMessage;
            set { patientNameErrorMessage = value; OnPropertyChanged(nameof(PatientNameErrorMessage)); }
        }

        private string reasonErrorMessage = string.Empty;
        public string ReasonErrorMessage
        {
            get => reasonErrorMessage;
            set { reasonErrorMessage = value; OnPropertyChanged(nameof(ReasonErrorMessage)); }
        }

        private string searchMessage = string.Empty;
        public string SearchMessage
        {
            get => searchMessage;
            set { searchMessage = value; OnPropertyChanged(nameof(SearchMessage)); }
        }

        // Appointment properties
        private string patientName = string.Empty;
        public string PatientName
        {
            get => patientName;
            set { patientName = value; OnPropertyChanged(nameof(PatientName)); }
        }

        private string doctorName = string.Empty;
        public string DoctorName
        {
            get => doctorName;
            set { doctorName = value; OnPropertyChanged(nameof(DoctorName)); }
        }

        private string appointmentTime = string.Empty;
        public string AppointmentTime
        {
            get => appointmentTime;
            set { appointmentTime = value; OnPropertyChanged(nameof(AppointmentTime)); }
        }

        private string reason = string.Empty;
        public string Reason
        {
            get => reason;
            set { reason = value; OnPropertyChanged(nameof(Reason)); }
        }

        private DateTime selectedDate;
        public DateTime SelectedDate
        {
            get => selectedDate;
            set
            {
                selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
                LoadAppointments();
                LoadAvailableTimeSlots();
            }
        }

        private string selectedTimeSlot = string.Empty;
        public string SelectedTimeSlot
        {
            get => selectedTimeSlot;
            set { selectedTimeSlot = value; OnPropertyChanged(nameof(SelectedTimeSlot)); }
        }

        public Appointment? SelectedAppointment { get; set; }

        private ObservableCollection<string> availableTimeSlots;
        public ObservableCollection<string> AvailableTimeSlots
        {
            get => availableTimeSlots;
            set { availableTimeSlots = value; OnPropertyChanged(nameof(AvailableTimeSlots)); }
        }

        private ObservableCollection<Appointment> appointments;

        public ObservableCollection<Appointment> Appointments
        {
            get => appointments;
            set { appointments = value; OnPropertyChanged(nameof(Appointments)); }
        }

        // Commands
        public ICommand ScheduleCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand SearchCommand { get; }

        public AppointmentViewModel()
        {
            ScheduleCommand = new RelayCommand(_ => ScheduleAppointment(), _ => CanExecuteSchedule());
            EditCommand = new RelayCommand(_ => EditAppointment(), _ => CanExecuteEdit());
            SearchCommand = new RelayCommand(_ => SearchAppointments());
            appointments = new ObservableCollection<Appointment>();
            availableTimeSlots = new ObservableCollection<string>();
            selectedDate = DateTime.Today;
            LoadAvailableTimeSlots();
            LoadAppointments();
        }

        private bool CanExecuteSchedule() => ValidateFields();

        private bool CanExecuteEdit() => SelectedAppointment != null && ValidateFields();

        public bool ScheduleAppointment()
        {
            if (!ValidateFields()) return false;

            int patientId = appointmentDAL.GetPatientIdByName(PatientName);
            if (patientId == 0)
            {
                PatientNameErrorMessage = "Patient not found.";
                return false;
            }

            if (!TryGetSelectedTimeSlot(patientId, out int doctorId, out DateTime appointmentDateTime, out int availabilityId)) return false;

            CreateAppointment(patientId, doctorId, appointmentDateTime, Reason, availabilityId);
            appointmentDAL.UpdateAvailabilityStatus(availabilityId, 0);

            GeneralErrorMessage = "Appointment scheduled successfully!";
            return true;
        }

        public void LoadAvailableTimeSlots()
        {
            var slots = appointmentDAL.GetAvailableTimeSlots(SelectedDate);
            AvailableTimeSlots.Clear();
            foreach (var slot in slots.Select(s => $"{s.TimeSlot} | {s.DoctorName}"))
            {
                AvailableTimeSlots.Add(slot);
                OnPropertyChanged(nameof(AvailableTimeSlots));
            }
        }

        public void LoadAppointments()
        {
            var appointments = appointmentDAL.GetAppointmentsByDate(SelectedDate);
            Appointments.Clear();
            foreach (var appointment in appointments)
            {
                Appointments.Add(appointment);
                OnPropertyChanged(nameof(Appointments));
            }
        }

        public void SearchAppointments()
        {
            if (string.IsNullOrEmpty(PatientName))
            {
                SearchMessage = "Please enter a patient name to search.";
                return;
            }

            var appointments = appointmentDAL.GetAppointmentsByPatientName(PatientName);
            if (!appointments.Any())
            {
                SearchMessage = "No appointments found.";
                return;
            }

            Appointments.Clear();
            foreach (var appointment in appointments)
            {
                Appointments.Add(appointment);
            }
            SearchMessage = $"{appointments.Count} appointments found.";
        }

        public void EditAppointment()
        {
            if (!IsAppointmentSelected() || !ValidateFields()) return;

            if (!TryGetNewAppointmentDetails(out int doctorId, out DateTime appointmentDateTime, out int newAvailabilityId))
            {
                GeneralErrorMessage = "Invalid time slot.";
                return;
            }

            int previousAvailabilityId = appointmentDAL.GetAvailabilityId(SelectedAppointment!.DoctorId, SelectedAppointment.DateTime);
            UpdatePreviousAvailability(previousAvailabilityId);
            UpdateAppointment(doctorId, appointmentDateTime, newAvailabilityId);
            LoadAppointments();
        }

        private void UpdateAppointment(int doctorId, DateTime appointmentDateTime, int newAvailabilityId)
        {
            if (SelectedAppointment == null) return;

            var updatedAppointment = new Appointment
            {
                AppointmentId = SelectedAppointment.AppointmentId,
                PatientId = SelectedAppointment.PatientId,
                DoctorId = doctorId,
                DateTime = appointmentDateTime,
                Reason = Reason,
                DoctorName = appointmentDAL.GetDoctorNameByAvailabilityId(newAvailabilityId),
                PatientName = PatientName
            };

            int previousAvailabilityId = appointmentDAL.GetAvailabilityId(SelectedAppointment.DoctorId, SelectedAppointment.DateTime);
            appointmentDAL.UpdateAppointment(updatedAppointment, newAvailabilityId, previousAvailabilityId);
            appointmentDAL.UpdateDoctorAvailability(previousAvailabilityId, newAvailabilityId);
        }

        private void UpdatePreviousAvailability(int previousAvailabilityId)
        {
            appointmentDAL.UpdateAvailabilityStatus(previousAvailabilityId, 0);
        }

        public void ClearSearchResults()
        {
            Appointments.Clear();
            SearchMessage = "Search results cleared.";
        }

        private bool TryGetNewAppointmentDetails(out int doctorId, out DateTime appointmentDateTime, out int newAvailabilityId)
        {
            doctorId = 0;
            appointmentDateTime = DateTime.MinValue;
            newAvailabilityId = 0;

            if (string.IsNullOrEmpty(SelectedTimeSlot))
            {
                GeneralErrorMessage = "Please select a time slot.";
                return false;
            }

            var timeSlotParts = SelectedTimeSlot.Split('|');
            if (timeSlotParts.Length != 2)
            {
                GeneralErrorMessage = "Invalid time slot format.";
                return false;
            }

            var timeSlot = timeSlotParts[0].Trim();
            var doctorName = timeSlotParts[1].Trim();

            doctorId = appointmentDAL.GetDoctorIdByName(doctorName);
            if (doctorId == 0)
            {
                GeneralErrorMessage = "Doctor not found.";
                return false;
            }

            if (!DateTime.TryParse($"{SelectedDate.ToShortDateString()} {timeSlot}", out appointmentDateTime))
            {
                GeneralErrorMessage = "Invalid date/time format.";
                return false;
            }

            newAvailabilityId = appointmentDAL.GetAvailabilityId(doctorId, appointmentDateTime);
            if (newAvailabilityId == 0)
            {
                GeneralErrorMessage = "Time slot not available.";
                return false;
            }

            return true;
        }

        public void PopulateFieldsFromSelectedAppointment()
        {
            if (SelectedAppointment != null)
            {
                PatientName = SelectedAppointment.PatientName ?? string.Empty;
                DoctorName = SelectedAppointment.DoctorName ?? string.Empty;
                Reason = SelectedAppointment.Reason ?? string.Empty;
                AppointmentTime = SelectedAppointment.DateTime.ToString("HH:mm");
            }
        }

        public void PopulateFieldsFromSelectedTimeSlot()
        {
            if (string.IsNullOrEmpty(SelectedTimeSlot)) return;

            // Split the SelectedTimeSlot to retrieve the time and doctor's name
            var timeSlotParts = SelectedTimeSlot.Split('|');
            if (timeSlotParts.Length != 2) return;

            var timePart = timeSlotParts[0].Trim(); // This is the timeslot (e.g., "10:00 - 10:30")
            var doctorNamePart = timeSlotParts[1].Trim(); // This is the doctor's name

            // Update DoctorName
            DoctorName = doctorNamePart;

            // Set the appointment time in the desired format "Date | timeslot"
            AppointmentTime = $"{SelectedDate:MM/dd/yyyy} | {timePart}"; // Combine date and time part

            // Set appointment time by combining SelectedDate with the parsed time
            if (DateTime.TryParse($"{SelectedDate.ToShortDateString()} {timePart}", out DateTime appointmentDateTime))
            {
                SelectedDate = appointmentDateTime;
            }
        }


        private bool ValidateFields()
        {
            bool isValid = true;

            // Clear previous error messages
            GeneralErrorMessage = string.Empty;
            PatientNameErrorMessage = string.Empty;
            ReasonErrorMessage = string.Empty;

            // Validate PatientName
            if (string.IsNullOrWhiteSpace(PatientName))
            {
                PatientNameErrorMessage = "Patient name is required.";
                isValid = false;
            }

            // Validate Reason
            if (string.IsNullOrWhiteSpace(Reason))
            {
                ReasonErrorMessage = "Reason for appointment is required.";
                isValid = false;
            }

            // Validate SelectedTimeSlot
            if (string.IsNullOrWhiteSpace(SelectedTimeSlot))
            {
                GeneralErrorMessage = "Please select a time slot.";
                isValid = false;
            }

            return isValid;
        }

        private bool TryGetSelectedTimeSlot(int patientId, out int doctorId, out DateTime appointmentDateTime, out int availabilityId)
        {
            doctorId = 0;
            appointmentDateTime = DateTime.MinValue;
            availabilityId = 0;

            // Ensure SelectedTimeSlot is not empty
            if (string.IsNullOrEmpty(SelectedTimeSlot))
            {
                GeneralErrorMessage = "Error: Please select a time slot.";
                return false;
            }

            // Split SelectedTimeSlot to retrieve time and doctor’s name
            var timeSlotParts = SelectedTimeSlot.Split('|');
            if (timeSlotParts.Length != 2)
            {
                GeneralErrorMessage = "Error: Invalid time slot format.";
                return false;
            }

            var timePart = timeSlotParts[0].Trim();        // e.g., "11:00 - 11:30"
            var doctorName = timeSlotParts[1].Trim();      // e.g., "Harley Davidson"

            // Retrieve DoctorId by name
            doctorId = appointmentDAL.GetDoctorIdByName(doctorName);
            if (doctorId == 0)
            {
                GeneralErrorMessage = $"Error: Doctor '{doctorName}' not found.";
                return false;
            }

            // Parse the starting time of the time slot
            var startTime = timePart.Split('-')[0].Trim(); // Get the start time of the slot
            if (!DateTime.TryParseExact($"{SelectedDate.ToShortDateString()} {startTime}", "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out appointmentDateTime))
            {
                GeneralErrorMessage = "Error: Invalid date/time format.";
                return false;
            }

            // Retrieve the AvailabilityId
            availabilityId = appointmentDAL.GetAvailabilityId(doctorId, appointmentDateTime);
            if (availabilityId == 0)
            {
                GeneralErrorMessage = "Time slot not available.";
                return false;
            }

            // Verify if the time slot is available
            if (!appointmentDAL.IsTimeSlotAvailable(patientId, doctorId, appointmentDateTime))
            {
                GeneralErrorMessage = "Time slot already booked.";
                return false;
            }

            return true;
        }



        private void CreateAppointment(int patientId, int doctorId, DateTime appointmentDateTime, string reason, int availabilityId)
        {
            var newAppointment = new Appointment
            {
                PatientId = patientId,
                DoctorId = doctorId,
                DateTime = appointmentDateTime,
                Reason = reason,
                DoctorName = appointmentDAL.GetDoctorNameByAvailabilityId(availabilityId),
                PatientName = PatientName
            };

            appointmentDAL.ScheduleAppointment(newAppointment, availabilityId);
            ClearInputFields();
            LoadAppointments();
            LoadAvailableTimeSlots();
        }

        private bool IsAppointmentSelected()
        {
            if (SelectedAppointment == null)
            {
                GeneralErrorMessage = "Select an appointment to edit.";
                return false;
            }
            return true;
        }

        private void RefreshAppointments()
        {
            OnPropertyChanged(nameof(Appointments));
        }

        private void RefreshAvailableTimeSlots()
        {
            OnPropertyChanged(nameof(AvailableTimeSlots));
        }

        public void ClearInputFields()
        {
            PatientName = string.Empty;
            DoctorName = string.Empty;
            Reason = string.Empty;
            SelectedTimeSlot = string.Empty;
            SelectedAppointment = null;
            GeneralErrorMessage = string.Empty;
            PatientNameErrorMessage = string.Empty;
            ReasonErrorMessage = string.Empty;
            SearchMessage = string.Empty;
        }

        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
