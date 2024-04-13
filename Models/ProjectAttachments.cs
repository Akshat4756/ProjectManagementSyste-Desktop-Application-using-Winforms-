using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class ProjectAttachments
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string AttachmentType { get; set; }
        public int ProjectID { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
