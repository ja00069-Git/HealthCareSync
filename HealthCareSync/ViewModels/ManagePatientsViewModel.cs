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
        private AddressDAL addressDAL;

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
        public string? Address_1 => SelectedPatient?.Address?.Address_1;

        /// <summary>
        /// Gets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public string? Zip => SelectedPatient?.Address?.Zip;

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string? City => SelectedPatient?.Address?.City;

        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string? State => SelectedPatient?.Address?.State;

        /// <summary>
        /// Gets the address 2.
        /// </summary>
        /// <value>
        /// The address 2.
        /// </value>
        public string? Address_2 => SelectedPatient?.Address?.Address_2;

        public event PropertyChangedEventHandler? PropertyChanged;

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
                    OnPropertyChanged(nameof(FormattedBirthDate));
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
        public ObservableCollection<Patient> Patients { get; }

        /// <summary>
        ///     Gets the flag statuses.
        /// </summary>
        /// <value>
        ///     The flag statuses.
        /// </value>
        public List<FlagStatus> FlagStatuses => Enum.GetValues(typeof(FlagStatus)).Cast<FlagStatus>().ToList();

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

        public void Add(string fname, string lname, string formattedBDate, string? phoneNum, string? address1, string? zip, string? city, string? state, string? address2, FlagStatus? flag)
        {
            var newPatient = new Patient(fname, lname, DateTime.Parse(formattedBDate), phoneNum, null, flag);

            if (address1?.Trim().Length > 0 && zip?.Trim().Length > 0)
            {
                var address = new Address(address1, zip, city, state, address2);
                newPatient.Address = address;
            }

            this.Patients.Add(newPatient);

            OnPropertyChanged(nameof(Patients));

            //TODO: Add patient in the database
        }

        public void Save(string fname, string lname, string formattedBDate, string? phoneNum, string? address1, string? zip, string? city, string? state, string? address2, FlagStatus? flag)
        {
            this.selectedPatient.FirstName = fname;
            this.selectedPatient.LastName = lname;
            this.selectedPatient.BirthDate = DateTime.Parse(formattedBDate);
            this.selectedPatient.PhoneNumber = phoneNum;
            this.selectedPatient.FlagStatus = flag;

            if (address1?.Trim().Length > 0 && zip?.Trim().Length > 0)
            {
                if (this.selectedPatient.Address != null)
                {
                    this.selectedPatient.Address.Address_1 = address1;
                    this.selectedPatient.Address.Zip = zip;
                    this.selectedPatient.Address.City = city;
                    this.selectedPatient.Address.State = state;
                    this.selectedPatient.Address.Address_2 = address2;
                }
                else
                {
                    var address = new Address(address1, zip, city, state, address2);
                    this.selectedPatient.Address = address;
                }
            }

            OnPropertyChanged(nameof(SelectedPatient));
            OnPropertyChanged(nameof(Patients));

            this.patientDAL.SaveEditedPatient(this.selectedPatient.Id, fname, lname, DateTime.Parse(formattedBDate), address1,
                zip, city, state, address2, phoneNum, flag);
           
        }

        public void Delete()
        {
            this.Patients.Remove(this.selectedPatient);
            OnPropertyChanged(nameof(Patients));

            //TODO: Delete patient in the database
        }
    }
}
