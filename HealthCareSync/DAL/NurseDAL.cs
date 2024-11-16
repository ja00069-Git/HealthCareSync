using HealthCareSync.Enums;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace HealthCareSync.DAL
{
    internal class NurseDAL
    {
        private AddressDAL addressDAL;
        private UserDAL userDAL;

        private readonly string connectionString = Connection.ConnectionString();

        /**
         * Initializes a new instance of the Nurse data layer class.
         * @param addressDAL The address data layer.
         * @param userDAL The user data layer.
         * @pre addressDAL != null && userDAL != null
         * @post none
         * @return A new instance of the Nurse data layer class.
         */
        public NurseDAL() { this.addressDAL = new AddressDAL(); this.userDAL = new UserDAL(); }


        /**
         * Gets the nurse with the specified username.
         * @param username The username.
         * @pre username != null
         * @post none
         * @return The nurse with the specified username.
         */
        public Nurse? GetNurseWithUsername(string username)
        {
            Nurse nurse = null;

            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select  N.id as NurseId, A.id as AddressId, fname, lname, birth_date, phone_num, username, status,
                                  address_1, zip, state, city, address_2
                          from nurse N
                          left join address A on N.address_id = A.id
                          where (N.address_id = A.id OR N.address_id IS NULL) AND N.username = @username";

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
            var statusOrdinal = reader.GetOrdinal("status");

            while (reader.Read())
            {
                nurse = CreateNurse(reader, idOrdinal, addressIdOrdinal, fnameOrdinal,
                    lnameOrdinal, bdateOrdinal, phoneOrdinal, usernameOrdinal, statusOrdinal, address1Ordinal,
                    zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal);
            }

            return nurse;
        }

        /**
         * Gets the nurse with the specified id.
         * @param id The id.
         * @pre id != null
         * @post none
         * @return The nurse with the specified id.
         */
        public Nurse? GetNurseWithId(int? id)
        {
            Nurse nurse = null;

            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"select N.id as NurseId, A.id as AddressId, fname, lname, birth_date, phone_num, username, status,
                                 address_1, zip, state, city, address_2
                          from nurse N
                          left join address A on N.address_id = A.id
                          where (N.address_id = A.id OR N.address_id IS NULL) AND N.id = @id";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

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
            var statusOrdinal = reader.GetOrdinal("status");

            while (reader.Read())
            {
                nurse = CreateNurse(reader, idOrdinal, addressIdOrdinal, fnameOrdinal,
                    lnameOrdinal, bdateOrdinal, phoneOrdinal, usernameOrdinal, statusOrdinal, address1Ordinal,
                    zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal);
            }

            return nurse;
        }

        /**
         * Adds a nurse to the database.
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
         * @param flag The flag status.
         * @pre fname != null && lname != null && bdate != null && address_1 != null && zip != null && city != null && state != null && phone_num != null && username != null && password != null && flag != null
         * @post none
         * @return The id of the nurse.
         */
        public int AddNurse(string fname, string lname, DateTime bdate, string address_1,
            string zip, string city, string state, string? address_2, string phone_num, string username, string password, FlagStatus flag)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var query = @"insert into nurse (fname, lname, birth_date, phone_num, address_id, username, status)
                          values (@fname, @lname, @bdate, @phone_num, @address, @username, @status)";

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
                command.Parameters.Add("@status", MySqlDbType.VarChar).Value = flag.ToString().ToUpper();

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

        /**
         * Saves the edited patient.
         * @param id The id.
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
         * @param flag The flag status.
         * @param didUsernameChange If the username changed.
         * @pre id != null && fname != null && lname != null && bdate != null && address_1 != null && zip != null && city != null && state != null && phone_num != null && username != null && password != null && flag != null
         * @post none
         * @return none
         */
        public void SaveEditedNurse(int id, string fname, string lname, DateTime bdate, string address_1,
            string zip, string city, string state, string? address_2, string phone_num, string username, string password, FlagStatus flag, bool didUsernameChange)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var query = @"update nurse 
                        set fname = @fname, lname = @lname, address_id = @address_id,
                        birth_date = @bdate, phone_num = @phone_num, username = @username, status = @status
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
                command.Parameters.Add("@status", MySqlDbType.VarChar).Value = flag.ToString().ToUpper();

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

        /**
         * Gets the nurse with the specified id.
         * @param id The id.
         * @pre id != null
         * @post none
         * @return The nurse with the specified id.
         */
        public List<Nurse> GetNurses()
        {
            var nurseList = new List<Nurse>();
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            var query = @"select N.id as NurseId, A.id as AddressId, fname, lname, birth_date, phone_num, username, status, 
                                 address_1, zip, state, city, address_2
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
            var statusOrdinal = reader.GetOrdinal("status");

            while (reader.Read())
            {
                nurseList.Add(CreateNurse(reader, idOrdinal, addressIdOrdinal, fnameOrdinal, lnameOrdinal, bdateOrdinal,
                    phoneOrdinal, usernameOrdinal, statusOrdinal, address1Ordinal, zipOrdinal, stateOrdinal, cityOrdinal, address2Ordinal));
            }

            connection.Close();
            return nurseList;

        }

        /**
         * Creates a nurse from the specified reader.
         * @param reader The reader.
         * @param idOrdinal The id ordinal.
         * @param addressIdOrdinal The address id ordinal.
         * @param fnameOrdinal The first name ordinal.
         * @param lnameOrdinal The last name ordinal.
         * @param bdateOrdinal The birth date ordinal.
         * @param phoneOrdinal The phone number ordinal.
         * @param usernameOrdinal The username ordinal.
         * @param statusOrdinal The status ordinal.
         * @param address1Ordinal The first address ordinal.
         * @param zipOrdinal The zip ordinal.
         * @param stateOrdinal The state ordinal.
         * @param cityOrdinal The city ordinal.
         * @param address2Ordinal The second address ordinal.
         * @pre reader != null && idOrdinal != null && addressIdOrdinal != null && fnameOrdinal != null && lnameOrdinal != null && bdateOrdinal != null && phoneOrdinal != null && usernameOrdinal != null && statusOrdinal != null && address1Ordinal != null && zipOrdinal != null && stateOrdinal != null && cityOrdinal != null && address2Ordinal != null
         * @post none
         * @return The nurse.
         */
        private static Nurse CreateNurse(MySqlDataReader reader, int idOrdinal, int addressIdOrdinal, int fnameOrdinal, int lnameOrdinal, int bdateOrdinal,
            int phoneOrdinal, int usernameOrdinal, int statusOrdinal, int address1Ordinal, int zipOrdinal, int stateOrdinal,
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
                reader.GetFieldValueCheckNull<string?>(usernameOrdinal),
                Enum.Parse<FlagStatus>(reader.GetFieldValueCheckNull<string>(statusOrdinal).ToUpper())
            );

            return nurse;
        }


        /**
        /**
         * Checks if the nurse with the specified id can be deleted.
         * @param id The id.
         * @pre id != null
         * @post none
         * @return True if the nurse can be deleted, false otherwise.
         */
        public bool CanDeleteNurse(int id)
        {
            bool canDelete = false;

            string checkRoutineQuery = @"select count(*) from routine_checks where nurse_id = @id";

            using (var connection = new MySqlConnection(connectionString))
            using (var checkRoutineCommand = new MySqlCommand(checkRoutineQuery, connection))
            {
                checkRoutineCommand.Parameters.AddWithValue("@id", id);

                connection.Open();
                var routineCount = Convert.ToInt32(checkRoutineCommand.ExecuteScalar());

                if (routineCount == 0)
                {
                    canDelete = true;
                }
            }

            return canDelete;
        }

        /**
         * Deletes the nurse with the specified id.
         * @param id The id.
         * @pre id != null && CanDeleteNurse(id) == true
         * @post none
         * @return True if the nurse was deleted, false otherwise.
         */
        public bool DeleteNurse(int id)
        {
            bool isDeleted = false;

            if (CanDeleteNurse(id))
            {
                string deleteQuery = @"delete from nurse where id = @id";

                using (var connection = new MySqlConnection(connectionString))
                using (var deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    isDeleted = true;
                }
            }

            return isDeleted;
        }

        /**
         * Deactivates the nurse with the specified id.
         * @param id The id.
         * @pre id != null
         * @post none
         * @return True if the nurse was deactivated, false otherwise.
         */
        public bool DeactivateNurse(int id)
        {
            bool isDeactivated = false;

            string deactivateQuery = @"update nurse set status = 'INACTIVE' where id = @id";

            using (var connection = new MySqlConnection(connectionString))
            using (var deactivateCommand = new MySqlCommand(deactivateQuery, connection))
            {
                deactivateCommand.Parameters.AddWithValue("@id", id);

                connection.Open();
                deactivateCommand.ExecuteNonQuery();
                isDeactivated = true;
            }

            return isDeactivated;
        }
    }
}

