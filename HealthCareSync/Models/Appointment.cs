namespace HealthCareSync.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime DateTime { get; set; }
        public string? Reason { get; set; }
        public string? DoctorName { get; set; }
        public string? PatientName { get; set; }
    }
}
