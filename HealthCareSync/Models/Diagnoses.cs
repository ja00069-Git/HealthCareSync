using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.Models
{
    /// <summary>
    ///  Represents the diagnoses made from the doctor after assessing the patient
    /// </summary>
    public class Diagnoses
    {
        private int appointmentId;
        private string? initialDiagnoses;
        private string? finalDiagnoses;

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
        /// Gets or sets the initial diagnoses.
        /// </summary>
        /// <value>
        /// The initial diagnoses.
        /// </value>
        public string? InitialDiagnoses
        {
            get { return initialDiagnoses; }

            set
            {
                initialDiagnoses = value;
            }
        }

        /// <summary>
        /// Gets or sets the final diagnoses.
        /// </summary>
        /// <value>
        /// The final diagnoses.
        /// </value>
        public string? FinalDiagnoses
        {
            get { return finalDiagnoses; }

            set
            {
                finalDiagnoses = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Diagnoses"/> class.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="initialDiagnoses">The initial diagnoses.</param>
        /// <param name="finalDiagnoses">The final diagnoses.</param>
        public Diagnoses(int appointmentId, string? initialDiagnoses, string? finalDiagnoses)
        {
            this.AppointmentId = appointmentId;
            this.InitialDiagnoses = initialDiagnoses;
            this.FinalDiagnoses = finalDiagnoses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Diagnoses"/> class.
        /// </summary>
        /// <param name="initialDiagnosis">The initial diagnoses.</param>
        /// <param name="finalDiagnosis">The final diagnoses.</param>
        public Diagnoses(string? initialDiagnoses, string? finalDiagnoses)
        {
            this.InitialDiagnoses = initialDiagnoses;
            this.FinalDiagnoses = finalDiagnoses;
        }
    }
}
