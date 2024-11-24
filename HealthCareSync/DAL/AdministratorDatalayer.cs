using HealthCareSync.Enums;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    public class AdministratorDatalayer
    {
        private AddressDAL addressDAL;
        private UserDAL userDAL;

        private readonly string connectionString = Connection.ConnectionString();

        /**
         * Initializes a new instance of the Administrator data layer class.
         * @param addressDAL The address data layer.
         * @param userDAL The user data layer.
         * @pre addressDAL != null && userDAL != null
         * @post none
         * @return A new instance of the Nurse data layer class.
         */
        public AdministratorDatalayer() { this.addressDAL = new AddressDAL(); this.userDAL = new UserDAL(); }

        /**
         * Adds an administrator to the database.
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
         * @pre fname != null && lname != null && bdate != null && address_1 != null && zip != null && city != null && state != null && phone_num != null && username != null && password != null
         * @post none
         * @return The id of the administrator.
         */
        public int SignUpAnAdmin(string fname, string lname, DateTime bdate, string address_1,
            string zip, string city, string state, string? address_2, string phone_num, string username, string password)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var adminQuery = @"insert into administrator (fname, lname, birth_date, phone_num, address_id, username)
                               values (@fname, @lname, @bdate, @phone_num, @address, @username)";

            using var adminCommand = new MySqlCommand(adminQuery, connection);
            adminCommand.Transaction = transaction;

            int id = 0;

            try
            {
                // Insert into user table using UserDAL
                if (!this.userDAL.AddUser(username, password, connection))
                {
                    MessageBox.Show("Failed to sign up a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Insert or update address and get address_id
                int address_id = this.addressDAL.UpdateAddressIfExistsElseCreate(connection, transaction, address_1!, zip!, city, Enum.Parse<State>(state.ToUpper()), address_2);

                // Insert into administrator table
                adminCommand.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
                adminCommand.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
                adminCommand.Parameters.Add("@address", MySqlDbType.Int32).Value = address_id;
                adminCommand.Parameters.Add("@bdate", MySqlDbType.Date).Value = bdate;
                adminCommand.Parameters.Add("@phone_num", MySqlDbType.VarChar).Value = phone_num;
                adminCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                adminCommand.ExecuteNonQuery();

                // Retrieve administrator id
                var retrieveQuery = @"select LAST_INSERT_ID()";
                using var retrieveIdCommand = new MySqlCommand(retrieveQuery, connection);
                retrieveIdCommand.Transaction = transaction;
                id = Convert.ToInt32(retrieveIdCommand.ExecuteScalar());

                transaction.Commit();
            }
            catch (Exception)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception rollbackEx)
                {
                    MessageBox.Show("Rollback failed: " + rollbackEx.Message);
                }
            }

            return id;
        }
    }
}
