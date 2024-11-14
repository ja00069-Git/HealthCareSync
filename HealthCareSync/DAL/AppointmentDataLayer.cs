using MySql.Data.MySqlClient;
using HealthCareSync.Models;

namespace HealthCareSync.DAL
{
    public class AppointmentDAL
    {
        public List<string> GetAvailableDoctors(DateTime date)
        {
            var doctors = new List<string>();
            string query = "SELECT DISTINCT d.fname, d.lname FROM doctor_availability da " +
                           "JOIN doctor d ON da.doctor_id = d.id WHERE da.available_date = @date AND da.isAvailable = 1";
            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string doctorName = $"{reader.GetString("fname")} {reader.GetString("lname")}";
                        doctors.Add(doctorName);
                    }
                }
            }
            return doctors;
        }

        public List<string> GetAvailableTimeSlots(DateTime date, string doctorName)
        {
            var timeSlots = new List<string>();
            string query = "SELECT da.start_time, da.end_time FROM doctor_availability da " +
                           "JOIN doctor d ON da.doctor_id = d.id WHERE da.available_date = @date AND da.isAvailable = 1 " +
                           "AND CONCAT(d.fname, ' ', d.lname) = @doctorName";
            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@doctorName", doctorName);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string timeSlot = $"{date.ToString("yyyy-MM-dd")} | " +
                            $"{reader.GetTimeSpan("start_time").ToString(@"hh\:mm")} " +
                            $"- {reader.GetTimeSpan("end_time").ToString(@"hh\:mm")}";
                        timeSlots.Add(timeSlot);
                    }
                }
            }
            return timeSlots;
        }


        /**
         * Check if a time slot is available for a patient to schedule an appointment
         * @precondition The patientId must be valid
         * @precondition The doctorId must be valid
         * @param patientId The ID of the patient
         * @param doctorId The ID of the doctor
         * @param dateTime The date and time of the appointment
         * @return True if the time slot is available, false otherwise
         */
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

        /**
         * Schedule an appointment for a patient with a doctor
         * @precondition The appointment must be valid
         * @precondition The availabilityId must be valid
         * @param appointment The appointment to schedule
         * @param availabilityId The ID of the availability slot
         */
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


        /**
         * Get a doctor's name by lookup the available time
         * @precondition The availabilityId must be valid
         * @precondition The appointmentId must be valid
         * @param appointmentId The ID of the appointment to cancel
         * @return The id of the doctor
         */
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

        /**
         * Get a doctor's ID by lookup the available time
         * @precondition The doctorName must be valid
         * @postcondition The doctor's ID is returned
         * @param doctorName The name of the doctor
         * @return The ID of the doctor
         */
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

        /**
         * Get a list of appointments for a patient by name
         * @precondition The patientName must be valid
         * @postcondition A list of appointments for the patient is returned
         * @param patientName The name of the patient
         * @return A list of appointments for the patient
         */
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

        /**
         * Get a list of appointments for a doctor by name
         * @precondition The doctorName must be valid
         * @postcondition A list of appointments for the doctor is returned
         * @param doctorName The name of the doctor
         * @return A list of appointments for the doctor
         */
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

        /**
         * Get a list of appointments for a doctor by name
         * @precondition The doctorName must be valid
         * @postcondition A list of appointments for the doctor is returned
         * @param doctorName The name of the doctor
         * @return A list of appointments for the doctor
         */
        public void UpdateAppointment(Appointment appointment, int newAvailabilityId, int previousAvailabilityId)
        {
            string updateAppointmentQuery = @"
                UPDATE appointment 
                SET doctor_id = @doctorId, date_time = @dateTime, reason = @reason 
                WHERE id = @appointmentId";

            string updatePreviousAvailabilityQuery = @"
                UPDATE doctor_availability 
                SET isAvailable = 1 
                WHERE availability_id = @previousAvailabilityId";

            string updateNewAvailabilityQuery = @"
                UPDATE doctor_availability 
                SET isAvailable = 0 
                WHERE availability_id = @newAvailabilityId";

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

                        // Update previous availability status
                        if (previousAvailabilityId != 0)
                        {
                            using (var command = new MySqlCommand(updatePreviousAvailabilityQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@previousAvailabilityId", previousAvailabilityId);
                                command.ExecuteNonQuery();
                            }
                        }

                        // Update new availability status
                        if (newAvailabilityId != 0)
                        {
                            using (var command = new MySqlCommand(updateNewAvailabilityQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@newAvailabilityId", newAvailabilityId);
                                command.ExecuteNonQuery();
                            }
                        }

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

        /**
         * Cancel an appointment for a patient
         * @precondition The appointmentId must be valid
         * @postcondition The appointment is removed from the database
         * @param appointmentId The ID of the appointment to cancel
         * @param availabilityId The ID of the availability slot
         */
        public int GetAvailabilityId(int doctorId, DateTime appointmentDateTime)
        {
            int availabilityId = 0;

            string query = @"
                SELECT da.availability_id 
                FROM doctor_availability da
                WHERE da.doctor_id = @doctorId 
                AND da.start_time <= @dateTime 
                AND da.end_time > @dateTime";

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

        /// <summary>
        /// Gets the appointments.
        /// </summary>
        /// <returns></returns>
        public List<Appointment> GetAppointments()
        {
            var appointments = new List<Appointment>();

            string query = @"
                SELECT A.id, A.doctor_id, A.patient_id, A.date_time, A.reason,
                       P.fname as patient_fname, P.lname as patient_lname, D.fname as doctor_fname, D.lname as doctor_lname
                FROM appointment A
                    JOIN patient P ON A.patient_id = P.id
                    JOIN doctor D ON A.doctor_id = D.id
                WHERE P.flag_status = 'active'";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            { 

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    var appointmentIdOrdinal = reader.GetOrdinal("id");
                    var doctorIdOrdinal = reader.GetOrdinal("doctor_id");
                    var patientIdOrdinal = reader.GetOrdinal("patient_id");
                    var dateTimeOrdinal = reader.GetOrdinal("date_time");
                    var reasonOrdinal = reader.GetOrdinal("reason");
                    var patientFNameOrdinal = reader.GetOrdinal("patient_fname");
                    var patientLNameOrdinal = reader.GetOrdinal("patient_lname");
                    var doctorFNameOrdinal = reader.GetOrdinal("doctor_fname");
                    var doctorLNameOrdinal = reader.GetOrdinal("doctor_lname");

                    while (reader.Read())
                    {
                        var appointment = new Appointment
                        {
                            AppointmentId = reader.GetFieldValueCheckNull<int>(appointmentIdOrdinal),
                            PatientId = reader.GetFieldValueCheckNull<int>(patientIdOrdinal),
                            DoctorId = reader.GetFieldValueCheckNull<int>(doctorIdOrdinal),
                            DateTime = reader.GetFieldValueCheckNull<DateTime>(dateTimeOrdinal),
                            Reason = reader.GetFieldValueCheckNull<string>(reasonOrdinal),
                            DoctorName = $"{reader.GetFieldValueCheckNull<string>(doctorFNameOrdinal)} {reader.GetFieldValueCheckNull<string>(doctorLNameOrdinal)}",
                            PatientName = $"{reader.GetFieldValueCheckNull<string>(patientFNameOrdinal)} {reader.GetFieldValueCheckNull<string>(patientLNameOrdinal)}"
                        };

                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        /// <summary>
        /// Gets the first name of the appointments with.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsWithFirstName(string firstName)
        {
            var appointments = new List<Appointment>();

            string query = @"
                SELECT A.id, A.doctor_id, A.patient_id, A.date_time, A.reason,
                       P.fname as patient_fname, P.lname as patient_lname, D.fname as doctor_fname, D.lname as doctor_lname
                FROM appointment A
                    JOIN patient P ON A.patient_id = P.id
                    JOIN doctor D ON A.doctor_id = D.id
                WHERE P.flag_status = 'active' AND P.fname = @fname";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    var appointmentIdOrdinal = reader.GetOrdinal("id");
                    var doctorIdOrdinal = reader.GetOrdinal("doctor_id");
                    var patientIdOrdinal = reader.GetOrdinal("patient_id");
                    var dateTimeOrdinal = reader.GetOrdinal("date_time");
                    var reasonOrdinal = reader.GetOrdinal("reason");
                    var patientFNameOrdinal = reader.GetOrdinal("patient_fname");
                    var patientLNameOrdinal = reader.GetOrdinal("patient_lname");
                    var doctorFNameOrdinal = reader.GetOrdinal("doctor_fname");
                    var doctorLNameOrdinal = reader.GetOrdinal("doctor_lname");

                    while (reader.Read())
                    {
                        var appointment = new Appointment
                        {
                            AppointmentId = reader.GetFieldValueCheckNull<int>(appointmentIdOrdinal),
                            PatientId = reader.GetFieldValueCheckNull<int>(patientIdOrdinal),
                            DoctorId = reader.GetFieldValueCheckNull<int>(doctorIdOrdinal),
                            DateTime = reader.GetFieldValueCheckNull<DateTime>(dateTimeOrdinal),
                            Reason = reader.GetFieldValueCheckNull<string>(reasonOrdinal),
                            DoctorName = $"{reader.GetFieldValueCheckNull<string>(doctorFNameOrdinal)} {reader.GetFieldValueCheckNull<string>(doctorLNameOrdinal)}",
                            PatientName = $"{reader.GetFieldValueCheckNull<string>(patientFNameOrdinal)} {reader.GetFieldValueCheckNull<string>(patientLNameOrdinal)}"
                        };

                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        /// <summary>
        /// Gets the last name of the appointments with.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsWithLastName(string lastName)
        {
            var appointments = new List<Appointment>();

            string query = @"
                SELECT A.id, A.doctor_id, A.patient_id, A.date_time, A.reason,
                       P.fname as patient_fname, P.lname as patient_lname, D.fname as doctor_fname, D.lname as doctor_lname
                FROM appointment A
                    JOIN patient P ON A.patient_id = P.id
                    JOIN doctor D ON A.doctor_id = D.id
                WHERE P.flag_status = 'active' AND P.lname = @lname";

            using (var connection = new MySqlConnection(Connection.ConnectionString()))
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    var appointmentIdOrdinal = reader.GetOrdinal("id");
                    var doctorIdOrdinal = reader.GetOrdinal("doctor_id");
                    var patientIdOrdinal = reader.GetOrdinal("patient_id");
                    var dateTimeOrdinal = reader.GetOrdinal("date_time");
                    var reasonOrdinal = reader.GetOrdinal("reason");
                    var patientFNameOrdinal = reader.GetOrdinal("patient_fname");
                    var patientLNameOrdinal = reader.GetOrdinal("patient_lname");
                    var doctorFNameOrdinal = reader.GetOrdinal("doctor_fname");
                    var doctorLNameOrdinal = reader.GetOrdinal("doctor_lname");

                    while (reader.Read())
                    {
                        var appointment = new Appointment
                        {
                            AppointmentId = reader.GetFieldValueCheckNull<int>(appointmentIdOrdinal),
                            PatientId = reader.GetFieldValueCheckNull<int>(patientIdOrdinal),
                            DoctorId = reader.GetFieldValueCheckNull<int>(doctorIdOrdinal),
                            DateTime = reader.GetFieldValueCheckNull<DateTime>(dateTimeOrdinal),
                            Reason = reader.GetFieldValueCheckNull<string>(reasonOrdinal),
                            DoctorName = $"{reader.GetFieldValueCheckNull<string>(doctorFNameOrdinal)} {reader.GetFieldValueCheckNull<string>(doctorLNameOrdinal)}",
                            PatientName = $"{reader.GetFieldValueCheckNull<string>(patientFNameOrdinal)} {reader.GetFieldValueCheckNull<string>(patientLNameOrdinal)}"
                        };

                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }
    }
}
