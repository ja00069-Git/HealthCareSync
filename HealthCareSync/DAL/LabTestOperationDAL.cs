using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    public class LabTestOperationDAL
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabTestOperationDAL"/> class.
        /// </summary>
        public LabTestOperationDAL() { }

        /// <summary>
        /// Deletes the lab test operation.
        /// </summary>
        /// <param name="labTestOperation">The lab test operation.</param>
        public void DeleteLabTestOperation(LabTestOperation labTestOperation)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"DELETE from lab_test_operation 
                          WHERE date_time = @dateTime AND appointment_id = @appointmentId AND name = @name";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@dateTime", MySqlDbType.DateTime).Value = labTestOperation.DateTime;
            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = labTestOperation.AppointmentId;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = labTestOperation.LabTestName;

            command.ExecuteNonQuery();
        } 

        /// <summary>
        /// Orders the lab test.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="labTest">The lab test.</param>
        /// <returns>true if possible to order the lab test, false otherwise</returns>
        public bool OrderLabTest(DateTime dateTime, int appointmentId, LabTest labTest)
        {

            try
            {
                using var connection = new MySqlConnection(Connection.ConnectionString());

                connection.Open();

                var query = @"INSERT into lab_test_operation(date_time, appointment_id, name)
                          VALUES
                          (@dateTime, @appointmentId, @name)";

                using var command = new MySqlCommand(query, connection);

                command.Parameters.Add("@dateTime", MySqlDbType.DateTime).Value = dateTime;
                command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = labTest.Name;

                var result = command.ExecuteNonQuery();
                return result == 1;
            }
            catch (MySqlException ex)
            {
                // Duplicate entry
                return false;
            }
        }

        /// <summary>
        /// Gets the lab test operations.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <returns></returns>
        public List<LabTestOperation> GetLabTestOperations(int appointmentId)
        {
            var list = new List<LabTestOperation>();

            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"SELECT date_time, name, results, normal
                          FROM lab_test_operation
                          WHERE appointment_id = @appointmentId";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

            using var reader = command.ExecuteReader();

            var dateTimeOrdinal = reader.GetOrdinal("date_time");
            var nameOrdinal = reader.GetOrdinal("name");
            var resultsOrdinal = reader.GetOrdinal("results");
            var normalOrdinal = reader.GetOrdinal("normal");

            while (reader.Read())
            {
                list.Add(CreateLabTestOperation(reader, dateTimeOrdinal, appointmentId, nameOrdinal, resultsOrdinal, normalOrdinal));
            }

            return list;

        }

        private LabTestOperation CreateLabTestOperation(MySqlDataReader reader, int dateTimeOrdinal, int appointmentId, int nameOrdinal, int resultsOrdinal, int normalOrdinal)
        {

            return new LabTestOperation(
                reader.GetFieldValueCheckNull<DateTime>(dateTimeOrdinal),
                appointmentId,
                reader.GetFieldValueCheckNull<string>(nameOrdinal),
                reader.GetFieldValueCheckNull<string?>(resultsOrdinal),
                reader.GetFieldValueCheckNull<bool?>(normalOrdinal)
            );
        }

    }
}
