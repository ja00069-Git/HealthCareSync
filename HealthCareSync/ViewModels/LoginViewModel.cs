using MySql.Data.MySqlClient;
using HealthCareSync.Models;
using HealthCareSync.DAL;
using HealthCareSync.Enums;

namespace HealthCareSync.ViewModels
{
    /**
     * The view model for the login form
     * @author Jabesi
     * @version Fall 2024
     */
    public class LoginViewModel
    {
        public User User { get; set; }
        public string LoggedInUser { get; set; } = string.Empty;
        public UserRole UserRole { get; set; } = UserRole.NONE;

        public LoginViewModel()
        {
            User = new User();
        }

        /**
         * Logs the user in to the system using the provided username and password
         * Contol access to the system based on the user's role
         * @precondition none
         * @postcondition none
         * @return true if the user was logged in successfully, false otherwise
         */
        public bool Login()
        {
            if (string.IsNullOrWhiteSpace(User.Username))
            {
                MessageBox.Show("Please enter your username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(User.Password))
            {
                MessageBox.Show("Please enter your password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (MySqlConnection connection = new MySqlConnection(Connection.ConnectionSting()))
            {
                try
                {
                    connection.Open();

                    string query = @"
                  SELECT 
                     COALESCE(a.fname, n.fname) AS fname,
                     COALESCE(a.lname, n.lname) AS lname,
                     CASE 
                        WHEN a.username IS NOT NULL THEN 'Admin'
                        WHEN n.username IS NOT NULL THEN 'Nurse'
                     END AS role
                  FROM user u
                  LEFT JOIN administrator a ON u.username = a.username
                  LEFT JOIN nurse n ON u.username = n.username
                  WHERE u.username = @username AND u.password = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", User.Username);
                        command.Parameters.AddWithValue("@password", User.Password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LoggedInUser = reader["fname"].ToString() + " " + reader["lname"].ToString();

                                string? roleString = reader["role"] as string;
                                UserRole = roleString switch
                                {
                                    "Admin" => UserRole.ADMIN,
                                    "Nurse" => UserRole.NURSE,
                                    _ => UserRole.NONE
                                };

                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database. Please check your connection settings.\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}