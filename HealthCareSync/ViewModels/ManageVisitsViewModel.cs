using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.DAL;
using HealthCareSync.Enums;
using HealthCareSync.Models;

namespace HealthCareSync.ViewModels
{
    public class ManageVisitsViewModel : INotifyPropertyChanged
    {

        private Appointment selectedVisit;
        private RoutineChecks selectedVisitRoutineChecks;
        private RoutineChecksDAL routineChecksDal;
        private AppointmentDAL appointmentDal;

        public bool VisitHasRoutineChecksEntered => selectedVisitRoutineChecks != null;

        public int? AppointmentId => selectedVisit?.AppointmentId;

        public DateTime? VisitDate => selectedVisit?.DateTime;

        public int? SystolicReading => selectedVisitRoutineChecks?.SystolicReading;

        public int? DiastolicReading => selectedVisitRoutineChecks?.DiastolicReading;

        public int? BodyTemperature => selectedVisitRoutineChecks?.BodyTemperature;

        public int? BPM => selectedVisitRoutineChecks?.BPM;

        public string? Symptoms => selectedVisitRoutineChecks?.Symptoms;

        public double? Weight => selectedVisitRoutineChecks?.Weight;    

        public double? Height => selectedVisitRoutineChecks?.Height;

        public Appointment SelectedVisit
        {
            get { return selectedVisit; }
            set
            {
               selectedVisit = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged(nameof(SelectedVisit));
                OnPropertyChanged(nameof(AppointmentId));
                OnPropertyChanged(nameof(VisitDate));
                OnPropertyChanged(nameof(SystolicReading));
                OnPropertyChanged(nameof(DiastolicReading));
                OnPropertyChanged(nameof(BodyTemperature));
                OnPropertyChanged(nameof(BPM));
                OnPropertyChanged(nameof(Symptoms));
                OnPropertyChanged(nameof(Weight));
                OnPropertyChanged(nameof(Height));
            }
        }

        public ObservableCollection<Appointment> Visits { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ManageVisitsViewModel()
        {
            this.routineChecksDal = new RoutineChecksDAL();
            this.appointmentDal = new AppointmentDAL();

            this.Visits = new ObservableCollection<Appointment>(this.appointmentDal.GetAppointments());
            //this.selectedVisitRoutineChecks = this.routineChecksDal.GetRoutineChecks(this.AppointmentId);
        }
    }
}
