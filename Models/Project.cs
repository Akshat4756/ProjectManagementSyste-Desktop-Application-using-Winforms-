using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class Project
    {
        public int Id { get; set; } 
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public int ProjectManagerID { get; set; }

        public string Status { get; set; }
        public byte[] Documents { get; set; }
        public DateTime startDate { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
