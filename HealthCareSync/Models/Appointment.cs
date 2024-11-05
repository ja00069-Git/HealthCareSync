using HealthCareSync.DAL;

namespace HealthCareSync.Models
{
    public class Appointment
    {
        private PatientDAL patientDAL;

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

        /// <summary>
        /// Gets the appointment information.
        /// </summary>
        /// <value>
        /// The appointment information.
        /// </value>
        public string AppointmentInformation => $"{PatientName} {this.getPatientDOB()} | {DoctorName}";

        private string DisplayInfo => $"{DateTime:MM/dd/yyyy HH:mm} with {DoctorName} | {PatientName}";

        /// <summary>
        /// Initializes a new instance of the <see cref="Appointment"/> class.
        /// </summary>
        public Appointment() { this.patientDAL = new PatientDAL(); }

        /**
         * ToString: Returns the string representation of the appointment.
         */
        public override string ToString()
        {
            return DisplayInfo;
        }

        private string getPatientDOB()
        {
            return this.patientDAL.GetPatientWithId(PatientId).FormattedBirthDate;
        }
    }
}
