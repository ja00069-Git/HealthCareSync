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

        public event EventHandler<string>? ErrorMessageRaised;
        public event EventHandler<string>? SuccessMessageRaised;

        protected virtual void OnErrorMessageRaised(string message)
        {
            ErrorMessageRaised?.Invoke(this, message);
        }

        protected virtual void OnSuccessMessageRaised(string message)
        {
            SuccessMessageRaised?.Invoke(this, message);
        }

        // Appointment properties
        private string searchPatientApptsByName = string.Empty;

        /**
         * SearchPatientApptsByName property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string SearchPatientApptsByName
        {
            get => searchPatientApptsByName;
            set { searchPatientApptsByName = value; OnPropertyChanged(nameof(SearchPatientApptsByName)); }
        }

        private string searchPatient = string.Empty;

        public string SearchPatient
        {
            get => searchPatient;
            set { searchPatient = value; OnPropertyChanged(nameof(SearchPatient)); }
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

        private string selectedDoctor = string.Empty;

        /**
         * SelectedDoctor property
         * @precondition none
         * @postcondition none
         * @return string
         */
        public string SelectedDoctor
        {
            get => selectedDoctor;
            set
            {
                selectedDoctor = value;
                OnPropertyChanged(nameof(SelectedDoctor));
                LoadAvailableDoctors();
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

        private ObservableCollection<string> availableDoctors;

        /**
         * AvailableDoctors property
         * @precondition none
         * @postcondition none
         * @return ObservableCollection<string>
         */

        public ObservableCollection<string> AvailableDoctors
        {
            get => availableDoctors;
            set { availableDoctors = value; OnPropertyChanged(nameof(AvailableDoctors)); }
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
            availableDoctors = new ObservableCollection<string>();
            selectedDate = DateTime.Today;
            LoadAppointments();
            LoadAvailableDoctors();
        }

        private bool CanExecuteSchedule() => ValidateFields();

        private bool CanExecuteEdit() => SelectedAppointment != null && ValidateFields();

        /**
         * Load available doctors form the database into the AvailableDoctors collection
         * @precondition none
         * @postcondition none
         */
        public void LoadAvailableDoctors()
        {
            AvailableDoctors.Clear();

            var availableDoctors = appointmentDAL.GetAvailableDoctors(SelectedDate);

            if (availableDoctors.Count == 0)
            {
                AvailableDoctors.Clear();
            }
            else
            {
                foreach (var doctor in availableDoctors)
                {
                    AvailableDoctors.Add(doctor);
                }
            }

            OnPropertyChanged(nameof(AvailableDoctors));
        }



        /**
         * Load available time slots form the database into the AvailableTimeSlots collection
         * @precondition none
         * @postcondition none
         */
        public void LoadAvailableTimeSlots()
        {
            AvailableTimeSlots.Clear();

            var timeSlots = appointmentDAL.GetAvailableTimeSlots(SelectedDate, DoctorName);
            if (timeSlots.Count > 0)
            {
                foreach (var time in timeSlots)
                {
                    AvailableTimeSlots.Add(time);
                }
            }

            OnPropertyChanged(nameof(AvailableTimeSlots));
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
         * Shedules and appointment and update the database
         * @precondition none
         * @postcondition none
         * @return true if the appointment was scheduled successfully, false otherwise
         */
        public bool ScheduleAppointment()
        {
            if (!canScheduleAppointment()) return false;

            if (!ValidateFields()) return false;

            int patientId = new PatientDAL().GetPatientIdByName(PatientName);
            int doctorId = appointmentDAL.GetDoctorIdByName(SelectedDoctor);

            var timeSlotParts = SelectedTimeSlot.Split('|');
            var timePart = timeSlotParts[1].Split('-')[0].Trim();
            var appointmentDateTime = DateTime.ParseExact(timeSlotParts[0].Trim() + " | " + timePart, "yyyy-MM-dd | HH:mm", CultureInfo.InvariantCulture);

            if (!appointmentDAL.IsTimeSlotAvailable(patientId, doctorId, appointmentDateTime))
            {
                OnErrorMessageRaised("Error: The selected time slot is not available.");
                return false;
            }

            int availabilityId = appointmentDAL.GetAvailabilityId(doctorId, appointmentDateTime);
            CreateAppointment(patientId, doctorId, appointmentDateTime, Reason, availabilityId);
            OnSuccessMessageRaised("Success: Appointment scheduled successfully.");
            LoadAppointments();
            return true;
        }

        /**
         * Search the database for appointments by patient name
         * @precondition none
         * @postcondition none
         */
        public void SearchAppointments()
        {
            if (string.IsNullOrWhiteSpace(SearchPatientApptsByName))
            {
                OnSuccessMessageRaised("Error: Please enter a patient name to search.");
                return;
            }

            var appointments = appointmentDAL.GetAppointmentsByPatientName(SearchPatientApptsByName);
            if (!appointments.Any())
            {
                OnErrorMessageRaised("Error: No appointments found.");
                return;
            }

            Appointments = new ObservableCollection<Appointment>(appointments);
            OnSuccessMessageRaised($"Success: {appointments.Count} appointments found.");
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
            OnSuccessMessageRaised("Success: Appointment updated successfully!");
            LoadAppointments();
        }

        private bool TryGetNewAppointmentDetails(out int doctorId, out DateTime appointmentDateTime, out int newAvailabilityId)
        {
            doctorId = 0;
            appointmentDateTime = DateTime.MinValue;
            newAvailabilityId = 0;

            if (string.IsNullOrWhiteSpace(SelectedDoctor) || string.IsNullOrWhiteSpace(SelectedTimeSlot) || SelectedDate == default)
            {
                OnErrorMessageRaised("Error: Please select a doctor, date, and time slot.");
                return false;
            }

            doctorId = appointmentDAL.GetDoctorIdByName(SelectedDoctor);
            if (doctorId == 0)
            {
                OnErrorMessageRaised("Error: Invalid doctor selected.");
                return false;
            }

            var timeSlotParts = SelectedTimeSlot.Split('|');
            var timePart = timeSlotParts[1].Split('-')[0].Trim();
            appointmentDateTime = DateTime.ParseExact(timeSlotParts[0].Trim() + " | " + timePart, "yyyy-MM-dd | HH:mm", CultureInfo.InvariantCulture);

            appointmentDateTime = new DateTime(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, appointmentDateTime.Hour, appointmentDateTime.Minute, 0);
            newAvailabilityId = appointmentDAL.GetAvailabilityId(doctorId, appointmentDateTime);

            if (newAvailabilityId == 0)
            {
                OnErrorMessageRaised("Error: Selected time slot is not available.");
                return false;
            }

            return true;
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

        public void SearchForAPatient()
        {
            try
            {
                int patientId = new PatientDAL().GetPatientIdByName(SearchPatient);
                if (patientId > 0)
                {
                    var patient = new PatientDAL().GetPatientWithId(patientId);

                    if (patient == null)
                    {
                        OnErrorMessageRaised("Error: Patient not found.");
                        return;
                    }
                    else
                    {
                        PatientName = $"{patient.FirstName} {patient.LastName}";
                    }

                }
                else
                {
                    OnErrorMessageRaised("Error: Patient not found.");
                }
            }
            catch (Exception ex)
            {
                OnErrorMessageRaised("Error: An error occurred: " + ex.Message);
            }
        }

        private bool canEditAppointment()
        {
            if (SelectedAppointment?.DateTime == DateTime.Today)
            {
                OnErrorMessageRaised("Error: Can not edit appointment on the appointment day");
                return false;
            }
            else if (SelectedAppointment?.DateTime < DateTime.Today)
            {
                OnErrorMessageRaised("Error: Can not edit appointment that has already passed");
                return false;
            }
            return true;
        }

        private bool canScheduleAppointment()
        {
            if (SelectedDate < DateTime.Today)
            {
                OnErrorMessageRaised("Error: Can not schedule appointment on a past date");
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
        public void PopulateFieldsFromSelectedDocAndTimeSlot()
        {
            if (string.IsNullOrWhiteSpace(SelectedDoctor) || string.IsNullOrWhiteSpace(SelectedTimeSlot)) return;
            var doctorId = appointmentDAL.GetDoctorIdByName(SelectedDoctor);
            var timeSlotParts = SelectedTimeSlot.Split('|');
            var timePart = timeSlotParts[1].Split('-')[0].Trim();
            var appointmentDateTime = DateTime.ParseExact(timeSlotParts[0].Trim() + " | " + timePart, "yyyy-MM-dd | HH:mm", CultureInfo.InvariantCulture);

            DoctorName = SelectedDoctor;
            AppointmentTime = SelectedTimeSlot;
            SelectedDate = appointmentDateTime.Date;
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            List<string> errorMessages = new List<string>();

            if (string.IsNullOrWhiteSpace(PatientName))
            {
                errorMessages.Add("Error: Patient name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(DoctorName))
            {
                errorMessages.Add("Error: Doctor name is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(AppointmentTime))
            {
                errorMessages.Add("Error: Appointment time is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Reason))
            {
                errorMessages.Add("Error: Reason for appointment is required.");
                isValid = false;
            }

            if (errorMessages.Any())
            {
                OnErrorMessageRaised(string.Join("\n", errorMessages));
            }

            return isValid;
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
                OnErrorMessageRaised("Error: Select an appointment to edit.");
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
            AppointmentTime = string.Empty;
        }

        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
