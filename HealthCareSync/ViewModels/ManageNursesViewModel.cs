using HealthCareSync.DAL;
using HealthCareSync.Enums;
using HealthCareSync.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.ViewModels
{
    public class ManageNursesViewModel : INotifyPropertyChanged
    {
        private Nurse selectedNurse;
        private User selectedNurseAsUser;
        private NurseDAL nurseDAL;
        private UserDAL userDAL;

        /// <summary>
        /// Gets the flag flagStatus.
        /// </summary>
        /// <value>
        /// The flag flagStatus.
        /// </value>
        public FlagStatus? FlagStatus => SelectedNurse?.FlagStatus;

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string? FirstName => SelectedNurse?.FirstName;

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string? LastName => SelectedNurse?.LastName;

        /// <summary>
        /// Gets the formatted birth date.
        /// </summary>
        /// <value>
        /// The formatted birth date.
        /// </value>
        public string? FormattedBirthDate => SelectedNurse?.FormattedBirthDate;

        /// <summary>
        /// Gets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string? PhoneNumber => SelectedNurse?.PhoneNumber;

        /// <summary>
        /// Gets the patient id.
        /// </summary>
        /// <value>
        /// The patient id.
        /// </value>
        public int? Nurse_Id => SelectedNurse?.Id;

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string? Username => SelectedNurse?.Username;

        public string? Password => selectedNurseAsUser?.Password;

        /// <summary>
        /// Gets the address 1.
        /// </summary>
        /// <value>
        /// The address 1.
        /// </value>
        public string? Address_1 => SelectedNurse?.Address?.Address_1;

        /// <summary>
        /// Gets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string? Zip => SelectedNurse?.Address?.Zip;

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string? City => SelectedNurse?.Address?.City;

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public State? State => SelectedNurse?.Address?.State;

        /// <summary>
        /// Gets the address 2.
        /// </summary>
        /// <value>
        /// The address 2.
        /// </value>
        public string? Address_2 => SelectedNurse?.Address?.Address_2;

        /// <summary>
        ///     Gets the flag statuses.
        /// </summary>
        /// <value>
        ///     The flag statuses.
        /// </value>
        public List<FlagStatus> FlagStatuses => Enum.GetValues(typeof(FlagStatus)).Cast<FlagStatus>().ToList();

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Gets or sets the selected nurse.
        /// </summary>
        /// <value>
        /// The selected nurse.
        /// </value>
        public Nurse SelectedNurse
        {
            get { return selectedNurse; }
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

        /// <summary>
        ///     Gets the Nurses.
        /// </summary>
        /// <value>
        ///     The Nurses.
        /// </value>
        public ObservableCollection<Nurse> Nurses { get; }

        /// <summary>
        /// Gets the states.
        /// </summary>
        /// <value>
        /// The states.
        /// </value>
        public List<State> States => Enum.GetValues(typeof(State)).Cast<State>().ToList();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePatientsViewModel"/> class.
        /// </summary>
        public ManageNursesViewModel()
        {
            this.nurseDAL = new NurseDAL();
            this.userDAL = new UserDAL();

            this.Nurses = new ObservableCollection<Nurse>(this.nurseDAL.GetNurses());
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Adds the nurse to the database and collection.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="bDate">The b date.</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="address1">The address1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address2">The address2.</param>
        /// <param name="username">The username.</param>
        public void Add(string fname, string lname, DateTime bDate, string phoneNum, string address1, string zip, string city, string state, string? address2, string username, string password, FlagStatus flag)
        {
            int nurseId = this.nurseDAL.AddNurse(fname, lname, bDate, address1,
               zip, city, state, address2, phoneNum, username, password, flag);
            var newNurse = new Nurse(nurseId, fname, lname, bDate, phoneNum, null, username, flag);

            var address = new Address(address1, zip, city, Enum.Parse<State>(state.ToUpper()), address2);
            newNurse.Address = address;
            

            this.Nurses.Add(newNurse);
            this.selectedNurseAsUser = this.userDAL.GetUser(Username!)!;

            OnPropertyChanged(nameof(Nurses));
            OnPropertyChanged(nameof(selectedNurseAsUser));
        }

        /// <summary>
        /// Saves the patient to the database and connection.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="bDate">The b date.</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="address1">The address1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address2">The address2.</param>
        /// <param name="username">The username.</param>
        public void Save(string fname, string lname, DateTime bDate, string phoneNum, string address1, string zip, string city, string state, string? address2, string username, string password, FlagStatus flag)
        {
            var prevUsername = Username;
            bool didUsernameChange = !prevUsername!.ToUpper().Equals(username.ToUpper());

            this.nurseDAL.SaveEditedPatient(this.selectedNurse.Id, fname, lname, bDate, address1,
            zip, city, state, address2, phoneNum, username, password, flag, didUsernameChange);

            this.selectedNurse.FirstName = fname;
            this.selectedNurse.LastName = lname;
            this.selectedNurse.BirthDate = bDate;
            this.selectedNurse.PhoneNumber = phoneNum;
            this.selectedNurse.Username = username;
            this.selectedNurseAsUser.Username = username;
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

        /// <summary>
        /// Deletes the patient from the database and collection.
        /// </summary>
        public void Delete()
        {
            this.nurseDAL.DeleteNurse(this.selectedNurse.Id);

            this.Nurses.Remove(this.selectedNurse);
            OnPropertyChanged(nameof(Nurses));
        }

        public bool IsUsernameAvailable(string username)
        {
            return this.userDAL.IsUsernameAvailable(username);
        }
    }
}

