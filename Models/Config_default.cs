using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public enum Role
    {
        [Description("Admin")]
        Admin,
        [Description("Associate Manager")]
        AssociateManager,
        [Description("Employee")]
        Employee
    }
}
