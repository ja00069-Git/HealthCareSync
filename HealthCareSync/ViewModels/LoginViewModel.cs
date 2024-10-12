using HealthCareSync.Models;
using MySql.Data.MySqlClient;

namespace HealthCareSync.ViewModels
{
    public class LoginViewModel
    {
        //private readonly string connectionString = "Server=cs-dblab01.uwg.westga.edu;Database=cs3230f24c;User Id=cs3230f24c;Password=ZIEbXBxGYTIGdXa>RbSJ;";
        private readonly string connectionString = "server=cs-dblab01.uwg.westga.edu; port=3306; uid=cs3230f24c;" +
             "pwd=ZIEbXBxGYTIGdXa>RbSJ;database=cs3230f24c;";

        public User User { get; set; }

        public LoginViewModel()
        {
            User = new User();
        }
        public bool Login()
        {
            // Simple input validation
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

            // SQL Server Authentication Logic
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(1) FROM user WHERE username=@username AND password=@password";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Prevent SQL Injection by using parameterized queries
                        command.Parameters.AddWithValue("@username", User.Username);
                        command.Parameters.AddWithValue("@password", User.Password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
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
