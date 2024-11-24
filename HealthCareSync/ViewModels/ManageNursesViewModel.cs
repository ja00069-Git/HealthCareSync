using HealthCareSync.DAL;
using HealthCareSync.Enums;
using HealthCareSync.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace HealthCareSync.ViewModels
{
    /**
     * The view model for managing nurses
     * @author Jabesi, Ahmad, Md
     * @version Fall 2024
     */
    public class ManageNursesViewModel : INotifyPropertyChanged
    {
        private Nurse? selectedNurse;
        private User? selectedNurseAsUser;
        private NurseDAL nurseDAL;
        private UserDAL userDAL;


        /**
         * Gets the flag status.
         * @precondition The selected nurse is not null.
         * @postcondition The flag status is returned.
         * @return The flag status.
         */
        public FlagStatus? FlagStatus => SelectedNurse?.FlagStatus;


        /**
         * Gets the first name.
         * @precondition The selected nurse is not null.
         * @postcondition The first name is returned.
         * @return The first name.
         */
        public string? FirstName => SelectedNurse?.FirstName;


        /**
         * Gets the last name.
         * @precondition The selected nurse is not null.
         * @postcondition The last name is returned.
         * @return The last name.
         */
        public string? LastName => SelectedNurse?.LastName;


        /**
         * Gets the formatted birth date.
         * @precondition The selected nurse is not null.
         * @postcondition The formatted birth date is returned.
         * @return The formatted birth date.
         */
        public string? FormattedBirthDate => SelectedNurse?.FormattedBirthDate;


        /**
         * Gets the phone number.
         * @precondition The selected nurse is not null.
         * @postcondition The phone number is returned.
         * @return The phone number.
         */
        public string? PhoneNumber => SelectedNurse?.PhoneNumber;


        /**
         * Gets the nurse identifier.
         * @precondition The selected nurse is not null.
         * @postcondition The nurse identifier is returned.
         * @return The nurse identifier.
         */
        public int Nurse_Id => SelectedNurse?.Id ?? 0;


        /**
         * Gets the username.
         * @precondition The selected nurse is not null.
         * @postcondition The username is returned.
         * @return The username.
         */
        public string? Username => SelectedNurse?.Username;

        public string? Password => selectedNurseAsUser?.Password;



        /**
         * Gets the address1.
         * @precondition The selected nurse is not null.
         * @postcondition The address1 is returned.
         * @return The address1.
         */
        public string? Address_1 => SelectedNurse?.Address?.Address_1;

        /**
         * Gets the zip.
         * @precondition The selected nurse is not null.
         * @postcondition The zip is returned.
         * @return The zip.
         */
        public string? Zip => SelectedNurse?.Address?.Zip;


        /**
         * Gets the city.
         * @precondition The selected nurse is not null.
         * @postcondition The city is returned.
         * @return The city.
         */
        public string? City => SelectedNurse?.Address?.City;


        /**
         * Gets the state.
         * @precondition The selected nurse is not null.
         * @postcondition The state is returned.
         * @return The state.
         */
        public State? State => SelectedNurse?.Address?.State;


        /**
         * Gets the address2.
         * @precondition The selected nurse is not null.
         * @postcondition The address2 is returned.
         * @return The address2.
         */
        public string? Address_2 => SelectedNurse?.Address?.Address_2;


        /**
         * Gets the flag statuses.
         * @postcondition The flag statuses are returned.
         * @return The flag statuses.
         */
        public List<FlagStatus> FlagStatuses => Enum.GetValues(typeof(FlagStatus)).Cast<FlagStatus>().ToList();


        /**
         * Gets the selected nurse as user.
         * @precondition The selected nurse is not null.
         * @postcondition The selected nurse as user is returned.
         * @return The selected nurse as user.
         */
        public event PropertyChangedEventHandler? PropertyChanged;


        /**
         * Gets the selected nurse.
         * @precondition The selected nurse is not null.
         * @postcondition The selected nurse is returned.
         * @return The selected nurse.
         */
        public Nurse SelectedNurse
        {
            get { return selectedNurse!; }
            set
            {
                if (selectedNurse != value)
                {
                    selectedNurse = value;
                    selectedNurseAsUser = this.userDAL.GetUser(Username!)!;
                    OnPropertyChanged(nameof(SelectedNurse));
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(FormattedBirthDate));
                    OnPropertyChanged(nameof(PhoneNumber));
                    OnPropertyChanged(nameof(Nurse_Id));
                    OnPropertyChanged(nameof(Username));
                    OnPropertyChanged(nameof(Password));
                    OnPropertyChanged(nameof(FlagStatus));
                    OnPropertyChanged(nameof(Address_1));
                    OnPropertyChanged(nameof(Zip));
                    OnPropertyChanged(nameof(City));
                    OnPropertyChanged(nameof(State));
                    OnPropertyChanged(nameof(Address_2));
                }
            }
        }


        /**
         * Gets the selected nurse as user.
         * @precondition The selected nurse is not null.
         * @postcondition The selected nurse as user is returned.
         * @return The selected nurse as user.
         */
        public ObservableCollection<Nurse?> Nurses { get; private set; } = new ();

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
        public ManageNursesViewModel()
        {
            this.nurseDAL = new NurseDAL();
            this.userDAL = new UserDAL();
            LoadNursesFromDatabase();

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void LoadNursesFromDatabase()
        {
            var nursesFromDb = nurseDAL.GetNurses();
            Nurses = new ObservableCollection<Nurse?>(nursesFromDb!);
            OnPropertyChanged(nameof(Nurses));
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
        public void Add(string fname, string lname, DateTime bDate, string phoneNum, string address1, string zip, string city, string state, string? address2, string username, string password, FlagStatus flag)
        {
            int nurseId = this.nurseDAL.AddNurse(fname, lname, bDate, address1,
               zip, city, state, address2, phoneNum, username, password, flag);
            var newNurse = new Nurse(nurseId, fname, lname, bDate, phoneNum, new Address(), username, flag);

            var address = new Address(address1, zip, city, Enum.Parse<State>(state.ToUpper()), address2);
            newNurse.Address = address;
            

            this.Nurses.Add(newNurse);
            this.selectedNurseAsUser = this.userDAL.GetUser(Username!)!;

            OnPropertyChanged(nameof(Nurses));
            OnPropertyChanged(nameof(selectedNurseAsUser));
        }


        /**
         * Saves the nurse to the database and collection.
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
         * @param didUsernameChange If the username changed.
         * @return The nurse.
         */
        public void Save(string fname, string lname, DateTime bDate, string phoneNum, string address1, 
            string zip, string city, string state, string? address2, string username, string password, FlagStatus flag)
        {
            var prevUsername = Username;
            bool didUsernameChange = !prevUsername!.ToUpper().Equals(username.ToUpper());

            this.nurseDAL.SaveEditedNurse(this.selectedNurse!.Id, fname, lname, bDate, address1,
            zip, city, state, address2, phoneNum, username, password, flag, didUsernameChange);

            this.selectedNurse.FirstName = fname;
            this.selectedNurse.LastName = lname;
            this.selectedNurse.BirthDate = bDate;
            this.selectedNurse.PhoneNumber = phoneNum;
            this.selectedNurse.Username = username;
            this.selectedNurseAsUser!.Username = username;
            this.selectedNurseAsUser.Password = password;
            this.selectedNurse.FlagStatus = flag;

            this.selectedNurse.Address!.Address_1 = address1;
            this.selectedNurse.Address.Zip = zip;
            this.selectedNurse.Address.City = city;
            this.selectedNurse.Address.State = Enum.Parse<State>(state.ToUpper());
            this.selectedNurse.Address.Address_2 = address2;
              
            var address = new Address(address1, zip, city, Enum.Parse<State>(state.ToUpper()), address2);
            this.selectedNurse.Address = address;
                
            OnPropertyChanged(nameof(selectedNurse));
            OnPropertyChanged(nameof(selectedNurseAsUser));
            OnPropertyChanged(nameof(Nurses));
        }


        /**
         * Deletes the nurse from the database and collection.
         * @return true if the nurse was deleted.
         */
        public bool DeleteNurse()
        {
            if (this.nurseDAL.DeleteNurse(Nurse_Id))
            {
                OnPropertyChanged(nameof(Nurses));
                return true;
            }
            return false;
        }

        /**
         * Deactivates the nurse.
         * @return true if the nurse was deactivated.
         */
        public bool DeactivateNurse()
        {
            if (this.nurseDAL.DeactivateNurse(Nurse_Id))
            {
                OnPropertyChanged(nameof(SelectedNurse));
                return true;
            }
            return false;
        }

        /**
         * Checks if the username is available.
         * @param username The username.
         * @return True if the username is available.
         */
        public bool IsUsernameAvailable(string username)
        {
            return this.userDAL.IsUsernameAvailable(username);
        }
    }
}

