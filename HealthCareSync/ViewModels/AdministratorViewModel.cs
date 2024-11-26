using HealthCareSync.DAL;
using HealthCareSync.Enums;
using System.ComponentModel;

namespace HealthCareSync.ViewModels
{
    /**
         * The view model for managing nurses
         * @author Jabesi, Ahmad, Md
         * @version Fall 2024
         */
    public class AdministratorViewModel : INotifyPropertyChanged
    {
        private AdministratorDatalayer adminDAL;
        private UserDAL userDAL;

        /**
         * Gets the first name.
         * @precondition The selected nurse is not null.
         * @postcondition The first name is returned.
         * @return The first name.
         */
        public string? FirstName { get; set; }

        /**
         * Gets the last name.
         * @precondition The selected nurse is not null.
         * @postcondition The last name is returned.
         * @return The last name.
         */
        public string? LastName { get; set; }

        /**
         * Gets the formatted birth date.
         * @precondition The selected nurse is not null.
         * @postcondition The formatted birth date is returned.
         * @return The formatted birth date.
         */
        public string? FormattedBirthDate { get; set; }

        /**
         * Gets the phone number.
         * @precondition The selected nurse is not null.
         * @postcondition The phone number is returned.
         * @return The phone number.
         */
        public string? PhoneNumber { get; set; }

        /**
         * Gets the nurse identifier.
         * @precondition The selected nurse is not null.
         * @postcondition The nurse identifier is returned.
         * @return The nurse identifier.
         */
        public int Nurse_Id { get; set; }

        /**
         * Gets the username.
         * @precondition The selected nurse is not null.
         * @postcondition The username is returned.
         * @return The username.
         */
        public string? Username { get; set; }

        public string? Password { get; set; }

        /**
         * Gets the address1.
         * @precondition The selected nurse is not null.
         * @postcondition The address1 is returned.
         * @return The address1.
         */
        public string? Address_1 { get; set; }

        /**
         * Gets the zip.
         * @precondition The selected nurse is not null.
         * @postcondition The zip is returned.
         * @return The zip.
         */
        public string? Zip { get; set; }

        /**
         * Gets the city.
         * @precondition The selected nurse is not null.
         * @postcondition The city is returned.
         * @return The city.
         */
        public string? City { get; set; }

        /**
         * Gets the state.
         * @precondition The selected nurse is not null.
         * @postcondition The state is returned.
         * @return The state.
         */
        public State? State { get; set; }

        /**
         * Gets the address2.
         * @precondition The selected nurse is not null.
         * @postcondition The address2 is returned.
         * @return The address2.
         */
        public string? Address_2 { get; set; }

        /**
         * Gets the selected nurse as user.
         * @precondition The selected nurse is not null.
         * @postcondition The selected nurse as user is returned.
         * @return The selected nurse as user.
         */
        public event PropertyChangedEventHandler? PropertyChanged;

        /**
         * Gets the states.
         * @postcondition The states are returned.
         * @return The states.
         */
        public List<State> States => Enum.GetValues(typeof(State)).Cast<State>().ToList();

        /**
         * Gets the selected nurse as user.
         * @precondition The selected nurse is not null.
         * @postcondition The selected nurse as user is returned.
         * @return The selected nurse as user.
         */
        public AdministratorViewModel()
        {
            this.adminDAL = new AdministratorDatalayer();
            this.userDAL = new UserDAL();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /**
         * Adds a nurse to the database
         * @param fname The first name.
         * @param lname The last name.
         * @param bDate The birth date.
         * @param phoneNum The phone number.
         * @param address1 The address1.
         * @param zip The zip.
         * @param city The city.
         * @param state The state.
         * @param address2 The address2.
         * @param username The username.
         * @param password The password.
         * @param flag The flag status.
         * @pecondition The username is available and the password is valid.
         * @postcondition The nurse is added to the database
         */
        public void Add(string fname, string lname, DateTime bDate, string phoneNum, string address1, string zip, 
            string city, string state, string? address2, string username, string password)
        {
            this.adminDAL.SignUpAnAdmin(fname, lname, bDate, address1, zip, city, state, address2, phoneNum, username, password);
        }

        public bool IsUsernameAvailable(string username)
        {
            return this.userDAL.IsUsernameAvailable(username);
        }
    }
}

