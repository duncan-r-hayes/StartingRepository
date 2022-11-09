using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Models
{
    public class Audit
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Auditor { get; set; }
        public int Shift { get; set; }
        public string Location { get; set; }
        public string Area { get; set; }
        public string WorkCenter { get; set; }
        public string Operator { get; set; }

    }
}
