
namespace HealthCareSync.Models
{
    /**
     * The administrator model class
     * @author Jabesi
     * @version Fall 2024
     */
    public class Administrator
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private DateTime birthDate;
        private string phoneNumber = string.Empty;
        private Address address = new Address();
        private string username = string.Empty;

        /**
         * Gets the administrator's Id.
         * @precondition none
         * @postcondition none
         * @return the administrator's Id
         */
        public int Id { get; }

        /**
         * Gets the first name and sets the first name.
         * @precondition none
         * @postcondition none
         * @return the flag flagStatus
         */
        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        /**
         * Gets the last name and sets the last name.
         * @precondition none
         * @postcondition none
         * @return the last name
         */
        public string LastName
        {
            get => this.lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        /**
         * Gets the full name from the first and last name concatenated.
         * @precondition none
         * @postcondition none
         * @return the full name
         */
        public string FullName => this.FirstName + " " + this.LastName;

        /**
         * Gets the birth date and sets the birth date.
         * @precondition none
         * @postcondition none
         * @return the birth date
         */
        public DateTime BirthDate
        {
            get => this.birthDate;
            set
            {
                this.birthDate = value;
            }
        }

        /**
         * Gets the formatted birth date.
         * @precondition none
         * @postcondition none
         * @return the formatted birth date
         */
        public string FormattedBirthDate => this.BirthDate.ToString("MM/dd/yyyy");

        /**
         * Gets the phone number and sets the phone number.
         * @precondition none
         * @postcondition none
         * @return the phone number
         */
        public string PhoneNumber
        {
            get => this.phoneNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Phone number cannot be null or empty");
                }

                this.phoneNumber = value.Trim();
            }
        }

        /**
         * Gets the address Id.
         * @precondition none
         * @postcondition none
         * @return the address Id
         */
        public int AddressId => this.Address.Id;

        /**
         * Gets the address and sets the address.
         * @precondition none
         * @postcondition none
         * @return the flag flagStatus
         */
        public Address Address
        {
            get => this.address;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Address cannot be null");
                }

                this.address = value;
            }
        }

        /**
         * Gets the username and sets the username.
         * @precondition none
         * @postcondition none
         * @return the username
         */
        public string Username
        {
            get => this.username;
            set
            {
                this.username = value;
            }
        }

        /**
         * Initializes a new instance of the Administrator class.
         * @param id the administrator's Id
         * @param fname the first name
         * @param lname the last name
         * @param birthDate the birth date
         * @param phoneNum the phone number
         * @param address the address
         * @param username the username
         * @precondition none
         * @postcondition none
         * @return a new instance of the Administrator class
         */
        public Administrator(int id, string fname, string lname, DateTime birthDate, string phoneNum, Address address, string username)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("Administrator's Id has to be more than 0");
            }

            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = birthDate;
            this.PhoneNumber = phoneNum;
            this.address = address;
            this.Username = username;
        }

        /**
         * Initializes a new instance of the Administrator class.
         * @param fname the first name
         * @param lname the last name
         * @param birthDate the birth date
         * @param phoneNum the phone number
         * @param address the address
         * @param username the username
         * @precondition none
         * @postcondition none
         * @return a new instance of the Administrator class
         */
        public Administrator(string fname, string lname, DateTime birthDate, string phoneNum, Address address, string username)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = birthDate;
            this.PhoneNumber = phoneNum;
            this.Address = address;
            this.Username = username;
        }
    }
}
