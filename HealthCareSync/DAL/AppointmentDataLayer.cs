using MySql.Data.MySqlClient;
using HealthCareSync.Models;

namespace HealthCareSync.DAL
{
    public class AppointmentDAL
    {
        // Retrieve available time slots for a doctor on a given date
        public List<(int AvailabilityId, int DoctorId, string TimeSlot, string DoctorName)> GetAvailableTimeSlots(DateTime date)
        {
            var timeSlots = new List<(int, int, string, string)>();

            string query = @"
                SELECT da.availability_id, da.doctor_id, da.start_time, da.end_time, d.fname, d.lname 
                FROM doctor_availability da
                JOIN doctor d ON da.doctor_id = d.id
                WHERE da.available_date = @date AND da.isAvailable = 1";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int availabilityId = reader.GetInt32("availability_id");
                        int doctorId = reader.GetInt32("doctor_id");
                        string timeSlot = $"{reader.GetTimeSpan("start_time").ToString(@"hh\:mm")}" +
                            $" - {reader.GetTimeSpan("end_time").ToString(@"hh\:mm")}";
                        string doctorName = $"{reader.GetString("fname")} {reader.GetString("lname")}";

                        timeSlots.Add((availabilityId, doctorId, timeSlot, doctorName));
                    }
                }
            }

            return timeSlots;
        }

        // Check if a time slot is available for the doctor or patient
        public bool IsTimeSlotAvailable(int patientId, int doctorId, DateTime dateTime)
        {
            string query = @"
                SELECT COUNT(*) 
                FROM appointment 
                WHERE (patient_id = @patientId OR doctor_id = @doctorId) 
                AND date_time = @dateTime";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@patientId", patientId);
                command.Parameters.AddWithValue("@doctorId", doctorId);
                command.Parameters.AddWithValue("@dateTime", dateTime);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count == 0;
            }
        }

        public void ScheduleAppointment(Appointment appointment, int availabilityId)
        {
            string query = @"
                INSERT INTO appointment (patient_id, doctor_id, date_time, reason) 
                VALUES (@patientId, @doctorId, @dateTime, @reason)";

            string updateQuery = @"
                UPDATE doctor_availability 
                SET isAvailable = 0 
                WHERE availability_id = @availabilityId";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = new MySqlCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@patientId", appointment.PatientId);
                            command.Parameters.AddWithValue("@doctorId", appointment.DoctorId);
                            command.Parameters.AddWithValue("@dateTime", appointment.DateTime);
                            command.Parameters.AddWithValue("@reason", appointment.Reason);
                            command.ExecuteNonQuery();
                        }

                        using (var updateCommand = new MySqlCommand(updateQuery, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@availabilityId", availabilityId);
                            updateCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


        // Retrieve doctor name by availability ID
        public string GetDoctorNameByAvailabilityId(int availabilityId)
        {
            string doctorName = string.Empty;

            string query = @"
                SELECT d.fname, d.lname 
                FROM Doctor_Availability da
                JOIN Doctor d ON da.doctor_id = d.id
                WHERE da.availability_id = @availabilityId";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@availabilityId", availabilityId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        doctorName = $"{reader.GetString("fname")} {reader.GetString("lname")}";
                    }
                }
            }

            return doctorName;
        }

        // Retrieve patient ID by name
        public int GetPatientIdByName(string patientName)
        {
            int patientId = 0;

            string query = @"
                SELECT id 
                FROM patient 
                WHERE CONCAT(fname, ' ', lname) = @patientName";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@patientName", patientName);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        patientId = reader.GetInt32("id");
                    }
                }
            }

            return patientId;
        }

        // Get doctorid by name
        public int GetDoctorIdByName(string doctorName)
        {
            int doctorId = 0;

            string query = @"
        SELECT id 
        FROM doctor 
        WHERE CONCAT(fname, ' ', lname) = @doctorName";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@doctorName", doctorName);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        doctorId = reader.GetInt32("id");
                    }
                }
            }

            return doctorId;
        }

        // Get appointment by patient Name
        public List<Appointment> GetAppointmentsByPatientName(string patientName)
        {
            var appointments = new List<Appointment>();

            string query = @"
                SELECT a.id, a.patient_id, a.doctor_id, a.date_time, a.reason, 
                       d.fname AS doctor_fname, d.lname AS doctor_lname, 
                       p.fname AS patient_fname, p.lname AS patient_lname 
                FROM appointment a
                JOIN doctor d ON a.doctor_id = d.id
                JOIN patient p ON a.patient_id = p.id
                WHERE CONCAT(p.fname, ' ', p.lname) = @patientName";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@patientName", patientName);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var appointment = new Appointment
                        {
                            AppointmentId = reader.GetInt32("id"),
                            PatientId = reader.GetInt32("patient_id"),
                            DoctorId = reader.GetInt32("doctor_id"),
                            DateTime = reader.GetDateTime("date_time"),
                            Reason = reader.GetString("reason"),
                            DoctorName = $"{reader.GetString("doctor_fname")} {reader.GetString("doctor_lname")}",
                            PatientName = $"{reader.GetString("patient_fname")} {reader.GetString("patient_lname")}"
                        };

                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        // Retrieve appointments for a given date
        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            var appointments = new List<Appointment>();

            string query = @"
                SELECT a.id, a.patient_id, a.doctor_id, a.date_time, a.reason, 
                       d.fname AS doctor_fname, d.lname AS doctor_lname, 
                       p.fname AS patient_fname, p.lname AS patient_lname 
                FROM appointment a
                JOIN doctor d ON a.doctor_id = d.id
                JOIN patient p ON a.patient_id = p.id
                WHERE DATE(a.date_time) = @date";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var appointment = new Appointment
                        {
                            AppointmentId = reader.GetInt32("id"),
                            PatientId = reader.GetInt32("patient_id"),
                            DoctorId = reader.GetInt32("doctor_id"),
                            DateTime = reader.GetDateTime("date_time"),
                            Reason = reader.GetString("reason"),
                            DoctorName = $"{reader.GetString("doctor_fname")} {reader.GetString("doctor_lname")}",
                            PatientName = $"{reader.GetString("patient_fname")} {reader.GetString("patient_lname")}"
                        };

                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        public void UpdateAppointment(Appointment appointment, int newAvailabilityId, int previousAvailabilityId)
        {
            string updateAppointmentQuery = @"
                UPDATE appointment 
                SET doctor_id = @doctorId, date_time = @dateTime, reason = @reason 
                WHERE id = @appointmentId";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update appointment details
                        using (var command = new MySqlCommand(updateAppointmentQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@doctorId", appointment.DoctorId);
                            command.Parameters.AddWithValue("@dateTime", appointment.DateTime);
                            command.Parameters.AddWithValue("@reason", appointment.Reason);
                            command.Parameters.AddWithValue("@appointmentId", appointment.AppointmentId);
                            command.ExecuteNonQuery();
                        }

                        // Update availability statuses
                        UpdateDoctorAvailability(previousAvailabilityId, newAvailabilityId);

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void UpdateDoctorAvailability(int previousAvailabilityId, int newAvailabilityId)
        {
            if (previousAvailabilityId != 0)
            {
                UpdateAvailabilityStatus(previousAvailabilityId, 1);  // Set to available (1)
            }

            if (newAvailabilityId != 0)
            {
                UpdateAvailabilityStatus(newAvailabilityId, 0);  // Set to unavailable (0)
            }
        }

        // Update the availability status of a time slot
        public void UpdateAvailabilityStatus(int availabilityId, int status)
        {
            string query = @"
        UPDATE doctor_availability 
        SET isAvailable = @status 
        WHERE availability_id = @availabilityId";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@availabilityId", availabilityId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public int GetAvailabilityId(int doctorId, DateTime appointmentDateTime)
        {
            int availabilityId = 0;

            string query = @"
                SELECT da.availability_id 
                FROM doctor_availability da
                WHERE da.doctor_id = @doctorId 
                AND da.start_time <= @dateTime 
                AND da.end_time > @dateTime 
                AND da.isAvailable = 1";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@dateTime", appointmentDateTime.TimeOfDay);
                command.Parameters.AddWithValue("@doctorId", doctorId);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        availabilityId = reader.GetInt32("availability_id");
                    }
                }
            }

            return availabilityId;
        }

    }
}
