using Microsoft.EntityFrameworkCore;
using ProcessAudit2.Controllers;
using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.DAL
{
    public class AreaRepository : IAreaRepository
    {
        private CorporateContext _context;
        public AreaRepository(CorporateContext _dbContext)
        {
            this._context = _dbContext;
        }
        public IEnumerable<PaArea> GetAll()
        {
            return _context.PA_Area.ToList();
        }
        public PaArea ReadById(int id)
        {
            return _context.PA_Area.Find(id);
        }
        public void Create(PaArea PaArea)
        {
            _context.PA_Area.Add(PaArea);
            _context.SaveChanges();
        }
        public void Delete(PaArea area)
        {
            _context.PA_Area.Remove(area);
            _context.SaveChanges();
        }
        public void Update(PaArea PaArea)
        {
            _context.Entry(PaArea).State = EntityState.Modified;
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
