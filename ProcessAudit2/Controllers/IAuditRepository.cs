using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Controllers
{
    public interface IAuditRepository : IDisposable
    {
        public PaAudits ReadById(int id);
        public void Create(PaAudits audit);
        public void Update(PaAudits audit);
        public void Delete(int id);
        public IEnumerable<PaAudits> GetAllAudits();
    }
}
