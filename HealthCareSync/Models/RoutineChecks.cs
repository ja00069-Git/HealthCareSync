using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.Models
{
    public class RoutineChecks
    {
        private int appointmentId;
        private int systolicReading;
        private int diastolicReading;
        private int bodyTemperature;
        private int bpm;
        private string symptoms = string.Empty;
        private double weight;
        private double height;

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

        public int BodyTemperature
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

        public RoutineChecks(int appointmentId, int systolicReading, int diastolicReading, int bodyTemperature, int bpm, string symptoms, double weight, double height)
        {
            this.AppointmentId = appointmentId;
            this.SystolicReading = systolicReading;
            this.DiastolicReading = diastolicReading;
            this.BodyTemperature = bodyTemperature;
            this.bpm = bpm;
            this.Symptoms = symptoms;
            this.Weight = weight;
            this.Height = height;
        }  
    }
}
