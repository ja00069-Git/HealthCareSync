using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    public class LabTestDAL
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabTestDAL"/> class.
        /// </summary>
        public LabTestDAL() { }

        /// <summary>
        /// Gets the lab tests.
        /// </summary>
        /// <returns></returns>
        public List<LabTest> GetLabTests()
        {
            var labTests = new List<LabTest>();

            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            using var command = new MySqlCommand("GetLabTests", connection);
            command.CommandType = CommandType.StoredProcedure;

            using var reader = command.ExecuteReader();
            var nameOrdinal = reader.GetOrdinal("name");
            var codeOrdinal = reader.GetOrdinal("code");
            var lowValueOrdinal = reader.GetOrdinal("low_value");
            var highValueOrdinal = reader.GetOrdinal("high_value");
            var unitOfMeasurementOrdinal = reader.GetOrdinal("unit_measurement");

            while (reader.Read())
            {
                labTests.Add(this.CreateLabTest(reader, nameOrdinal, codeOrdinal, lowValueOrdinal, highValueOrdinal, unitOfMeasurementOrdinal));
            }

            return labTests;
        }

        private LabTest CreateLabTest(MySqlDataReader reader, int nameOrdinal, int codeOrdinal, int lowValueOrdinal, int highValueOrdinal, int unitOfMeasurementOrdinal)
        {
            return new LabTest(
                reader.GetFieldValueCheckNull<string>(nameOrdinal),
                reader.GetFieldValueCheckNull<string>(codeOrdinal),
                decimal.ToDouble(reader.GetFieldValueCheckNull<decimal>(lowValueOrdinal)),
                decimal.ToDouble(reader.GetFieldValueCheckNull<decimal>(highValueOrdinal)),
                reader.GetFieldValueCheckNull<string>(unitOfMeasurementOrdinal)
            );
        }
    }
}
