using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Models
{
    public class Finding
    {
        public int Id { get; set; }
        public int Audit_ID { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Assignee { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }

    }
}
