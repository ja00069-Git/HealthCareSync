using System.Data;
using HealthCareSync.Enums;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    public class AdministratorDatalayer
    {
        private AddressDAL addressDAL;
        private UserDAL userDAL;

        private readonly string connectionString = Connection.ConnectionString();

        /**
         * Initializes a new instance of the Administrator data layer class.
         * @param addressDAL The address data layer.
         * @param userDAL The user data layer.
         * @pre addressDAL != null && userDAL != null
         * @post none
         * @return A new instance of the Nurse data layer class.
         */
        public AdministratorDatalayer() { this.addressDAL = new AddressDAL(); this.userDAL = new UserDAL(); }

        /**
         * Adds an administrator to the database.
         * @param fname The first name.
         * @param lname The last name.
         * @param bdate The birth date.
         * @param address_1 The first address.
         * @param zip The zip code.
         * @param city The city.
         * @param state The state.
         * @param address_2 The second address.
         * @param phone_num The phone number.
         * @param username The username.
         * @param password The password.
         * @pre fname != null && lname != null && bdate != null && address_1 != null && zip != null && city != null && state != null && phone_num != null && username != null && password != null
         * @post none
         * @return The id of the administrator.
         */
        public int SignUpAnAdmin(string fname, string lname, DateTime bdate, string address_1,
            string zip, string city, string state, string? address_2, string phone_num, string username, string password)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var adminQuery = @"insert into administrator (fname, lname, birth_date, phone_num, address_id, username)
                               values (@fname, @lname, @bdate, @phone_num, @address, @username)";

            using var adminCommand = new MySqlCommand(adminQuery, connection);
            adminCommand.Transaction = transaction;

            int id = 0;

            try
            {
                // Insert into user table using UserDAL
                if (!this.userDAL.AddUser(username, password, connection))
                {
                    MessageBox.Show("Failed to sign up a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Insert or update address and get address_id
                int address_id = this.addressDAL.UpdateAddressIfExistsElseCreate(connection, transaction, address_1!, zip!, city, Enum.Parse<State>(state.ToUpper()), address_2);

                // Insert into administrator table
                adminCommand.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                adminCommand.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                adminCommand.Parameters.Add("@address", MySqlDbType.Int32).Value = address_id;
                adminCommand.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
                adminCommand.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
                adminCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                adminCommand.ExecuteNonQuery();

                // Retrieve administrator id
                var retrieveQuery = @"select LAST_INSERT_ID()";
                using var retrieveIdCommand = new MySqlCommand(retrieveQuery, connection);
                retrieveIdCommand.Transaction = transaction;
                id = Convert.ToInt32(retrieveIdCommand.ExecuteScalar());

                transaction.Commit();
            }
            catch (Exception)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    MessageBox.Show("Rollback failed: " + rollbackEx.Message);
                }
            }

            return id;
        }

        /// <summary>
        /// Executes the query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public Tuple<DataTable, string> ExecuteQuery(string query)
        {
            try
            {
                using var connection = new MySqlConnection(Connection.ConnectionString());

                connection.Open();

                using var command = new MySqlCommand(query, connection);

                using var reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                return new Tuple<DataTable, string>(dt, "SUCCESS");
            }
            catch (MySqlException exception)
            {
                return new Tuple<DataTable, string>(null!, exception.Message);
            }
            catch (InvalidOperationException exception)
            {
                return new Tuple<DataTable, string>(null!, exception.Message);
            }
        }

        /// <summary>
        /// Views the report.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        public DataTable ViewReport(DateTime from, DateTime to)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            string query = @"SELECT 
                                appointment.date_time AS `Visit Date`, 
                                appointment.patient_id AS `Patient ID`, 
                                CONCAT(patient.fname, ' ', patient.lname) AS Patient,
                                CONCAT(doctor.fname, ' ',doctor.lname) AS Doctor,
                                CONCAT(nurse.fname, ' ', nurse.lname) AS Nurse,
                                lab_test_operation.name AS `Test Name`,
                                lab_test_operation.date_time AS `Test Date`,
                                lab_test_operation.results AS Results,
                                lab_test_operation.normal AS Normal,
                                diagnoses.initial_diagnoses AS `Initial Diagnoses`,
                                diagnoses.final_diagnoses AS `Final Diagnoses`
                            FROM
                                routine_checks 
                                LEFT JOIN appointment ON routine_checks.appointment_id = appointment.id
                                LEFT JOIN patient ON appointment.patient_id = patient.id
                                LEFT JOIN doctor ON appointment.doctor_id = doctor.id
                                LEFT JOIN nurse ON routine_checks.nurse_id = nurse.id
                                LEFT JOIN lab_test_operation ON appointment.id = lab_test_operation.appointment_id
                                LEFT JOIN diagnoses ON appointment.id = diagnoses.appointment_id
                            WHERE appointment.date_time BETWEEN @fromDate AND DATE_ADD(@toDate, INTERVAL 1 DAY) - INTERVAL 1 SECOND
                            GROUP BY 
                                appointment.id, 
                                `Visit Date`, 
                                `Patient ID`, 
                                Patient, 
                                Doctor, 
                                Nurse, 
                                `Test Name`,
                                `Test Date`, 
                                Results, 
                                Normal, 
                                `Initial Diagnoses`, 
                                `Final Diagnoses`
                            ORDER BY `Visit Date`, patient.lname";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = from.Date;
            command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = to.Date;

            using var reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }
    }
}
