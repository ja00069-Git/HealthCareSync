using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.Models
{
    /// <summary>
    /// Class representing the routine checks performed at the beginning of a visit
    /// </summary>
    public class RoutineChecks
    {
        private int nurseId;
        private int appointmentId;
        private int systolicReading;
        private int diastolicReading;
        private double bodyTemperature;
        private int bpm;
        private string symptoms = string.Empty;
        private double weight;
        private double height;

        /// <summary>
        /// Gets or sets the nurse identifier.
        /// </summary>
        /// <value>
        /// The nurse identifier.
        /// </value>
        /// <exception cref="ArgumentException">NurseId must be above 0</exception>
        public int NurseId
        {
            get { return nurseId; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("NurseId must be above 0");
                }

                nurseId = value;
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
        /// Gets or sets the systolic reading.
        /// </summary>
        /// <value>
        /// The systolic reading.
        /// </value>
        public int SystolicReading
        {
            get { return systolicReading; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("SystolicReading cant be negative");
                }

                systolicReading = value;
            }
        }

        /// <summary>
        /// Gets or sets the diastolic reading.
        /// </summary>
        /// <value>
        /// The diastolic reading.
        /// </value>
        public int DiastolicReading
        {
            get { return diastolicReading; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("DiastolicReading cant be negative");
                }

                diastolicReading = value;
            }
        }

        /// <summary>
        /// Gets or sets the body temperature.
        /// </summary>
        /// <value>
        /// The body temperature.
        /// </value>
        public double BodyTemperature
        {
            get { return bodyTemperature; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("BodyTemperature cant be negative");
                }

                bodyTemperature = value;
            }
        }

        /// <summary>
        /// Gets or sets the BPM.
        /// </summary>
        /// <value>
        /// The BPM.
        /// </value>
        public int BPM
        {
            get { return bpm; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("BPM cant be negative");
                }

                bpm = value;
            }
        }

        /// <summary>
        /// Gets or sets the symptoms.
        /// </summary>
        /// <value>
        /// The symptoms.
        /// </value>
        public string Symptoms
        {
            get { return symptoms; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Symptoms cannot be null or empty");
                }

                symptoms = value;
            }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight
        {
            get { return weight; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight must be above 0");
                }

                weight = value;
            }
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public double Height
        {
            get { return height; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be above 0");
                }

                height = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutineChecks" /> class.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="systolicReading">The systolic reading.</param>
        /// <param name="diastolicReading">The diastolic reading.</param>
        /// <param name="bodyTemperature">The body temperature.</param>
        /// <param name="bpm">The BPM.</param>
        /// <param name="symptoms">The symptoms.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="height">The height.</param>
        public RoutineChecks(int appointmentId, int systolicReading, int diastolicReading, double bodyTemperature, int bpm, string symptoms, double weight, double height, int nurseId)
        {
            this.AppointmentId = appointmentId;
            this.SystolicReading = systolicReading;
            this.DiastolicReading = diastolicReading;
            this.BodyTemperature = bodyTemperature;
            this.bpm = bpm;
            this.Symptoms = symptoms;
            this.Weight = weight;
            this.Height = height;
            this.NurseId = nurseId;
        }
    }
}
