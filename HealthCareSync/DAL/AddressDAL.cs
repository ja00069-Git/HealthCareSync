﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.Models;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using HealthCareSync.Enums;

namespace HealthCareSync.DAL
{
    /// <summary>
    ///  Handles all proccesses involving database management of the address table
    /// </summary>
    public class AddressDAL
    {

        /// <summary>
        /// Deletes all unreferenced addresses
        /// <param name="connection">The connection</param>
        /// <param name="transaction">The transaction</param>
        /// </summary>
        public void DeleteUnreferencedAddresses(MySqlConnection connection, MySqlTransaction transaction)
        {
            var query = @"delete from address
                            where not exists(
                            select 1 from patient where patient.address_id = address.id
                            union
                            select 1 from administrator where administrator.address_id = address.id
                            union
                            select 1 from nurse where nurse.address_id = address.id
                            union                            
                            select 1 from doctor where doctor.address_id = address.id)";

            using var command = new MySqlCommand(query, connection);
            command.Transaction = transaction;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates the address if exists else creates one.
        /// </summary>
        /// <param name="connection">The connection</param>
        /// <param name="transaction">The transaction</param>
        /// <param name="address_1">The address 1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address_2">The address 2.</param>
        /// <returns></returns>
        public int UpdateAddressIfExistsElseCreate(MySqlConnection connection, MySqlTransaction transaction, string address_1, string zip, string? city, State? state, string? address_2)
        {
            var query = @"select count(1) from address where address_1 = @address_1 AND zip = @zip";

            using var command = new MySqlCommand(query, connection);
            command.Transaction = transaction;

            command.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
            command.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;

            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count == 1) // An address exists
            {
                var updateAddressQuery = @"update address
                                           set address_2 = @address_2, state = @state, city = @city
                                           where address_1 = @address_1 and zip = @zip";

                using var updateAddressCommand = new MySqlCommand(updateAddressQuery, connection);
                updateAddressCommand.Transaction = transaction;

                updateAddressCommand.Parameters.Add("@address_2", MySqlDbType.VarChar).Value = address_2;
                updateAddressCommand.Parameters.Add("@state", MySqlDbType.VarString).Value = state.ToString();
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
                createAddressCommand.Transaction = transaction;

                createAddressCommand.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
                createAddressCommand.Parameters.Add("@address_2", MySqlDbType.VarChar).Value = address_2;
                createAddressCommand.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;
                createAddressCommand.Parameters.Add("@state", MySqlDbType.VarChar).Value = state.ToString();
                createAddressCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;

                createAddressCommand.ExecuteNonQuery();
            }

            // Return address id

            var retrieveIdQuery = @"select id from address where address_1 = @address_1 AND zip = @zip";

            using var retrieveIdCommand = new MySqlCommand(retrieveIdQuery, connection);
            retrieveIdCommand.Transaction = transaction;

            retrieveIdCommand.Parameters.Add("@address_1", MySqlDbType.VarChar).Value = address_1;
            retrieveIdCommand.Parameters.Add("@zip", MySqlDbType.VarChar).Value = zip;

            using var retrieveIdReader = retrieveIdCommand.ExecuteReader();
            var idOrdinal = retrieveIdReader.GetOrdinal("id");

            int id = 0;

            while (retrieveIdReader.Read())
            {
                id = retrieveIdReader.GetFieldValueCheckNull<int>(idOrdinal);
            }

            return id;
        }
    }
}
