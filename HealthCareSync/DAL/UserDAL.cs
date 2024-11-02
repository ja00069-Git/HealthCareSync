using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using HealthCareSync.Models;
using MySql.Data.MySqlClient;

namespace HealthCareSync.DAL
{
    public class UserDAL
    {

        public UserDAL() { }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="connection">The connection.</param>
        /// <returns></returns>
        public bool AddUser(string username, string password, MySqlConnection connection)
        {
            if (!this.isUsernameAvailable(username, connection))
            {
                return false;
            }

            var query = @"INSERT INTO user 
                          VALUES
                          (@username, @password);";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            command.ExecuteNonQuery();

            return true;
        }

        /// <summary>
        /// Saves the edited user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="didUsernameChange">if set to <c>true</c> [did username change].</param>
        /// <param name="connection">The connection.</param>
        /// <param name="transaction">The transaction.</param>
        /// <returns></returns>
        public bool SaveEditedUser(string username, string password, bool didUsernameChange, MySqlConnection connection, MySqlTransaction transaction)
        {

            if (didUsernameChange)
            {
                if (!this.AddUser(username, password, connection))
                {
                    return false;
                }
            }
            

            var query = @"UPDATE user
                          SET password = @password
                          WHERE username = @username";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            command.Transaction = transaction;

            command.ExecuteNonQuery();

            return true;
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public User? GetUser(string username)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"SELECT password
                          FROM user
                          WHERE username = @username";

            using var command = new MySqlCommand(query, connection);
            
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            using var reader = command.ExecuteReader();

            var passwordOrdinal = reader.GetOrdinal("password");

            var password = string.Empty;

            while (reader.Read())
            {
                password = reader.GetFieldValueCheckNull<string>(passwordOrdinal);

            }
            
            if (string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            return new User(username, password);
        }

        private bool isUsernameAvailable(string username, MySqlConnection connection)
        {
            var query = @"SELECT COUNT(1)
                          FROM user
                          WHERE username = @username";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count == 0;   
        }

        /// <summary>
        /// Determines whether [is username available] [the specified username].
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>
        ///   <c>true</c> if [is username available] [the specified username]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsUsernameAvailable(string username)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"SELECT COUNT(1)
                          FROM user
                          WHERE username = @username";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            int count = Convert.ToInt32(command.ExecuteScalar());

            return count == 0;
        }

        /// <summary>
        /// Deletes the unreferenced users.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="transaction">The transaction.</param>
        public void DeleteUnreferencedUsers(MySqlConnection connection, MySqlTransaction transaction)
        {

            var query = @"DELETE FROM user
                            where not exists(
                            SELECT 1 from administrator where administrator.username = user.username
                            union
                            SELECT 1 from nurse where nurse.username = user.username)";

            using var command = new MySqlCommand(query, connection);

            command.Transaction = transaction;

            command.ExecuteNonQuery();

        }
    }
}
