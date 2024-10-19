using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.Models;

namespace HealthCareSync.ViewModels
{
    /// <summary>
    ///     The view model for the Manage_Patients form
    /// </summary>
    public class ManagePatientsViewModel
    {
        /// <summary>
        ///     Gets the patients.
        /// </summary>
        /// <value>
        ///     The patients.
        /// </value>
        public BindingList<Patient> patients { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePatientsViewModel"/> class.
        /// </summary>
        public ManagePatientsViewModel() 
        {
            this.patients = new BindingList<Patient>{
                new Patient(1, "ahmad", "hammett", DateTime.Now, null, null, Enums.FlagStatus.ACTIVE),
                new Patient(2, "tom", "hanks", DateTime.Now, null, null, Enums.FlagStatus.INACTIVE) 
            };

        }
    }
}
