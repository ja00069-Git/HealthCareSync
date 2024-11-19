using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.Models
{
    /// <summary>
    ///  Represents a specific lab test that can be taken 
    /// </summary>
    public class LabTest
    {
        private string name;
        private string code;
        private double? lowValue;
        private double? highValue;
        private string? unitOfMeasurement;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        /// <exception cref="ArgumentNullException">Name cannot be null or empty</exception>
        public string Name
        {
            get { return name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        /// <exception cref="ArgumentNullException">Code cannot be null or empty</exception>
        public string Code
        {
            get { return code; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Code cannot be null or empty");
                }

                code = value;
            }
        }

        /// <summary>
        /// Gets or sets the low value.
        /// </summary>
        /// <value>
        /// The low value.
        /// </value>
        public double? LowValue
        {
            get { return lowValue; }
            set { lowValue = value; }
        }

        /// <summary>
        /// Gets or sets the high value.
        /// </summary>
        /// <value>
        /// The high value.
        /// </value>
        public double? HighValue
        {
            get { return highValue; }
            set { highValue = value; }
        }

        /// <summary>
        /// Gets or sets the unit of measurement.
        /// </summary>
        /// <value>
        /// The unit of measurement.
        /// </value>
        public string? UnitOfMeasurement
        {
            get { return unitOfMeasurement; }
            set { unitOfMeasurement = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabTest"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="code">The code.</param>
        /// <param name="lowValue">The low value.</param>
        /// <param name="highValue">The high value.</param>
        /// <param name="unitOfMeasurement">The unit of measurement.</param>
        public LabTest(string name, string code, double? lowValue, double? highValue, string? unitOfMeasurement)
        {
            this.Name = name;
            this.Code = code;
            this.LowValue = lowValue;
            this.HighValue = highValue;
            this.UnitOfMeasurement = unitOfMeasurement;
        }
    }
}
