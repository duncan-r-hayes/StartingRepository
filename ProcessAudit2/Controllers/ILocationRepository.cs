using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Controllers
{
    public interface ILocationRepository
    {
        public PaLocation ReadById(int id);
        public IEnumerable<PaLocation> GetAll();
        public void Create(PaLocation location);
        public void Update(PaLocation location);
        public void Delete(PaLocation location);
    }
}
