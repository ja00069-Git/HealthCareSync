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

        public bool AddUser(string username, string password)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

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

        public bool SaveEditedUser(string username, string password, bool didUsernameChange)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            if (didUsernameChange)
            {
                if (!this.AddUser(username, password))
                {
                    return false;
                }
                this.deleteUnreferencedUsers(connection);
            }
            

            var query = @"UPDATE user
                          SET password = @password
                          WHERE username = @username";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            command.ExecuteNonQuery();

            return true;
        }

        public User GetUser(string username)
        {
            using var connection = new MySqlConnection(Connection.ConnectionString());

            connection.Open();

            var query = @"SELECT username, password
                          FROM user
                          WHERE username = @username";

            using var command = new MySqlCommand(query, connection);
            
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            using var reader = command.ExecuteReader();

            var usernameOrdinal = reader.GetOrdinal("username");
            var passwordOrdinal = reader.GetOrdinal("password");

            var user_name = reader.GetFieldValueCheckNull<string>(usernameOrdinal);
            var password = reader.GetFieldValueCheckNull<string>(passwordOrdinal);

            return new User(username, password);
        }

        private bool isUsernameAvailable(string username, MySqlConnection connection)
        {
            var query = @"SELECT COUNT(1)
                          FROM user
                          WHERE username = @username";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

            int count = (int)command.ExecuteScalar();
            
            return count == 0;   
        }

        private void deleteUnreferencedUsers(MySqlConnection connection)
        {

            var query = @"DELETE FROM user
                            where not exists(
                            SELECT 1 from administrator where administrator.username = user.username
                            union
                            SELECT 1 from nurse where nurse.username = user.username)";

            using var command = new MySqlCommand(query, connection);

            command.ExecuteNonQuery();

        }
    }
}
