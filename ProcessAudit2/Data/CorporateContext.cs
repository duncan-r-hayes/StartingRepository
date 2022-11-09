using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProcessAudit2.Models;

#nullable disable

namespace ProcessAudit2.Models
{
    public partial class CorporateContext : IdentityDbContext<AppUser>
    {

        public CorporateContext(DbContextOptions<CorporateContext> options) : base(options)
        {
        }

        public virtual DbSet<PaAudits> PA_Audits { get; set; }
        public virtual DbSet<PaFinding> Pa_Finding { get; set; }
        public virtual DbSet<PaArea> PA_Area { get; set; }
        public virtual DbSet<PaWorkCenter> PA_WorkCenter { get; set; }
        public virtual DbSet<PaLocation> PA_Location { get; set; }

       
    }
}
