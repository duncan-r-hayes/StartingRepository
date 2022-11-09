using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Models
{
    public class PaArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlantID { get; set; }
        public string Plant { get; set; }
        [NotMapped]
        public SelectList AreaList { get; set; }
    }
}
