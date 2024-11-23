using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using HealthCareSync.DAL;
using HealthCareSync.Enums;
using HealthCareSync.Models;

namespace HealthCareSync.ViewModels
{
    public class ManageVisitsViewModel : INotifyPropertyChanged
    {

        private Appointment selectedVisit;
        private RoutineChecks? selectedVisitRoutineChecks;
        private LabTestOperation? selectedLabTestOperation;
        private Diagnoses? selectedVisitDiagnoses;
        private Nurse? performingNurse;
        private RoutineChecksDAL routineChecksDal;
        private AppointmentDAL appointmentDal;
        private PatientDAL patientDal;
        private NurseDAL nurseDal;
        private LabTestDAL labTestDAL;
        private LabTestOperationDAL labTestOperationDAL;
        private DiagnosesDAL diagnosesDAL;

        /// <summary>
        /// Gets a value indicating whether [visit has routine checks entered].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [visit has routine checks entered]; otherwise, <c>false</c>.
        /// </value>
        public bool VisitHasRoutineChecksEntered => selectedVisitRoutineChecks != null;

        /// <summary>
        /// Gets the name of the performing nurse.
        /// </summary>
        /// <value>
        /// The name of the performing nurse.
        /// </value>
        public string? PerformingNurseName
        {
            get
            {
                if (this.performingNurse == null)
                {
                    return string.Empty;
                }
                return this.performingNurse!.FullName;
            }
        }

        public string? SelectedLabTestOperationName => selectedLabTestOperation?.LabTestName;

        /// <summary>
        /// Gets the selected lab test operation date.
        /// </summary>
        /// <value>
        /// The selected lab test operation date.
        /// </value>
        public DateTime? SelectedLabTestOperationDateTime => selectedLabTestOperation?.DateTime;

        /// <summary>
        /// Gets the selected lab test operation time.
        /// </summary>
        /// <value>
        /// The selected lab test operation time.
        /// </value>
        public TimeSpan? SelectedLabTestOperationTime => selectedLabTestOperation?.DateTime.TimeOfDay;

        /// <summary>
        /// Gets the appointment identifier.
        /// </summary>
        /// <value>
        /// The appointment identifier.
        /// </value>
        public int? AppointmentId => selectedVisit?.AppointmentId;

        /// <summary>
        /// Gets the visit date.
        /// </summary>
        /// <value>
        /// The visit date.
        /// </value>
        public DateTime? VisitDate => selectedVisit?.DateTime;

        /// <summary>
        /// Gets the systolic reading.
        /// </summary>
        /// <value>
        /// The systolic reading.
        /// </value>
        public int? SystolicReading => selectedVisitRoutineChecks?.SystolicReading;

        /// <summary>
        /// Gets the diastolic reading.
        /// </summary>
        /// <value>
        /// The diastolic reading.
        /// </value>
        public int? DiastolicReading => selectedVisitRoutineChecks?.DiastolicReading;

        /// <summary>
        /// Gets the body temperature.
        /// </summary>
        /// <value>
        /// The body temperature.
        /// </value>
        public double? BodyTemperature => selectedVisitRoutineChecks?.BodyTemperature;

        /// <summary>
        /// Gets the BPM.
        /// </summary>
        /// <value>
        /// The BPM.
        /// </value>
        public int? BPM => selectedVisitRoutineChecks?.BPM;

        /// <summary>
        /// Gets the symptoms.
        /// </summary>
        /// <value>
        /// The symptoms.
        /// </value>
        public string? Symptoms => selectedVisitRoutineChecks?.Symptoms;

        /// <summary>
        /// Gets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double? Weight => selectedVisitRoutineChecks?.Weight;

        /// <summary>
        /// Gets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public double? Height => selectedVisitRoutineChecks?.Height;

        /// <summary>
        /// Gets the selected visit routine checks.
        /// </summary>
        /// <value>
        /// The selected visit routine checks.
        /// </value>
        public RoutineChecks? SelectedVisitRoutineChecks { get { return this.selectedVisitRoutineChecks; } }

        /// <summary>
        /// Gets the selected lab test operation.
        /// </summary>
        /// <value>
        /// The selected lab test operation.
        /// </value>
        public LabTestOperation? SelectedLabTestOperation
        {
            get { return this.selectedLabTestOperation; }
            set
            {
                selectedLabTestOperation = value;
                OnPropertyChanged(nameof(SelectedLabTestOperation));
                OnPropertyChanged(nameof(SelectedLabTestOperationTime));
                OnPropertyChanged(nameof(SelectedLabTestOperationName));
            }
        }

        /// <summary>
        /// Gets or sets the selected visit diagnoses.
        /// </summary>
        /// <value>
        /// The selected visit diagnoses.
        /// </value>
        public Diagnoses? SelectedVisitDiagnoses
        {
            get { return selectedVisitDiagnoses; }
            set
            {
                selectedVisitDiagnoses = value;
                OnPropertyChanged(nameof(FinalDiagnosesIsEntered));
                OnPropertyChanged(nameof(SelectedVisitInitialDiagnoses));
                OnPropertyChanged(nameof(SelectedVisitFinalDiagnoses));
            }
        }

        /// <summary>
        /// Gets the selected visit initial diagnoses.
        /// </summary>
        /// <value>
        /// The selected visit initial diagnoses.
        /// </value>
        public string? SelectedVisitInitialDiagnoses => SelectedVisitDiagnoses?.InitialDiagnoses;

        /// <summary>
        /// Gets the selected visit final diagnoses.
        /// </summary>
        /// <value>
        /// The selected visit final diagnoses.
        /// </value>
        public string? SelectedVisitFinalDiagnoses => SelectedVisitDiagnoses?.FinalDiagnoses;

        /// <summary>
        /// Gets or sets the final diagnoses is entered.
        /// </summary>
        /// <value>
        /// The final diagnoses is entered.
        /// </value>
        public bool FinalDiagnosesIsEntered => !string.IsNullOrWhiteSpace(SelectedVisitDiagnoses?.FinalDiagnoses);

        /// <summary>
        /// Gets or sets the selected visit.
        /// </summary>
        /// <value>
        /// The selected visit.
        /// </value>
        /// <exception cref="ArgumentNullException">value</exception>
        public Appointment SelectedVisit
        {
            get { return selectedVisit; }
            set
            {
                selectedVisit = value ?? throw new ArgumentNullException(nameof(value));
                this.selectedVisitRoutineChecks = this.routineChecksDal.GetRoutineChecks((int)this.AppointmentId!);
                this.performingNurse = this.nurseDal.GetNurseWithId(this.selectedVisitRoutineChecks?.NurseId);
                this.OrderedTests = this.labTestOperationDAL.GetLabTestOperations((int)this.AppointmentId!);
                this.selectedVisitDiagnoses = this.diagnosesDAL.GetDiagnoses((int)this.AppointmentId!);
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

        /// <summary>
        /// Gets or sets the visits.
        /// </summary>
        /// <value>
        /// The visits.
        /// </value>
        public ObservableCollection<Appointment> Visits { get; set; }

        /// <summary>
        /// Gets or sets the lab tests.
        /// </summary>
        /// <value>
        /// The lab tests.
        /// </value>
        public List<LabTest> LabTests { get; set; }

        /// <summary>
        /// Gets or sets the ordered tests.
        /// </summary>
        /// <value>
        /// The ordered tests.
        /// </value>
        public List<LabTestOperation> OrderedTests { get; set; }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageVisitsViewModel"/> class.
        /// </summary>
        public ManageVisitsViewModel()
        {
            this.routineChecksDal = new RoutineChecksDAL();
            this.appointmentDal = new AppointmentDAL();
            this.patientDal = new PatientDAL();
            this.nurseDal = new NurseDAL();
            this.labTestDAL = new LabTestDAL();
            this.labTestOperationDAL = new LabTestOperationDAL();
            this.diagnosesDAL = new DiagnosesDAL();

            this.Visits = new ObservableCollection<Appointment>(this.appointmentDal.GetAppointments());
            this.setupLabTests();
        }

        /// <summary>
        /// Enters the diagnoses.
        /// </summary>
        /// <param name="initial">The initial.</param>
        /// <param name="final">The final.</param>
        public void EnterDiagnoses(string? initial, string? final)
        {
            this.diagnosesDAL.EnterDiagnoses((int)AppointmentId!, initial, final);
        }

        /// <summary>
        /// Deletes the ordered test.
        /// </summary>
        /// <param name="labTestOperation">The lab test operation.</param>
        /// <returns></returns>
        public bool DeleteOrderedTest(LabTestOperation labTestOperation)
        {
            if (string.IsNullOrWhiteSpace(labTestOperation.Result))
            {
                this.labTestOperationDAL.DeleteLabTestOperation(labTestOperation);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Orders the test.
        /// </summary>
        /// <param name="labTestCheckBoxes">The lab test checkboxes.</param>
        /// <param name="dateTime">The date time.</param>
        /// <returns></returns>
        public bool OrderTest(IEnumerable<CheckBox> labTestCheckBoxes, DateTime dateTime)
        {
            foreach (CheckBox cb in labTestCheckBoxes)
            {
                LabTest labTest = (LabTest)cb.Tag;

                if (!this.labTestOperationDAL.OrderLabTest(dateTime, (int)this.AppointmentId!, labTest))
                {
                    return false;
                }
                else
                {
                    this.OrderedTests.Add(new LabTestOperation(dateTime, (int)AppointmentId!, labTest.Name, null, null));
                }
            }

            return true;
        }

        /// <summary>
        /// Saves the specified systolic reading.
        /// </summary>
        /// <param name="systolicReading">The systolic reading.</param>
        /// <param name="diastolicReading">The diastolic reading.</param>
        /// <param name="bodyTemperature">The body temperature.</param>
        /// <param name="pulseBPM">The pulse BPM.</param>
        /// <param name="symptoms">The symptoms.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="height">The height.</param>
        public void Save(string systolicReading, string diastolicReading, string bodyTemperature, string pulseBPM, string symptoms, string weight, string height, string nurseUserName)
        {
            var aptId = (int)this.AppointmentId!;
            var systolicInt = int.Parse(systolicReading);
            var diastolicInt = int.Parse(diastolicReading);
            var bodyTemperatureInt = double.Parse(bodyTemperature);
            var pulseBPMInt = int.Parse(pulseBPM);
            var weightDouble = double.Parse(weight);
            var heightDouble = double.Parse(height);

            this.performingNurse = this.nurseDal.GetNurseWithUsername(nurseUserName);

            this.routineChecksDal.SaveRoutineChecks(aptId, systolicInt, diastolicInt, bodyTemperatureInt, pulseBPMInt, symptoms, weightDouble, heightDouble, this.performingNurse!.Id);

            this.selectedVisitRoutineChecks = new RoutineChecks(aptId, systolicInt, diastolicInt, bodyTemperatureInt, pulseBPMInt, symptoms, weightDouble, heightDouble, this.performingNurse!.Id);

            OnPropertyChanged(nameof(selectedVisitRoutineChecks));
            OnPropertyChanged(nameof(PerformingNurseName));
        }

        /// <summary>
        /// Edits the specified systolic reading.
        /// </summary>
        /// <param name="systolicReading">The systolic reading.</param>
        /// <param name="diastolicReading">The diastolic reading.</param>
        /// <param name="bodyTemperature">The body temperature.</param>
        /// <param name="pulseBPM">The pulse BPM.</param>
        /// <param name="symptoms">The symptoms.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="height">The height.</param>
        public void Edit(string systolicReading, string diastolicReading, string bodyTemperature, string pulseBPM, string symptoms, string weight, string height, string nurseUserName)
        {
            var aptId = (int)this.AppointmentId!;
            var systolicInt = int.Parse(systolicReading);
            var diastolicInt = int.Parse(diastolicReading);
            var bodyTemperatureInt = double.Parse(bodyTemperature);
            var pulseBPMInt = int.Parse(pulseBPM);
            var weightDouble = double.Parse(weight);
            var heightDouble = double.Parse(height);

            this.performingNurse = this.nurseDal.GetNurseWithUsername(nurseUserName);

            this.routineChecksDal.EditRoutineChecks(aptId, systolicInt, diastolicInt, bodyTemperatureInt, pulseBPMInt, symptoms, weightDouble, heightDouble, this.performingNurse!.Id);

            this.selectedVisitRoutineChecks = new RoutineChecks(aptId, systolicInt, diastolicInt, bodyTemperatureInt, pulseBPMInt, symptoms, weightDouble, heightDouble, this.performingNurse!.Id);

            OnPropertyChanged(nameof(selectedVisitRoutineChecks));
            OnPropertyChanged(nameof(PerformingNurseName));
        }

        /// <summary>
        /// Updates the patient list with those with the given name and returns true if there exists a patient with the name, false if not.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns>true if there is patient with name, false otherwise</returns>
        public bool SearchByName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                this.Visits = new ObservableCollection<Appointment>(this.appointmentDal.GetAppointments());
                OnPropertyChanged(nameof(Visits));
                return true;
            }
            else if (string.IsNullOrWhiteSpace(firstName))
            {
                var list = this.appointmentDal.GetAppointmentsWithLastName(lastName);

                if (list.Count != 0)
                {
                    this.Visits = new ObservableCollection<Appointment>(this.appointmentDal.GetAppointmentsWithLastName(lastName));
                    OnPropertyChanged(nameof(Visits));
                    return true;
                }

                return false;
            }
            else if (string.IsNullOrWhiteSpace(lastName))
            {
                var list = this.appointmentDal.GetAppointmentsWithFirstName(firstName);

                if (list.Count != 0)
                {
                    this.Visits = new ObservableCollection<Appointment>(this.appointmentDal.GetAppointmentsWithFirstName(firstName));
                    OnPropertyChanged(nameof(Visits));
                    return true;
                }

                return false;
            }
            else
            {
                var list = this.appointmentDal.GetAppointmentsByPatientName(firstName + " " + lastName);

                if (list.Count != 0)
                {
                    this.Visits = new ObservableCollection<Appointment>(this.appointmentDal.GetAppointmentsByPatientName(firstName + " " + lastName));
                    OnPropertyChanged(nameof(Visits));
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Gets the lab test.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public LabTest? GetLabTest(string name)
        {
            return this.LabTests.Find(test => test.Name == name);
        }

        private void setupLabTests()
        {
            this.LabTests = this.labTestDAL.GetLabTests();
        }

        /// <summary>
        /// Gets the nurse with username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public string GetNurseWithUsername(string username)
        {
            return this.nurseDal.GetNurseWithUsername(username).FullName;
        }

    }
}
