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
        public string? State => SelectedNurse?.Address?.State.ToString().ToUpper();

        /// <summary>
        /// Gets the address 2.
        /// </summary>
        /// <value>
        /// The address 2.
        /// </value>
        public string? Address_2 => SelectedNurse?.Address?.Address_2;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Nurse SelectedNurse
        {
            get { return selectedNurse; }
            set
            {
                if (selectedNurse != value)
                {
                    selectedNurse = value;
                    selectedNurseAsUser = this.userDAL.GetUser(Username!);
                    OnPropertyChanged(nameof(SelectedNurse));
                    OnPropertyChanged(nameof(FirstName));
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(FormattedBirthDate));
                    OnPropertyChanged(nameof(PhoneNumber));
                    OnPropertyChanged(nameof(Nurse_Id));
                    OnPropertyChanged(nameof(Username));
                    OnPropertyChanged(nameof(Password));
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
        /// <param name="formattedBDate">The formatted b date.</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="address1">The address1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address2">The address2.</param>
        /// <param name="username">The username.</param>
        public void Add(string fname, string lname, string formattedBDate, string? phoneNum, string? address1, string? zip, string? city, string? state, string? address2, string? username)
        {
            int nurseId = this.nurseDAL.AddNurse(fname, lname, DateTime.Parse(formattedBDate), address1,
               zip, city, state, address2, phoneNum, username);
            var newNurse = new Nurse(nurseId, fname, lname, DateTime.Parse(formattedBDate), phoneNum, null, username);

            if (address1?.Trim().Length > 0 && zip?.Trim().Length > 0)
            {
                var address = new Address(address1, zip, city, Enum.Parse<State>(state.ToUpper()), address2);
                newNurse.Address = address;
            }

            this.Nurses.Add(newNurse);

            OnPropertyChanged(nameof(Nurses));
        }

        /// <summary>
        /// Saves the patient to the database and connection.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="formattedBDate">The formatted b date.</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="address1">The address1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address2">The address2.</param>
        /// <param name="username">The username.</param>
        public void Save(string fname, string lname, string formattedBDate, string? phoneNum, string? address1, string? zip, string? city, string? state, string? address2, string? username)
        {
            this.nurseDAL.SaveEditedPatient(this.selectedNurse.Id, fname, lname, DateTime.Parse(formattedBDate), address1,
            zip, city, state, address2, phoneNum, username);

            this.selectedNurse.FirstName = fname;
            this.selectedNurse.LastName = lname;
            this.selectedNurse.BirthDate = DateTime.Parse(formattedBDate);
            this.selectedNurse.PhoneNumber = phoneNum;
            this.selectedNurse.Username = username;

            if (address1?.Trim().Length > 0 && zip?.Trim().Length > 0)
            {
                if (this.selectedNurse.Address != null)
                {
                    this.selectedNurse.Address.Address_1 = address1;
                    this.selectedNurse.Address.Zip = zip;
                    this.selectedNurse.Address.City = city;
                    this.selectedNurse.Address.State = Enum.Parse<State>(state.ToUpper());
                    this.selectedNurse.Address.Address_2 = address2;
                }
                else
                {
                    var address = new Address(address1, zip, city, Enum.Parse<State>(state.ToUpper()), address2);
                    this.selectedNurse.Address = address;
                }
            }

            OnPropertyChanged(nameof(selectedNurse));
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
    }
}

