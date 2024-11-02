using HealthCareSync.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.DAL
{
    public class RoutineChecksDAL
    {
        private AddressDAL addressDAL;

        private readonly string connectionString = "server=cs-dblab01.uwg.westga.edu;uid=cs3230f24c;" +
             "pwd=ZIEbXBxGYTIGdXa>RbSJ;database=cs3230f24c;";
        public RoutineChecksDAL() { this.addressDAL = new AddressDAL(); }

        public int SaveRoutineChecks(int appointmentId, int systolicReading, int diastolicReading, int bodyTemperature, int pulseBPM,
            string symptoms, decimal weight, decimal height)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var query = string.Empty;
            int address_id = 0;
            int id = 0;

            using var command = new MySqlCommand(query, connection);
            command.Transaction = transaction;

            try
            {
                
                command.Parameters.Add("@appointment_id", MySqlDbType.Int32).Value = appointmentId;
                command.Parameters.Add("@systolic_reading", MySqlDbType.Int32).Value = systolicReading;
                command.Parameters.Add("@diastolic_reading", MySqlDbType.Int32).Value = address_id;
                command.Parameters.Add("@body_temperature", MySqlDbType.Int32).Value = bodyTemperature;
                command.Parameters.Add("@pulse_bpm", MySqlDbType.Int32).Value = pulseBPM;
                command.Parameters.Add("@symptoms", MySqlDbType.VarChar).Value = symptoms;
                command.Parameters.Add("@weight", MySqlDbType.Decimal).Value = weight;
                command.Parameters.Add("@height", MySqlDbType.Decimal).Value = height;
                
                

                command.ExecuteNonQuery();

                var retrieveQuery = @"select LAST_INSERT_ID()";

                using var retrieveIdCommand = new MySqlCommand(retrieveQuery, connection);
                retrieveIdCommand.Transaction = transaction;
                using var retrieveIdReader = retrieveIdCommand.ExecuteReader();
                int idOrdinal = retrieveIdReader.GetOrdinal("LAST_INSERT_ID()");

                while (retrieveIdReader.Read())
                {
                    ulong tempId = retrieveIdReader.GetFieldValueCheckNull<UInt64>(idOrdinal);

                    if (tempId <= Int32.MaxValue)
                    {
                        id = (int)tempId;
                    }
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Debug.WriteLine("Rollback failed: " + rollbackEx.Message);
                }
            }


            return id;
        }

        public void SaveEditedRoutineChecks(int appointmentId, int systolicReading, int diastolicReading, int bodyTemperature, int pulseBPM,
            string symptoms, decimal weight, decimal height)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var query = @"update routine_checks 
                        set  systolic_reading = @systolic_reading, diastolic_reading = @diastolic_reading,
                        body_temperature = @body_temperature, pulse_bpm = @pulse_bpm, symptoms = @symptoms, weight = @weight, height = @height
                        where appointmentId = @appointment_id";


            using var command = new MySqlCommand(query, connection);
            command.Transaction = transaction;

            try
            {

                command.Parameters.Add("@systolic_reading", MySqlDbType.Int32).Value = systolicReading;
                command.Parameters.Add("@diastolic_reading", MySqlDbType.Int32).Value = diastolicReading;
                command.Parameters.Add("@body_temperature", MySqlDbType.Int32).Value = bodyTemperature;
                command.Parameters.Add("@pulse_bpm", MySqlDbType.Int32).Value = pulseBPM;
                command.Parameters.Add("@symptoms", MySqlDbType.VarChar).Value = symptoms;
                command.Parameters.Add("@weight", MySqlDbType.Decimal).Value = weight;
                command.Parameters.Add("@height", MySqlDbType.Decimal).Value = height;
                command.Parameters.Add("@appointment_id", MySqlDbType.Int32).Value = appointmentId;

                command.ExecuteNonQuery();

                this.addressDAL.DeleteUnreferencedAddresses(connection, transaction);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    Debug.WriteLine("Rollback failed: " + rollbackEx.Message);
                }
            }
        }
    }
}
