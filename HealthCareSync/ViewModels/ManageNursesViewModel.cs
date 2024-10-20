using HealthCareSync.Models;
using System.ComponentModel;

namespace HealthCareSync.ViewModels
{
    public class ManageNursesViewModel
    {
        /// <summary>
        /// Gets the nurses.
        /// </summary>
        /// <value>
        /// The nurses.
        /// </value>
        public BindingList<Nurse> nurses { get; }

        public ManageNursesViewModel()
        {
            this.nurses = new BindingList<Nurse>{
                new Nurse(1, "Sally", "Mae", new DateTime(2000, 10, 18), "614-456-1598", 0123, "ahmed"),
                new Nurse(2, "Fatima", "Dalwai", DateTime.Now, null, null, "jabesi"),
                new Nurse(2, "Mary", "Jane", DateTime.Now, null, null, "rahman")
            };
        }
    }
}
