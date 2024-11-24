namespace HealthCareSync.Models
{
    public static class Constants
    {
        public static string PHONE_NUMBER_REGEX_PATTERN = @"^(?:\+?(\d{1,3})[-.\s]?)?(\(?\d{3}\)?[-.\s]?)?\d{3}[-.\s]?\d{4}$";
        public static string ZIP_REGEX_PATTERN = @"^\d{5}$";
        public static string BIRTH_DATE_REGEX_PATTERN = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/([0-9]{4})$";
        public static string PASSWORD_REGEX_PATTERN = @"^[A-Za-z0-9]{6,}$";
        public static string ERROR_FIRST_NAME = "First name cannot be blank.";
        public static string ERROR_LAST_NAME = "Last name cannot be blank.";
        public static string ERROR_BIRTH_DATE = "Birth date must be in the format MM/dd/yyyy";
        public static string ERROR_PHONE_NUMBER = "Phone number must be 10 digits";
        public static string ERROR_PHONE_NUMBER_DASH = "Phone number must be 10 digits without dash";
        public static string ERROR_ADDRESS_1 = "Address 1 cannot be blank";
        public static string ERROR_ZIP = "Zip must be 5 digits";
        public static string ERROR_CITY = "Enter a city";
        public static string ERROR_STATE = "Select a state";
        public static string ERROR_USERNAME = "Username cannot be blank";
        public static string ERROR_USERNAME_TAKEN = "Username is already taken";
        public static string ERROR_PASSWORD = "Password must be more than 5 characters, letters and digits only";
    }
}
