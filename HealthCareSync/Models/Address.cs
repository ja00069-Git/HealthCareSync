using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HealthCareSync.Enums;

namespace HealthCareSync.Models
{
    /// <summary>
    ///     The class Address holds all information of an address
    /// </summary>
    public class Address
    {
        private string address_1;
        private string zip;
        private string city;
        private State state;
        private string? address_2;

        /// <summary>
        ///     Gets the address id.
        /// </summary>
        /// <value>
        ///     The address id.
        /// </value>
        public int Id { get; }

        /// <summary>
        ///     Gets the address 1.
        /// </summary>
        /// <value>
        ///     The address 1.
        /// </value>
        public string Address_1 
        { 
            get => this.address_1;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), $"{nameof(value)} cannot be null or empty");
                }

                this.address_1 = value;
            }

        }

        /// <summary>
        ///     Gets the zip.
        /// </summary>
        /// <value>
        ///     The zip.
        /// </value>
        public string Zip 
        {
            get => this.zip;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), $"{nameof(value)} cannot be null or empty");
                }
                if (!new Regex(@"^\d{5}$").IsMatch(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} must be 5 digits");
                }

                this.zip = value;
            }
        }

        /// <summary>
        ///     Gets the city.
        /// </summary>
        /// <value>
        ///     The city.
        /// </value>
        public string City 
        {
            get => this.city;
            set
            {
                this.city = value.Trim();
            }
        }

        /// <summary>
        ///     Gets the state.
        /// </summary>
        /// <value>
        ///     The state.
        /// </value>
        public State State 
        {
            get => this.state;
            set
            {
                this.state = value;
            }
        }

        /// <summary>
        ///     Gets the address 2.
        /// </summary>
        /// <value>
        ///     The address 2.
        /// </value>
        public string? Address_2 
        {
            get => this.address_2;
            set
            {
                this.address_2 = value?.Trim();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="address_1">The address 1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address_2">The address 2.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// id
        /// or
        /// zip
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// address_1
        /// or
        /// zip
        /// </exception>
        public Address(int id, string address_1, string zip, string city, State state, string? address_2)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), $"{nameof(id)} has to be more than 0");
            }
            if (string.IsNullOrWhiteSpace(address_1))
            {
                throw new ArgumentNullException(nameof(address_1), $"{nameof(address_1)} cannot be null or empty");
            }
            if (string.IsNullOrWhiteSpace(zip))
            {
                throw new ArgumentNullException(nameof(zip), $"{nameof(zip)} cannot be null or empty");
            }
            if (!new Regex(@"^\d{5}$").IsMatch(zip))
            {
                throw new ArgumentOutOfRangeException(nameof(zip), $"{nameof(zip)} must be 5 digits");
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentNullException(nameof(city), $"{nameof(city)} cannot be null or empty");
            }

            this.Id = id;
            this.address_1 = address_1;
            this.zip = zip;
            this.city = city.Trim();
            this.state = state;
            this.address_2 = address_2?.Trim();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="address_1">The address 1.</param>
        /// <param name="zip">The zip.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="address_2">The address 2.</param>
        /// <exception cref="ArgumentNullException">
        /// address_1
        /// or
        /// zip
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">zip</exception>
        public Address(string address_1, string zip, string city, State state, string? address_2)
        {
            if (string.IsNullOrWhiteSpace(address_1))
            {
                throw new ArgumentNullException(nameof(address_1), $"{nameof(address_1)} cannot be null or empty");
            }
            if (string.IsNullOrWhiteSpace(zip))
            {
                throw new ArgumentNullException(nameof(zip), $"{nameof(zip)} cannot be null or empty");
            }
            if (!new Regex(@"^\d{5}$").IsMatch(zip))
            {
                throw new ArgumentOutOfRangeException(nameof(zip), $"{nameof(zip)} must be 5 digits");
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentNullException(nameof(city), $"{nameof(city)} cannot be null or empty");
            }

            this.address_1 = address_1;
            this.zip = zip;
            this.city = city.Trim();
            this.state = state;
            this.address_2 = address_2?.Trim();
        }
    }
}
