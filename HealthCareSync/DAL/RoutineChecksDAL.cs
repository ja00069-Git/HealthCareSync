using HealthCareSync.Enums;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.DAL
{
    /// <summary>
    /// Data access layer for the routine_checks table
    /// </summary>
    public class RoutineChecksDAL
    {

        
        public RoutineChecksDAL() { }

        /// <summary>
        /// Saves the routine checks.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="systolicReading">The systolic reading.</param>
        /// <param name="diastolicReading">The diastolic reading.</param>
        /// <param name="bodyTemperature">The body temperature.</param>
        /// <param name="pulseBPM">The pulse BPM.</param>
        /// <param name="symptoms">The symptoms.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="height">The height.</param>
        public void SaveRoutineChecks(int appointmentId, int systolicReading, int diastolicReading, int bodyTemperature, int pulseBPM,
            string symptoms, double weight, double height, int nurseId)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"INSERT into routine_checks
                          VALUES
                          (@appointmentId, @systolic, @diastolic, @temp, @bpm, @symptoms, @weight, @height, @nurse_id);";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
            command.Parameters.Add("@systolic", MySqlDbType.Int32).Value = systolicReading;
            command.Parameters.Add("@diastolic", MySqlDbType.Int32).Value = diastolicReading;
            command.Parameters.Add("@temp", MySqlDbType.Int32).Value = bodyTemperature;
            command.Parameters.Add("@bpm", MySqlDbType.Int32).Value = pulseBPM;
            command.Parameters.Add("@symptoms", MySqlDbType.VarChar).Value = symptoms;
            command.Parameters.Add("@weight", MySqlDbType.Decimal).Value = weight;
            command.Parameters.Add("@height", MySqlDbType.Decimal).Value = height;
            command.Parameters.Add("@nurse_id", MySqlDbType.Int32).Value = nurseId;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Edits the routine checks.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="systolicReading">The systolic reading.</param>
        /// <param name="diastolicReading">The diastolic reading.</param>
        /// <param name="bodyTemperature">The body temperature.</param>
        /// <param name="pulseBPM">The pulse BPM.</param>
        /// <param name="symptoms">The symptoms.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="height">The height.</param>
        public void EditRoutineChecks(int appointmentId, int systolicReading, int diastolicReading, int bodyTemperature, int pulseBPM,
            string symptoms, double weight, double height, int nurseId)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"UPDATE routine_checks 
                        SET systolic_reading = @systolic, diastolic_reading = @diastolic,
                        body_temperature = @temp, pulse_bpm = @bpm, symptoms = @symptoms, 
                        weight = @weight, height = @height, nurse_id = @nurse_id
                        where appointment_id = @appointmentId";


            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
            command.Parameters.Add("@systolic", MySqlDbType.Int32).Value = systolicReading;
            command.Parameters.Add("@diastolic", MySqlDbType.Int32).Value = diastolicReading;
            command.Parameters.Add("@temp", MySqlDbType.Int32).Value = bodyTemperature;
            command.Parameters.Add("@bpm", MySqlDbType.Int32).Value = pulseBPM;
            command.Parameters.Add("@symptoms", MySqlDbType.VarChar).Value = symptoms;
            command.Parameters.Add("@weight", MySqlDbType.Decimal).Value = weight;
            command.Parameters.Add("@height", MySqlDbType.Decimal).Value = height;
            command.Parameters.Add("@nurse_id", MySqlDbType.Int32).Value = nurseId;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Gets the routine checks.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <returns></returns>
        public RoutineChecks? GetRoutineChecks(int appointmentId)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"SELECT R.systolic_reading, R.diastolic_reading, R.body_temperature, R.pulse_bpm, R.symptoms, R.weight, R.height, R.nurse_id
                          FROM routine_checks R     
                          WHERE R.appointment_id = @appointmentId";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

            using var reader = command.ExecuteReader();

            var systolicOrdinal = reader.GetOrdinal("systolic_reading");
            var diastolicOrdinal = reader.GetOrdinal("diastolic_reading");
            var bodyTempOrdinal = reader.GetOrdinal("body_temperature");
            var bpmOrdinal = reader.GetOrdinal("pulse_bpm");
            var symptomsOrdinal = reader.GetOrdinal("symptoms");
            var weightOrdinal = reader.GetOrdinal("weight");
            var heightOrdinal = reader.GetOrdinal("height");
            var nurseIdOrdinal = reader.GetOrdinal("nurse_id");

            RoutineChecks? routineChecks = null;

            while (reader.Read())
            {
                var systolic = reader.GetFieldValueCheckNull<int>(systolicOrdinal);
                var diastolic = reader.GetFieldValueCheckNull<int>(diastolicOrdinal);
                var bodyTemp = reader.GetFieldValueCheckNull<int>(bodyTempOrdinal);
                var bpm = reader.GetFieldValueCheckNull<int>(bpmOrdinal);
                var symptoms = reader.GetFieldValueCheckNull<string>(symptomsOrdinal);
                var weight = reader.GetFieldValueCheckNull<decimal>(weightOrdinal);
                var height = reader.GetFieldValueCheckNull<decimal>(heightOrdinal);
                var nurseId = reader.GetFieldValueCheckNull<int>(nurseIdOrdinal);

                routineChecks = new RoutineChecks(appointmentId, systolic, diastolic, bodyTemp, bpm, symptoms, decimal.ToDouble(weight), decimal.ToDouble(height), nurseId);
            }

            return routineChecks;
        }
    }
}
