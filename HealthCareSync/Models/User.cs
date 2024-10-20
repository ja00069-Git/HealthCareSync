namespace HealthCareSync.Models
{
    /**
     * The user model class
     * @author Jabesi
     * @version Fall 2024
     */
    public class User
    {
        /**
         * The username property
         * @precondition none
         * @postcondition none
         */
        public string Username { get; set; } = string.Empty;

        /**
         * The password property
         * @precondition none
         * @postcondition none
         */
        public string Password { get; set; } = string.Empty;

        /**
         * The default constructor for the user model class
         * @precondition none
         * @postcondition none
         */
        public User() { }

        /**
         * The parameterized constructor that initializes the username and password properties
         * @precondition none
         * @postcondition none
         */
        public User(string username, string password) : this()
        {
            Username = username;
            Password = password;
        }
    }
}
