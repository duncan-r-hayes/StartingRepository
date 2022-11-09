using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

#nullable disable

namespace ProcessAudit2.Models
{
    public partial class PaFinding
    {
        public int Id { get; set; }
        public int AuditId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Assignee { get; set; }
        public string Action { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Picture { get; set; }
        public virtual PaAudits Audit { get; set; }
    }
}
