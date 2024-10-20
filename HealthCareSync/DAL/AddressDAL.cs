using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.Models;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HealthCareSync.DAL
{
    public class AddressDAL
    {
        private readonly string connectionString = "server=cs-dblab01.uwg.westga.edu;uid=cs3230f24c;" +
             "pwd=ZIEbXBxGYTIGdXa>RbSJ;database=cs3230f24c;";

        public void DeleteUnreferencedAddresses()
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"delete from address
                            where not exists(
                            select 1 from patient where patient.address_id = address.id)";

            using var command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// Updates the address if exists else creates one.
        /// </summary>
        /// <param name="address_1">The address 1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address_2">The address 2.</param>
        /// <returns></returns>
        public int UpdateAddressIfExistsElseCreate(string address_1, string zip, string? city, string? state, string? address_2)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select count(1) from address where address_1 = @address_1 AND zip = @zip";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
            command.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;

            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count == 1) // An address exists
            {
                var updateAddressQuery = @"update address
                                           set address_2 = @address_2, state = @state, city = @city
                                           where address_1 = @address_1 and zip = @zip";

                using var updateAddressCommand = new MySqlCommand(updateAddressQuery, connection);
                updateAddressCommand.Parameters.Add("@address_2", MySqlDbType.VarChar).Value = address_2;
                updateAddressCommand.Parameters.Add("@state", MySqlDbType.VarString).Value = state;
                updateAddressCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
                updateAddressCommand.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
                updateAddressCommand.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;

                updateAddressCommand.ExecuteNonQuery();
            }
            else // An address doesn't exists
            {
                var createAddressQuery = @"insert into address (address_1, address_2, zip, state, city)
                                           values (@address_1, @address_2, @zip, @state, @city)";

                using var createAddressCommand = new MySqlCommand(createAddressQuery, connection);
                createAddressCommand.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
                createAddressCommand.Parameters.Add("@address_2", MySqlDbType.VarChar).Value = address_2;
                createAddressCommand.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;
                createAddressCommand.Parameters.Add("@state", MySqlDbType.VarChar).Value = state;
                createAddressCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

                createAddressCommand.ExecuteNonQuery();
            }

            // Return address id

            var retrieveIdQuery = @"select id from address where address_1 = @address_1 AND zip = @zip";

            using var retrieveIdCommand = new MySqlCommand(retrieveIdQuery, connection);
            retrieveIdCommand.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
            retrieveIdCommand.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;

            using var retrieveIdReader = retrieveIdCommand.ExecuteReader();
            var idOrdinal = retrieveIdReader.GetOrdinal("id");

            int id = 0;

            while (retrieveIdReader.Read())
            {
                id = retrieveIdReader.GetFieldValueCheckNull<int>(idOrdinal);
            }

            connection.Close();
            return id;
        }
    }
}
