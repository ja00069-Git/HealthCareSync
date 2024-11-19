using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    public class DiagnosesDAL
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosesDAL"/> class.
        /// </summary>
        public DiagnosesDAL() { }

        /// <summary>
        /// Enters the diagnoses.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="inital">The inital.</param>
        /// <param name="final">The final.</param>
        public void EnterDiagnoses(int appointmentId, string? inital, string? final)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = string.Empty;

            if (this.diagnosesExist(appointmentId, connection))
            {
                if (string.IsNullOrWhiteSpace(inital))
                {
                    query = @"UPDATE diagnoses
                              SET final_diagnoses = @final
                              WHERE appointment_id = @appointmentId";

                    using var command = new MySqlCommand(query, connection);

                    command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    command.Parameters.Add("@final", MySqlDbType.Text).Value = final;

                    command.ExecuteNonQuery();
                }
                else if (string.IsNullOrWhiteSpace(final))
                {
                    query = @"UPDATE diagnoses
                              SET initial_diagnoses = @initial
                              WHERE appointment_id = @appointmentId";

                    using var command = new MySqlCommand(query, connection);

                    command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    command.Parameters.Add("@initial", MySqlDbType.Text).Value = inital;

                    command.ExecuteNonQuery();
                }
                else
                {
                    query = @"UPDATE diagnoses
                              SET final_diagnoses = @final, initial_diagnoses = @initial
                              WHERE appointment_id = @appointmentId";

                    using var command = new MySqlCommand(query, connection);

                    command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    command.Parameters.Add("@initial", MySqlDbType.Text).Value = inital;
                    command.Parameters.Add("@final", MySqlDbType.Text).Value = final;

                    command.ExecuteNonQuery();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(inital))
                {
                    query = @"INSERT INTO diagnoses (appointment_id, final_diagnoses)
                                VALUES
                                (@appointmentId, @final)";

                    using var command = new MySqlCommand(query, connection);

                    command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    command.Parameters.Add("@final", MySqlDbType.Text).Value = final;

                    command.ExecuteNonQuery();
                }
                else if (string.IsNullOrWhiteSpace(final))
                {
                    query = @"INSERT INTO diagnoses (appointment_id, initial_diagnoses)
                                 VALUES
                                 (@appointmentId, @initial)";

                    using var command = new MySqlCommand(query, connection);

                    command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    command.Parameters.Add("@initial", MySqlDbType.Text).Value = inital;

                    command.ExecuteNonQuery();
                }
                else
                {
                    query = @"INSERT INTO diagnoses (appointment_id, initial_diagnoses, final_diagnoses)
                                VALUES
                                (@appointmentId, @initial, @final)";

                    using var command = new MySqlCommand(query, connection);

                    command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;
                    command.Parameters.Add("@initial", MySqlDbType.Text).Value = inital;
                    command.Parameters.Add("@final", MySqlDbType.Text).Value = final;

                    command.ExecuteNonQuery();
                }
            }         
        }

        private bool diagnosesExist(int appointmentId, MySqlConnection connection)
        {
            var query = @"SELECT COUNT(1)
                            FROM diagnoses
                            WHERE appointment_id = @appointmentId";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

            var count = Convert.ToInt32(command.ExecuteScalar());

            return count > 0;
        }

        /// <summary>
        /// Gets the diagnoses.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <returns></returns>
        public Diagnoses? GetDiagnoses(int appointmentId)
        {

            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"SELECT initial_diagnoses, final_diagnoses
                            FROM diagnoses
                            WHERE appointment_id = @appointmentId";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = appointmentId;

            using var reader = command.ExecuteReader();
            var initialOrdinal = reader.GetOrdinal("initial_diagnoses");
            var finalOrdinal = reader.GetOrdinal("final_diagnoses");

            while (reader.Read())
            {
                return CreateDiagnoses(reader, appointmentId, initialOrdinal, finalOrdinal);
            }

            return null;
        }

        private Diagnoses CreateDiagnoses(MySqlDataReader reader, int appointmentId, int initialOrdinal, int finalOrdinal)
        {
            return new Diagnoses(
                appointmentId,
                reader.GetFieldValueCheckNull<string?>(initialOrdinal),
                reader.GetFieldValueCheckNull<string?>(finalOrdinal)
            );
        }
    }
}
