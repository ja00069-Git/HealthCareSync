using MySql.Data.MySqlClient;
using HealthCareSync.Models;
namespace HealthCareSync.ViewModels
{
    public class LoginViewModel
    {
        private readonly string connectionString = "server=cs-dblab01.uwg.westga.edu;uid=cs3230f24c;" +
             "pwd=ZIEbXBxGYTIGdXa>RbSJ;database=cs3230f24c;";

        public User User { get; set; }
        public string LogedInUser { get; set; } = string.Empty;

        public LoginViewModel()
        {
            User = new User();
        }

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

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(1) FROM user WHERE username=@username AND password=@password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", User.Username);
                        command.Parameters.AddWithValue("@password", User.Password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
                        {
                            LogedInUser = User.Username;
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
