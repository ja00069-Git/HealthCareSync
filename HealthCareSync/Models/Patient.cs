using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.Enums;

namespace HealthCareSync.Models
{
    public class Patient
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string? phoneNumber;
        private Address? address;
        private FlagStatus? flagStatus;

        /// <summary>
        ///     Gets the Patient's Patient_Id.
        /// </summary>
        /// <value>
        ///     The Patient's Patient_Id.
        /// </value>
        public int Id { get; }

        /// <summary>
        ///     Gets the first name.
        /// </summary>
        /// <value>
        ///     The first name.
        /// </value>
        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), $"{nameof(value)} cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        /// <summary>
        ///     Gets the last name.
        /// </summary>
        /// <value>
        ///     The last name.
        /// </value>
        public string LastName 
        {
            get => this.lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), $"{nameof(value)} cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        /// <summary>
        ///     Gets the full name.
        /// </summary>
        /// <value>
        ///     The full name.
        /// </value>
        public string FullName => this.FirstName + " " + this.LastName;

        /// <summary>
        ///     Gets the birth date.
        /// </summary>
        /// <value>
        ///     The birth date.
        /// </value>
        public DateTime BirthDate 
        {
            get => this.birthDate;
            set
            {
                this.birthDate = value;
            }
        }

        /// <summary>
        ///     Gets the formatted birth date.
        /// </summary>
        /// <value>
        ///     The formatted birth date.
        /// </value>
        public string FormattedBirthDate => this.BirthDate.ToString("MM/dd/yyyy");

        /// <summary>
        ///     Gets the phone number.
        /// </summary>
        /// <value>
        ///     The phone number.
        /// </value>
        public string? PhoneNumber 
        { 
            get => this.phoneNumber;
            set
            {
                this.phoneNumber = value?.Trim();
            }
        }

        /// <summary>
        ///     Gets the address identifier.
        /// </summary>
        /// <value>
        ///     The address identifier.
        /// </value>
        public int? AddressId => this.Address?.Id;

        /// <summary>
        ///     Gets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        public Address? Address 
        {
            get => this.address;
            set
            {
                this.address = value;
            }
        }

        /// <summary>
        ///     Gets the flag flagStatus.
        /// </summary>
        /// <value>
        ///     The flag flagStatus.
        /// </value>
        public FlagStatus? FlagStatus 
        {
            get => this.flagStatus;
            set
            {
                this.flagStatus = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class.
        /// </summary>
        /// <param name="id">The patient id.</param>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="birthDate">The birth date.</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="address">The address.</param>
        /// <param name="flagStatus">The flag flagStatus.</param>
        /// <exception cref="ArgumentOutOfRangeException">id</exception>
        /// <exception cref="ArgumentNullException">
        /// fname
        /// or
        /// lname
        /// </exception>
        public Patient(int id, string fname, string lname, DateTime birthDate, string? phoneNum, Address? address, FlagStatus? flagStatus)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), $"{nameof(id)} has to be more than 0");
            }
            if (string.IsNullOrWhiteSpace(fname))
            {
                throw new ArgumentNullException(nameof(fname), $"{nameof(fname)} cannot be null or empty");
            }
            if (string.IsNullOrWhiteSpace(lname))
            {
                throw new ArgumentNullException(nameof(lname), $"{nameof(lname)} cannot be null or empty");
            }
           
            this.Id = id;
            this.firstName = fname;
            this.lastName = lname;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNum?.Trim();
            this.address = address;
            this.flagStatus = flagStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="birthDate">The birth date.</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="address">The address.</param>
        /// <param name="flagStatus">The flag flagStatus.</param>
        /// <exception cref="ArgumentOutOfRangeException">id</exception>
        /// <exception cref="ArgumentNullException">
        /// fname
        /// or
        /// lname
        /// </exception>
        public Patient(string fname, string lname, DateTime birthDate, string? phoneNum, Address? address, FlagStatus? flagStatus)
        {
            if (string.IsNullOrWhiteSpace(fname))
            {
                throw new ArgumentNullException(nameof(fname), $"{nameof(fname)} cannot be null or empty");
            }
            if (string.IsNullOrWhiteSpace(lname))
            {
                throw new ArgumentNullException(nameof(lname), $"{nameof(lname)} cannot be null or empty");
            }

            this.firstName = fname;
            this.lastName = lname;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNum;
            this.address = address;
            this.flagStatus = flagStatus;
        }

    }
}
