using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.Enums
{
    /// <summary>
    /// Represents the flag statuses of a patient, inactive patients cannot be used in the system and vice versa
    /// </summary>
    public enum FlagStatus
    {
        ACTIVE,
        INACTIVE
    }
}
