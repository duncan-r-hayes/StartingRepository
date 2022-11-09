using Microsoft.EntityFrameworkCore;
using ProcessAudit2.Controllers;
using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.DAL
{
    public class LocationRepository : ILocationRepository
    {
        private CorporateContext _context;
        public LocationRepository(CorporateContext _dbContext)
        {
            this._context = _dbContext;
        }
        public IEnumerable<PaLocation> GetAll()
        {
            return _context.PA_Location.ToList();
        }
        public PaLocation ReadById(int id)
        {
            return _context.PA_Location.Find(id);
        }
        public void Create(PaLocation PaLocation)
        {
            _context.PA_Location.Add(PaLocation);
            _context.SaveChanges();
        }
        public void Delete(PaLocation PaLocation)
        {
            _context.PA_Location.Remove(PaLocation);
            Save();
        }
        public void Update(PaLocation PaLocation)
        {
            _context.Entry(PaLocation).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Save()
        {
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
