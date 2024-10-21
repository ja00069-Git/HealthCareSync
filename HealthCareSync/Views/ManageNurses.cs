using HealthCareSync.Models;
using HealthCareSync.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareSync.Views
{
    public partial class ManageNurses : Form
    {
        private ManageNursesViewModel viewModel;
        private BindingSource nurseBindingSource;
        private Nurse selectedNurse;
        public ManageNurses()
        {
            InitializeComponent();
            this.viewModel = new ManageNursesViewModel();
            this.nurseBindingSource = new BindingSource();
            this.bindToViewModel();
            this.nurseListBox.SelectedIndex = -1;
        }

        private void bindToViewModel()
        {
            this.nurseBindingSource.DataSource = this.viewModel.Nurses;
            this.nurseListBox.DataSource = this.nurseBindingSource;
            this.nurseListBox.DisplayMember = "FullName";

        }

        private void NurseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nurseListBox.SelectedItem is Nurse)
            {
                selectedNurse = (Nurse)nurseListBox.SelectedItem;

                var selectedNurseBindingSource = new BindingSource(selectedNurse, null);
                this.firstNameTextBox.DataBindings.Clear();
                this.firstNameTextBox.DataBindings.Add("Text", selectedNurseBindingSource, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
                this.lastNameTextBox.DataBindings.Clear();
                this.lastNameTextBox.DataBindings.Add("Text", selectedNurseBindingSource, "LastName");
                this.birthDateTextBox.DataBindings.Clear();
                this.birthDateTextBox.DataBindings.Add("Text", selectedNurseBindingSource, "FormattedBirthDate");
                this.usernameTextBox.DataBindings.Clear();
                this.usernameTextBox.DataBindings.Add("Text", selectedNurseBindingSource, "Username");
                this.phoneNumTextBox.DataBindings.Clear();
                this.phoneNumTextBox.DataBindings.Add("Text", selectedNurseBindingSource, "PhoneNumber");
                this.idTextBox.DataBindings.Clear();
                this.idTextBox.DataBindings.Add("Text", selectedNurseBindingSource, "Id");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
