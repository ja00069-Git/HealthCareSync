using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.Models
{
    /// <summary>
    ///  Represents the operation where the lab test is performed on the patient
    /// </summary>
    public class LabTestOperation
    {
        private DateTime dateTime;
        private int appointmentId;
        private string labTestName;
        private string? result;
        private bool? normal;

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public DateTime DateTime
        {
            get { return dateTime; }
            set
            {
                dateTime = value;
            }
        }

        /// <summary>
        /// Gets or sets the appointment identifier.
        /// </summary>
        /// <value>
        /// The appointment identifier.
        /// </value>
        public int AppointmentId
        {
            get { return appointmentId; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("AppointmentId must be above 0");
                }

                appointmentId = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the lab test.
        /// </summary>
        /// <value>
        /// The name of the lab test.
        /// </value>
        /// <exception cref="ArgumentException">Lab test name cannot be null or empty</exception>
        public string LabTestName
        {
            get { return labTestName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Lab test name cannot be null or empty");
                }

                labTestName = value;
            }
        }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public string? Result
        {
            get { return result; }
            set { result = value; }
        }

        /// <summary>
        /// Gets or sets the normal.
        /// </summary>
        /// <value>
        /// The normal.
        /// </value>
        public bool? Normal
        {
            get { return normal; }
            set { normal = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabTestOperation"/> class.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="labTestName">Name of the lab test.</param>
        /// <param name="result">The result.</param>
        /// <param name="normal">The normal.</param>
        public LabTestOperation(DateTime dateTime, int appointmentId, string labTestName, string? result, bool? normal)
        {
            DateTime = dateTime;
            AppointmentId = appointmentId;
            LabTestName = labTestName;
            Result = result;
            Normal = normal;      
        }
    }
}
