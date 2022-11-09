using Microsoft.EntityFrameworkCore;
using ProcessAudit2.Controllers;
using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.DAL
{
    public class WorkCenterRepository : IWorkCenterRepository
    {
        private CorporateContext _context;
        public WorkCenterRepository(CorporateContext _dbContext)
        {
            this._context = _dbContext;
        }
        public IEnumerable<PaWorkCenter> GetAllWorkCenters()
        {
            return _context.PA_WorkCenter.ToList();
        }
        public PaWorkCenter ReadById(int id)
        {
            return _context.PA_WorkCenter.Find(id);
        }
        public void Create(PaWorkCenter PaWorkCenter)
        {
            _context.PA_WorkCenter.Add(PaWorkCenter);
            _context.SaveChanges();
        }
        public void Delete(PaWorkCenter center)
        {
            _context.PA_WorkCenter.Remove(center);
            _context.SaveChanges();
        }
        public void Update(PaWorkCenter PaWorkCenter)
        {
            _context.Entry(PaWorkCenter).State = EntityState.Modified;
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
