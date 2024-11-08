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
    internal class NurseDAL
    {
        private AddressDAL addressDAL;
        private UserDAL userDAL;

        private readonly string connectionString = Connection.ConnectionString();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatientDAL"/> class.
        /// </summary>
        public NurseDAL() { this.addressDAL = new AddressDAL(); this.userDAL = new UserDAL(); }

        /// <summary>
        /// Gets the nurse with username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public Nurse? GetNurseWithUsername(string username)
        {
            Nurse nurse = null;

            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select 
                            N.id as NurseId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            phone_num,  
                            username,
                            address_1,
                            zip, 
                            state, 
                            city, 
                            address_2
                          from nurse N
                          left join address A on N.address_id = A.id
                          where (N.address_id = A.id OR N.address_id IS NULL)
                                AND N.username = @username";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("NurseId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date"); ;
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var usernameOrdinal = reader.GetOrdinal("username");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                nurse = CreateNurse(reader, idOrdinal, addressIdOrdinal, fnameOrdinal,
                    lnameOrdinal, bdateOrdinal, phoneOrdinal, usernameOrdinal, address1Ordinal,
                    zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal);
            }

            return nurse;
        }

        /// <summary>
        /// Gets the nurse with identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Nurse? GetNurseWithId(int? id)
        {
            Nurse nurse = null;

            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select 
                            N.id as NurseId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            phone_num,  
                            username,
                            address_1,
                            zip, 
                            state, 
                            city, 
                            address_2
                          from nurse N
                          left join address A on N.address_id = A.id
                          where (N.address_id = A.id OR N.address_id IS NULL)
                                AND N.id = @id";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("NurseId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");;
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var usernameOrdinal = reader.GetOrdinal("username");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                nurse = CreateNurse(reader, idOrdinal, addressIdOrdinal, fnameOrdinal,
                    lnameOrdinal, bdateOrdinal, phoneOrdinal, usernameOrdinal, address1Ordinal,
                    zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal);
            }

            return nurse;
        }

        /// <summary>
        /// Adds the nurse.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="bdate">The bdate.</param>
        /// <param name="address_1">The address 1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address_2">The address 2.</param>
        /// <param name="phone_num">The phone number.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password</param>
        /// <returns></returns>
        public int AddNurse(string fname, string lname, DateTime bdate, string address_1,
            string zip, string city, string state, string? address_2, string phone_num, string username, string password)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var query = @"insert into nurse (fname, lname, birth_date, phone_num, address_id, username)
                          values (@fname, @lname, @bdate, @phone_num, @address, @username)";

            using var command = new MySqlCommand(query, connection);
            command.Transaction = transaction;

            int id = 0;

            this.userDAL.AddUser(username, password, connection);

            try
            {

                int address_id = this.addressDAL.UpdateAddressIfExistsElseCreate(connection, transaction, address_1!, zip!, city, Enum.Parse<State>(state.ToUpper()), address_2);

                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@address", MySqlDbType.Int32).Value = address_id;
                command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
                command.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

                command.ExecuteNonQuery();

                // retrieve nurse id
                var retrieveQuery = @"select LAST_INSERT_ID()";

                using var retrieveIdCommand = new MySqlCommand(retrieveQuery, connection);
                retrieveIdCommand.Transaction = transaction;

                id = Convert.ToInt32(retrieveIdCommand.ExecuteScalar());

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

        /// <summary>
        /// Deletes the nurse.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void DeleteNurse(int id)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = @"delete from nurse where id = @id";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            command.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Saves the edited nurse.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="bdate">The bdate.</param>
        /// <param name="address_1">The address 1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address_2">The address 2.</param>
        /// <param name="phone_num">The phone number.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password</param>
        /// <param name="didUsernameChange">The bool of if the username was changed</param>
        public void SaveEditedPatient(int id, string fname, string lname, DateTime bdate, string address_1,
            string zip, string city, string state, string? address_2, string phone_num, string username, string password, bool didUsernameChange)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var query = @"update nurse 
                        set fname = @fname, lname = @lname, address_id = @address_id,
                        birth_date = @bdate, phone_num = @phone_num, username = @username
                        where id = @id";

            using var command = new MySqlCommand(query, connection);
            command.Transaction = transaction;

            this.userDAL.SaveEditedUser(username, password, didUsernameChange, connection, transaction);

            try
            {
                int address_id = this.addressDAL.UpdateAddressIfExistsElseCreate(connection, transaction, address_1!, zip!, city, Enum.Parse<State>(state.ToUpper()), address_2);

                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@address_id", MySqlDbType.Int32).Value = address_id;
                command.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
                command.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                command.ExecuteNonQuery();

                this.addressDAL.DeleteUnreferencedAddresses(connection, transaction);
                this.userDAL.DeleteUnreferencedUsers(connection, transaction);

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

        /// <summary>
        /// Gets the patients.
        /// </summary>
        /// <returns></returns>
        public List<Nurse> GetNurses()
        {
            var nurseList = new List<Nurse>();
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = @"select 
                            N.id as NurseId, 
                            A.id as AddressId, 
                            fname, 
                            lname, 
                            birth_date, 
                            phone_num, 
                            username, 
                            address_1, 
                            zip, 
                            state, 
                            city, 
                            address_2
                          from nurse N
                          left join address A on N.address_id = A.id
                          where N.address_id = A.id OR N.address_id IS NULL";

            using var command = new MySqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            var idOrdinal = reader.GetOrdinal("NurseId");
            var addressIdOrdinal = reader.GetOrdinal("AddressId");
            var fnameOrdinal = reader.GetOrdinal("fname");
            var lnameOrdinal = reader.GetOrdinal("lname");
            var bdateOrdinal = reader.GetOrdinal("birth_date");
            var phoneOrdinal = reader.GetOrdinal("phone_num");
            var usernameOrdinal = reader.GetOrdinal("username");
            var address1Ordinal = reader.GetOrdinal("address_1");
            var zipOrdinal = reader.GetOrdinal("zip");
            var stateOrdinal = reader.GetOrdinal("state");
            var cityOrdinal = reader.GetOrdinal("city");
            var address2Ordinal = reader.GetOrdinal("address_2");

            while (reader.Read())
            {
                nurseList.Add(CreateNurse(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    phoneOrdinal, usernameOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            connection.Close();
            return nurseList;

        }

        private static Nurse CreateNurse(MySqlDataReader reader, int idOrdinal, int addressIdOrdinal, int fnameOrdinal, int lnameOrdinal, int bdateOrdinal,
            int phoneOrdinal, int usernameOrdinal, int address1Ordinal, int zipOrdinal, int stateOrdinal,
            int cityOrdinal, int address2Ordinal)
        {
            var address1 = reader.GetFieldValueCheckNull<string?>(address1Ordinal);
            var zip = reader.GetFieldValueCheckNull<string?>(zipOrdinal);

            var address = new Address(
                reader.GetFieldValueCheckNull<Int32>(addressIdOrdinal),
                address1,
                zip,
                reader.GetFieldValueCheckNull<string?>(cityOrdinal),
                Enum.Parse<State>(reader.GetFieldValueCheckNull<string?>(stateOrdinal).ToUpper()),
                reader.GetFieldValueCheckNull<string?>(address2Ordinal)
            );

            var nurse = new Nurse(
                reader.GetFieldValueCheckNull<int>(idOrdinal),
                reader.GetFieldValueCheckNull<string>(fnameOrdinal),
                reader.GetFieldValueCheckNull<string>(lnameOrdinal),
                reader.GetFieldValueCheckNull<DateTime>(bdateOrdinal),
                reader.GetFieldValueCheckNull<string?>(phoneOrdinal),
                address,
                reader.GetFieldValueCheckNull<string?>(usernameOrdinal)
            );

            return nurse;
        }
    }
}

