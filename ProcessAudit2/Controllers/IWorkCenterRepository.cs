using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Controllers
{
    public interface IWorkCenterRepository: IDisposable
    {
        public PaWorkCenter ReadById(int id);
        public IEnumerable<PaWorkCenter> GetAllWorkCenters();
        public void Create(PaWorkCenter center);
        public void Delete(PaWorkCenter cetner);
        public void Update(PaWorkCenter center);

    }
}
