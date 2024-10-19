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
        /// <summary>
        ///     Gets the Patient's Id.
        /// </summary>
        /// <value>
        ///     The Patient's Id.
        /// </value>
        public int Id { get; }

        /// <summary>
        ///     Gets the first name.
        /// </summary>
        /// <value>
        ///     The first name.
        /// </value>
        public string FirstName { get; }

        /// <summary>
        ///     Gets the last name.
        /// </summary>
        /// <value>
        ///     The last name.
        /// </value>
        public string LastName { get; }

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
        public DateTime BirthDate { get; }

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
        public string? PhoneNumber { get; }

        /// <summary>
        ///     Gets the address identifier.
        /// </summary>
        /// <value>
        ///     The address identifier.
        /// </value>
        public int? AddressId { get; }

        /// <summary>
        ///     Gets the flag status.
        /// </summary>
        /// <value>
        ///     The flag status.
        /// </value>
        public FlagStatus? FlagStatus { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class.
        /// </summary>
        /// <param name="id">The patient id.</param>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="birthDate">The birth date.</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="addressId">The address identifier.</param>
        /// <param name="flagStatus">The flag status.</param>
        /// <exception cref="ArgumentOutOfRangeException">id</exception>
        /// <exception cref="ArgumentNullException">
        /// fname
        /// or
        /// lname
        /// </exception>
        public Patient(int id, string fname, string lname, DateTime birthDate, string? phoneNum, int? addressId, FlagStatus? flagStatus)
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
            if (addressId != null && addressId <= 0)
            {
                throw new ArgumentNullException(nameof(lname), $"{nameof(lname)} has to be more than 0");
            }

            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = birthDate;
            this.PhoneNumber = phoneNum;
            this.AddressId = addressId;
            this.FlagStatus = flagStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="birthDate">The birth date.</param>
        /// <param name="phoneNum">The phone number.</param>
        /// <param name="addressId">The address identifier.</param>
        /// <param name="flagStatus">The flag status.</param>
        /// <exception cref="ArgumentOutOfRangeException">id</exception>
        /// <exception cref="ArgumentNullException">
        /// fname
        /// or
        /// lname
        /// </exception>
        public Patient(string fname, string lname, DateTime birthDate, string? phoneNum, int? addressId, FlagStatus? flagStatus)
        {
            if (string.IsNullOrWhiteSpace(fname))
            {
                throw new ArgumentNullException(nameof(fname), $"{nameof(fname)} cannot be null or empty");
            }
            if (string.IsNullOrWhiteSpace(lname))
            {
                throw new ArgumentNullException(nameof(lname), $"{nameof(lname)} cannot be null or empty");
            }
            if (addressId != null && addressId <= 0)
            {
                throw new ArgumentNullException(nameof(lname), $"{nameof(lname)} has to be more than 0");
            }

            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = birthDate;
            this.PhoneNumber = phoneNum;
            this.AddressId = addressId;
            this.FlagStatus = flagStatus;
        }

    }
}
