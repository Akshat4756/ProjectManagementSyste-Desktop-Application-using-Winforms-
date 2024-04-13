using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class Tasks
    {
        public int Id { get; set; } 
        public int ProjectID { get; set; }
        public string TaskName { get; set; }    
        public string TaskDescription { get; set; }
        public int TaskOwnerID { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime AddedDate { get;set; }
    }
}
