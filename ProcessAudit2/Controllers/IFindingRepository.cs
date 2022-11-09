using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Controllers
{
    public interface IFindingRepository
    {
        public PaFinding ReadById(int id);
        public void Create(PaFinding audit);
        public void Update(PaFinding audit);
        public void Delete(int id);
        public IEnumerable<PaFinding> GetAllFindings();
    }
}
