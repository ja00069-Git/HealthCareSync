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
            if (!ValidateInputs())
                return false;

            using var connection = new MySqlConnection(Connection.ConnectionString());

            try
            {
                connection.Open();
                var userDetails = GetUserDetails(connection, User.Username);

                if (userDetails == null)
                {
                    ShowErrorMessage("Invalid username or password. Please try again.");
                    return false;
                }

                if (!VerifyPassword(User.Password, userDetails.Password))
                {
                    ShowErrorMessage("Invalid username or password. Please try again.");
                    return false;
                }

                AssignUserRole(userDetails);
                return true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred while connecting to the database.\nError: {ex.Message}");
                return false;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(User.Username))
            {
                ShowErrorMessage("Please enter your username.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(User.Password))
            {
                ShowErrorMessage("Please enter your password.");
                return false;
            }

            return true;
        }

        private UserDetails? GetUserDetails(MySqlConnection connection, string username)
        {
            string query = @"
                            SELECT 
                                COALESCE(a.fname, n.fname) AS fname,
                                COALESCE(a.lname, n.lname) AS lname,
                                CASE 
                                    WHEN a.username IS NOT NULL THEN 'Admin'
                                    WHEN n.username IS NOT NULL THEN 'Nurse'
                                END AS role,
                                u.password
                            FROM user u
                            LEFT JOIN administrator a ON u.username = a.username
                            LEFT JOIN nurse n ON u.username = n.username
                            WHERE u.username = @username 
                              AND (n.status = 'Active' OR a.username IS NOT NULL)";

            using var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);

            using var reader = command.ExecuteReader();
            if (!reader.Read())
                return null;

            return new UserDetails
            {
                FirstName = reader["fname"].ToString(),
                LastName = reader["lname"].ToString(),
                Role = reader["role"].ToString(),
                Password = reader["password"].ToString()!
            };
        }

        private bool VerifyPassword(string inputPassword, string storedPasswordHash)
        {
            return BC.EnhancedVerify(inputPassword, storedPasswordHash);
        }

        private void AssignUserRole(UserDetails userDetails)
        {
            LoggedInUser = $"{User.Username} ({userDetails.FirstName} {userDetails.LastName})";
            UserRole = userDetails.Role switch
            {
                "Admin" => UserRole.ADMIN,
                "Nurse" => UserRole.NURSE,
                _ => UserRole.NONE
            };
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private class UserDetails
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? Role { get; set; }
            public string Password { get; set; } = string.Empty;
        }
    }
}