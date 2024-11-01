using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.DAL;
using HealthCareSync.Enums;
using HealthCareSync.Models;

namespace HealthCareSync.ViewModels
{
    /// <summary>
    ///     The view model for the Manage_Patients form
    /// </summary>
    public class ManagePatientsViewModel : INotifyPropertyChanged
    {
        private Patient selectedPatient;
        private PatientDAL patientDAL;

        /// <summary>
        /// Gets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string? FirstName => SelectedPatient?.FirstName;

        /// <summary>
        /// Gets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string? LastName => SelectedPatient?.LastName;

        /// <summary>
        /// Gets the formatted birth date.
        /// </summary>
        /// <value>
        /// The formatted birth date.
        /// </value>
        public string? FormattedBirthDate => SelectedPatient?.FormattedBirthDate;

        /// <summary>
        /// Gets the birth date.
        /// </summary>
        /// <value>
        /// The birth date.
        /// </value>
        public DateTime? BirthDate => SelectedPatient?.BirthDate;

        /// <summary>
        /// Gets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public Gender? Gender => SelectedPatient?.Gender;

        /// <summary>
        /// Gets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string? PhoneNumber => SelectedPatient?.PhoneNumber;

        /// <summary>
        /// Gets the patient id.
        /// </summary>
        /// <value>
        /// The patient id.
        /// </value>
        public int? Patient_Id => SelectedPatient?.Id;

        /// <summary>
        /// Gets the flag flagStatus.
        /// </summary>
        /// <value>
        /// The flag flagStatus.
        /// </value>
        public FlagStatus? FlagStatus => SelectedPatient?.FlagStatus;

        /// <summary>
        /// Gets the address 1.
        /// </summary>
        /// <value>
        /// The address 1.
        /// </value>
        public string? Address_1 => SelectedPatient?.Address.Address_1;

        /// <summary>
        /// Gets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string? Zip => SelectedPatient?.Address.Zip;

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string? City => SelectedPatient?.Address.City;

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public State? State => SelectedPatient?.Address.State;

        /// <summary>
        /// Gets the address 2.
        /// </summary>
        /// <value>
        /// The address 2.
        /// </value>
        public string? Address_2 => SelectedPatient?.Address.Address_2;

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Gets or sets the selected patient.
        /// </summary>
        /// <value>
        /// The selected patient.
        /// </value>
        public Patient SelectedPatient
        {
            get { return selectedPatient; }
            set
            {
                if (selectedPatient != value)
                {
                    selectedPatient = value;
                    OnPropertyChanged(nameof(SelectedPatient));
                    OnPropertyChanged(nameof(FirstName)); 
                    OnPropertyChanged(nameof(LastName));
                    OnPropertyChanged(nameof(BirthDate));
                    OnPropertyChanged(nameof(Gender));
                    OnPropertyChanged(nameof(PhoneNumber));
                    OnPropertyChanged(nameof(Patient_Id));
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
        ///     Gets the Patients.
        /// </summary>
        /// <value>
        ///     The Patients.
        /// </value>
        public ObservableCollection<Patient> Patients { get; set; }

        /// <summary>
        ///     Gets the flag statuses.
        /// </summary>
        /// <value>
        ///     The flag statuses.
        /// </value>
        public List<FlagStatus> FlagStatuses => Enum.GetValues(typeof(FlagStatus)).Cast<FlagStatus>().ToList();

        /// <summary>
        /// Gets the states.
        /// </summary>
        /// <value>
        /// The states.
        /// </value>
        public List<State> States => Enum.GetValues(typeof(State)).Cast<State>().ToList();

        /// <summary>
        /// Gets the genders.
        /// </summary>
        /// <value>
        /// The genders.
        /// </value>
        public List<Gender> Genders => Enum.GetValues<Gender>().Cast<Gender>().ToList();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePatientsViewModel"/> class.
        /// </summary>
        public ManagePatientsViewModel() 
        {
            this.patientDAL = new PatientDAL();

            this.Patients = new ObservableCollection<Patient>(this.patientDAL.GetPatients());
      
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Updates the patient list with those with the given name and returns true if there exists a patient with the name, false if not.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns>true if there is patient with name, false otherwise</returns>
        public bool SearchByName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                this.Patients = new ObservableCollection<Patient>(this.patientDAL.GetPatients());
                OnPropertyChanged(nameof(Patients));
                return true;
            }
            else if (string.IsNullOrWhiteSpace(firstName))
            {
                var list = this.patientDAL.GetPatientsWithLastName(lastName);

                if (list.Count != 0)
                {
                    this.Patients = new ObservableCollection<Patient>(this.patientDAL.GetPatientsWithLastName(lastName));
                    OnPropertyChanged(nameof(Patients));
                    return true;
                }

                return false;
            } 
            else if (string.IsNullOrWhiteSpace(lastName))
            {
                var list = this.patientDAL.GetPatientsWithFirstName(firstName);

                if (list.Count != 0)
                {
                    this.Patients = new ObservableCollection<Patient>(this.patientDAL.GetPatientsWithFirstName(firstName));
                    OnPropertyChanged(nameof(Patients));
                    return true;
                }

                return false;
            }
            else
            {
                var list = this.patientDAL.GetPatientsWithFullName(firstName, lastName);

                if (list.Count != 0)
                {
                    this.Patients = new ObservableCollection<Patient>(this.patientDAL.GetPatientsWithFullName(firstName, lastName));
                    OnPropertyChanged(nameof(Patients));
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Updates the patient list with those with the given birth date and returns true if there exists a patient with the given birth date, false if not
        /// </summary>
        /// <param name="bDate">The b date.</param>
        /// <returns>true if theres a patient with the given birth date, false otherwise</returns>
        public bool SearchByBirthDate(DateTime bDate)
        {
            var list = this.patientDAL.GetPatientsWithBirthDate(bDate);

            if (list.Count != 0)
            {
                this.Patients = new ObservableCollection<Patient>(this.patientDAL.GetPatientsWithBirthDate(bDate));
                OnPropertyChanged(nameof(Patients));
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates the patient list with those with the given name and birth date and returns true if there exists a patient with the given name and birth date, false if not
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="last">The last.</param>
        /// <param name="bDate">The b date.</param>
        /// <returns>tru if theres a patient with the given name and birth date, false otherwise</returns>
        public bool SearchByNameAndBirthDate(string  first, string last, DateTime bDate)
        {
            var list = this.patientDAL.GetPatientsWithNameAndBirthDate(first, last, bDate);

            if (list.Count != 0)
            {
                this.Patients = new ObservableCollection<Patient>(this.patientDAL.GetPatientsWithNameAndBirthDate(first,last, bDate));
                OnPropertyChanged(nameof(Patients));
                return true;
            }

            return false;
        }

        /// <summary>
        /// Adds the patient to the database and collection.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="bDate">The b date.</param>
        /// <param name="gender">The gender</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="address1">The address1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address2">The address2.</param>
        /// <param name="flag">The flag.</param>
        public void Add(string fname, string lname, DateTime bDate, Gender gender, string phoneNum, string address1, string zip, string city, State state, string? address2, FlagStatus flag)
        {
            int patientId = this.patientDAL.AddPatient(fname, lname, bDate, gender, address1,
               zip, city, state, address2, phoneNum, flag);

            var address = new Address(address1, zip, city, state, address2);
            var newPatient = new Patient(patientId, fname, lname, bDate, gender, phoneNum, address, flag);

            this.Patients.Add(newPatient);

            OnPropertyChanged(nameof(Patients));
        }

        /// <summary>
        /// Saves the patient to the database and connection.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="bDate">The b date.</param>
        /// <param name="gender">The gender</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="address1">The address1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address2">The address2.</param>
        /// <param name="flag">The flag.</param>
        public void Save(string fname, string lname, DateTime bDate, Gender gender, string phoneNum, string address1, string zip, string city, State state, string address2, FlagStatus flag)
        {
            this.patientDAL.SaveEditedPatient(this.selectedPatient.Id, fname, lname, bDate, gender, address1,
            zip, city, state, address2, phoneNum, flag);

            this.selectedPatient.FirstName = fname;
            this.selectedPatient.LastName = lname;
            this.selectedPatient.BirthDate = bDate;
            this.selectedPatient.Gender = gender;
            this.selectedPatient.PhoneNumber = phoneNum;
            this.selectedPatient.FlagStatus = flag;

            var address = new Address(address1, zip, city, state, address2);
            this.selectedPatient.Address = address;

            OnPropertyChanged(nameof(SelectedPatient));
            OnPropertyChanged(nameof(Patients));  
        }
    }
}
