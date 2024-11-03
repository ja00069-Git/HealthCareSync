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

        /**
         * GeneralErrorMessage property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string GeneralErrorMessage
        {
            get => generalErrorMessage;
            set { generalErrorMessage = value; OnPropertyChanged(nameof(GeneralErrorMessage)); }
        }

        private string patientNameErrorMessage = string.Empty;

        /**
         * PatientNameErrorMessage property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string PatientNameErrorMessage
        {
            get => patientNameErrorMessage;
            set { patientNameErrorMessage = value; OnPropertyChanged(nameof(PatientNameErrorMessage)); }
        }

        private string reasonErrorMessage = string.Empty;

        /**
         * ReasonErrorMessage property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string ReasonErrorMessage
        {
            get => reasonErrorMessage;
            set { reasonErrorMessage = value; OnPropertyChanged(nameof(ReasonErrorMessage)); }
        }

        private string searchMessage = string.Empty;

        /**
         * SearchMessage property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string SearchMessage
        {
            get => searchMessage;
            set { searchMessage = value; OnPropertyChanged(nameof(SearchMessage)); }
        }

        // Appointment properties
        private string patientSearchName = string.Empty;

        /**
         * PatientSearchName property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string PatientSearchName
        {
            get => patientSearchName;
            set { patientSearchName = value; OnPropertyChanged(nameof(PatientSearchName)); }
        }

        private string patientName = string.Empty;

        /**
         * PatientName property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string PatientName
        {
            get => patientName;
            set { patientName = value; OnPropertyChanged(nameof(PatientName)); }
        }

        private string doctorName = string.Empty;

        /**
         * DoctorName property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string DoctorName
        {
            get => doctorName;
            set { doctorName = value; OnPropertyChanged(nameof(DoctorName)); }
        }

        private string appointmentTime = string.Empty;

        /**
         * AppointmentTime property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string AppointmentTime
        {
            get => appointmentTime;
            set { appointmentTime = value; OnPropertyChanged(nameof(AppointmentTime)); }
        }

        private string reason = string.Empty;

        /**
         * Reason property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string Reason
        {
            get => reason;
            set { reason = value; OnPropertyChanged(nameof(Reason)); }
        }

        private DateTime selectedDate;

        /**
         * SelectedDate property
         * @precondition none
         * @postcondition none
         * @return DateTime
         */
        public DateTime SelectedDate
        {
            get => selectedDate;
            set
            {
                selectedDate = value;
                OnPropertyChanged(nameof(SelectedDate));
            }
        }


        private string selectedTimeSlot = string.Empty;

        /**
         * SelectedTimeSlot property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string SelectedTimeSlot
        {
            get => selectedTimeSlot;
            set { selectedTimeSlot = value; OnPropertyChanged(nameof(SelectedTimeSlot)); }
        }

        /**
         * SelectedAppointment property
         * @precondition none
         * @postcondition none
         * @return Appointment
         */
        public Appointment? SelectedAppointment { get; set; }

        private ObservableCollection<string> availableTimeSlots;

        /**
         * AvailableTimeSlots property
         * @precondition none
         * @postcondition none
         * @return ObservableCollection<string>
         */
        public ObservableCollection<string> AvailableTimeSlots
        {
            get => availableTimeSlots;
            set { availableTimeSlots = value; OnPropertyChanged(nameof(AvailableTimeSlots)); }
        }

        private ObservableCollection<Appointment> appointments;

        /**
         * Appointments property
         * @precondition none
         * @postcondition none
         * @return ObservableCollection<Appointment>
         */
        public ObservableCollection<Appointment> Appointments
        {
            get => appointments;
            set { appointments = value; OnPropertyChanged(nameof(Appointments)); }
        }

        // Commands

        /**
         * ScheduleCommand property
         * @precondition none
         * @postcondition none
         * @return ICommand
         */
        public ICommand ScheduleCommand { get; }

        /**
         * EditCommand property
         * @precondition none
         * @postcondition none
         * @return ICommand
         */
        public ICommand EditCommand { get; }

        /**
         * SearchCommand property
         * @precondition none
         * @postcondition none
         * @return ICommand
         */
        public ICommand SearchCommand { get; }

        /**
         * AppointmentViewModel constructor
         * @precondition none
         * @postcondition none
         */
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

        /**
         * Shedules and appointment and update the database
         * @precondition none
         * @postcondition none
         * @return true if the appointment was scheduled successfully, false otherwise
         */

        public bool ScheduleAppointment()
        {
            if (!ValidateFields()) return false;

            int patientId = appointmentDAL.GetPatientIdByName(PatientName);
            if (patientId == 0)
            {
                PatientNameErrorMessage = "Error: Patient not found.";
                return false;
            }

            if (!TryGetSelectedTimeSlot(patientId, out int doctorId, out DateTime appointmentDateTime, out int availabilityId)) return false;

            CreateAppointment(patientId, doctorId, appointmentDateTime, Reason, availabilityId);
            GeneralErrorMessage = "Success: Appointment scheduled successfully!";
            return true;
        }

        /**
         * Load available time slots form the database into the AvailableTimeSlots collection
         * @precondition none
         * @postcondition none
         */
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

        /**
         * Load appointments form the database into the Appointments collection
         * @precondition none
         * @postcondition none
         */
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

        /**
         * Search the database for appointments by patient name
         * @precondition none
         * @postcondition none
         */
        public void SearchAppointments()
        {
            if (string.IsNullOrEmpty(PatientSearchName))
            {
                SearchMessage = "Error: Please enter a patient name to search.";
                return;
            }

            var appointments = appointmentDAL.GetAppointmentsByPatientName(PatientSearchName);
            if (!appointments.Any())
            {
                SearchMessage = "Error: No appointments found.";
                return;
            }

            Appointments = new ObservableCollection<Appointment>(appointments);
            SearchMessage = $"Success: {appointments.Count} appointments found.";
        }

        /**
         * Edit an appointment and update the database
         * @precondition none
         * @postcondition none
         */
        public void EditAppointment()
        {
            if (!canEditAppointment() || !IsAppointmentSelected() || !ValidateFields()) return;

            if (!TryGetNewAppointmentDetails(out int doctorId, out DateTime appointmentDateTime, out int newAvailabilityId)) return;

            int previousAvailabilityId = appointmentDAL.GetAvailabilityId(SelectedAppointment!.DoctorId, SelectedAppointment.DateTime);
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
        }

        private bool canEditAppointment()
        {
            if (SelectedAppointment?.DateTime > DateTime.Today)
            {
                GeneralErrorMessage = "Error: Can not edit appointment on the appointment day";
                return false;
            }
            return true;
        }

        private bool TryGetNewAppointmentDetails(out int doctorId, out DateTime appointmentDateTime, out int newAvailabilityId)
        {
            doctorId = 0;
            appointmentDateTime = DateTime.MinValue;
            newAvailabilityId = 0;

            if (string.IsNullOrEmpty(SelectedTimeSlot))
            {
                GeneralErrorMessage = "Error: Please select a time slot.";
                return false;
            }

            var timeSlotParts = SelectedTimeSlot.Split('|');
            if (timeSlotParts.Length != 2)
            {
                GeneralErrorMessage = "Error: Invalid time slot format.";
                return false;
            }

            var timeSlot = timeSlotParts[0].Trim();
            var doctorName = timeSlotParts[1].Trim();

            doctorId = appointmentDAL.GetDoctorIdByName(doctorName);
            if (doctorId == 0)
            {
                GeneralErrorMessage = "Error: Doctor not found.";
                return false;
            }

            var startTime = timeSlot.Split('-')[0].Trim();
            if (!DateTime.TryParseExact(startTime, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedTime))
            {
                GeneralErrorMessage = "Error: Invalid time format.";
                return false;
            }

            appointmentDateTime = new DateTime(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, parsedTime.Hour, parsedTime.Minute, 0);

            newAvailabilityId = appointmentDAL.GetAvailabilityId(doctorId, appointmentDateTime);
            if (newAvailabilityId == 0)
            {
                GeneralErrorMessage = "Error: Time slot not available.";
                return false;
            }

            return true;
        }

        /**
         * Populate the fields with the selected appointment details
         * @precondition none
         * @postcondition none
         */
        public void PopulateFieldsFromSelectedAppointment()
        {
            if (SelectedAppointment != null)
            {
                PatientName = SelectedAppointment.PatientName ?? string.Empty;
                DoctorName = SelectedAppointment.DoctorName ?? string.Empty;
                Reason = SelectedAppointment.Reason ?? string.Empty;
                AppointmentTime = $"{SelectedAppointment.DateTime:MM/dd/yyyy | HH:mm}";
            }
        }

        /**
         * Populate the fields with the selected time slot details
         * @precondition none
         * @postcondition none
         */
        public void PopulateFieldsFromSelectedTimeSlot()
        {
            if (string.IsNullOrEmpty(SelectedTimeSlot)) return;

            var timeSlotParts = SelectedTimeSlot.Split('|');
            if (timeSlotParts.Length != 2) return;

            var timePart = timeSlotParts[0].Trim();
            var doctorNamePart = timeSlotParts[1].Trim();

            DoctorName = doctorNamePart;

            AppointmentTime = $"{SelectedDate:MM/dd/yyyy} | {timePart}";

            if (DateTime.TryParse($"{SelectedDate.ToShortDateString()} {timePart}", out DateTime appointmentDateTime))
            {
                SelectedDate = appointmentDateTime;
            }
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            GeneralErrorMessage = string.Empty;
            PatientNameErrorMessage = string.Empty;
            ReasonErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(PatientName))
            {
                PatientNameErrorMessage = "Error: Patient name is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Reason))
            {
                ReasonErrorMessage = "Error: Reason for appointment is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(SelectedTimeSlot))
            {
                GeneralErrorMessage = "Error: Please select a time slot.";
                isValid = false;
            }

            return isValid;
        }

        private bool TryGetSelectedTimeSlot(int patientId, out int doctorId, out DateTime appointmentDateTime, out int availabilityId)
        {
            doctorId = 0;
            appointmentDateTime = DateTime.MinValue;
            availabilityId = 0;

            if (string.IsNullOrEmpty(SelectedTimeSlot))
            {
                GeneralErrorMessage = "Error: Please select a time slot.";
                return false;
            }

            var timeSlotParts = SelectedTimeSlot.Split('|');
            if (timeSlotParts.Length != 2)
            {
                GeneralErrorMessage = "Error: Invalid time slot format.";
                return false;
            }

            var timePart = timeSlotParts[0].Trim();    
            var doctorName = timeSlotParts[1].Trim();      

            doctorId = appointmentDAL.GetDoctorIdByName(doctorName);
            if (doctorId == 0)
            {
                GeneralErrorMessage = $"Error: Doctor '{doctorName}' not found.";
                return false;
            }

            var startTime = timePart.Split('-')[0].Trim();
            if (!DateTime.TryParseExact(startTime, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedTime))
            {
                GeneralErrorMessage = "Error: Invalid time format.";
                return false;
            }

            appointmentDateTime = new DateTime(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, parsedTime.Hour, parsedTime.Minute, 0);

            availabilityId = appointmentDAL.GetAvailabilityId(doctorId, appointmentDateTime);
            if (availabilityId == 0)
            {
                GeneralErrorMessage = "Error: Time slot not available.";
                return false;
            }

            if (!appointmentDAL.IsTimeSlotAvailable(patientId, doctorId, appointmentDateTime))
            {
                GeneralErrorMessage = "Error: Time slot already booked.";
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
                GeneralErrorMessage = "Error: Select an appointment to edit.";
                return false;
            }
            return true;
        }

        /**
         * Clear the input fields
         * @precondition none
         * @postcondition none
         */
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
            AppointmentTime = string.Empty;
        }

        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
