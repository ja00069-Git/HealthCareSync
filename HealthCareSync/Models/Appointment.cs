namespace HealthCareSync.Models
{
    public class Appointment
    {
        /**
         * AppointmentId: The unique identifier for the appointment.
         */
        public int AppointmentId { get; set; }

        /**
         * PatientId: The unique identifier for the patient.
         */
        public int PatientId { get; set; }

        /**
         * DoctorId: The unique identifier for the doctor.
         */
        public int DoctorId { get; set; }

        /**
         * DateTime: The date and time of the appointment.
         */
        public DateTime DateTime { get; set; }

        /**
         * Reason: The reason for the appointment.
         */
        public string? Reason { get; set; }

        /**
         * DoctorName: The name of the doctor.
         */
        public string? DoctorName { get; set; }

        /**
         * PatientName: The name of the patient.
         */
        public string? PatientName { get; set; }

        private string DisplayInfo => $"{DateTime:MM/dd/yyyy HH:mm} with {DoctorName} | {PatientName}";

        /**
         * ToString: Returns the string representation of the appointment.
         */
        public override string ToString()
        {
            return DisplayInfo;
        }
    }
}
