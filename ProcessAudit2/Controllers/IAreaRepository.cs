using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Controllers
{
    public interface IAreaRepository: IDisposable
    {
        public PaArea ReadById(int id);
        public IEnumerable<PaArea> GetAll();
        public void Create(PaArea area);
        public void Update(PaArea area);
        public void Delete(PaArea area);
    }
}
