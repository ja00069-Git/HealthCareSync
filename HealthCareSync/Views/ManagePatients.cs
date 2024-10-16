using System.ComponentModel;
using System.Windows.Forms;
using HealthCareSync.Models;
using HealthCareSync.ViewModels;

namespace HealthCareSync.Views
{
    public partial class Manage_Patients : Form
    {
        private ManagePatientsViewModel viewModel;
        private BindingSource patientBindingSource;
        private Patient selectedPatient;

        public Manage_Patients()
        {
            InitializeComponent();
            this.viewModel = new ManagePatientsViewModel();
            this.patientBindingSource = new BindingSource();

            BindToViewModel();
            this.patientListBox.SelectedIndex = -1;
        }

        private void BindToViewModel()
        {
            this.patientBindingSource.DataSource = this.viewModel.patients;
            this.patientListBox.DataSource = this.patientBindingSource;
            this.patientListBox.DisplayMember = "FullName";
        }

        private void PatientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patientListBox.SelectedItem is Patient)
            {
                selectedPatient = (Patient)patientListBox.SelectedItem;
           
                var selectedPatientBindingSource = new BindingSource(selectedPatient, null);
                this.firstNameTextBox.DataBindings.Clear(); 
                this.firstNameTextBox.DataBindings.Add("Text", selectedPatientBindingSource, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
                this.lastNameTextBox.DataBindings.Clear();
                this.lastNameTextBox.DataBindings.Add("Text", selectedPatientBindingSource, "LastName");
                this.birthDateTextBox.DataBindings.Clear();
                this.birthDateTextBox.DataBindings.Add("Text", selectedPatientBindingSource, "FormattedBirthDate");
                this.flagStatusTextBox.DataBindings.Clear();
                this.flagStatusTextBox.DataBindings.Add("Text", selectedPatientBindingSource, "FlagStatus");
                this.idTextBox.DataBindings.Clear();
                this.idTextBox.DataBindings.Add("Text", selectedPatientBindingSource, "Id");
                //this.zipCodeTextBox.DataBindings.Add("Text", selectedPatient.Address, "Zip", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
