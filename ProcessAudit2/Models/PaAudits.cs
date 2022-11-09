using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ProcessAudit2.Models
{
    public partial class PaAudits
    {
        public PaAudits()
        {
            PaFindings = new List<PaFinding>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Auditor { get; set; }
        public int Shift { get; set; }
        public string Location { get; set; }
        public string Area { get; set; }
        public string WorkCenter { get; set; }
        public string Operator { get; set; }
        public bool Complete { get; set; }
        public virtual ICollection<PaFinding> PaFindings { get; set; }

    }
}
