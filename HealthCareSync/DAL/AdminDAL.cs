using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    public class AdminDAL
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminDAL"/> class.
        /// </summary>
        public AdminDAL() { }

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
                                GROUP_CONCAT(DISTINCT lab_test_operation.name ORDER BY lab_test_operation.name SEPARATOR ', ') AS Tests,
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
                            WHERE  appointment.date_time Between @fromDate AND @toDate
                            GROUP BY 
                                appointment.id, 
                                `Visit Date`, 
                                `Patient ID`, 
                                Patient, 
                                Doctor, 
                                Nurse, 
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
