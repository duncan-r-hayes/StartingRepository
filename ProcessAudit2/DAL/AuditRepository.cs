using Microsoft.EntityFrameworkCore;
using ProcessAudit2.Controllers;
using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.DAL
{
    public class AuditRepository : IAuditRepository
    {
        private CorporateContext _context;
        public AuditRepository(CorporateContext _dbContext)
        {
            this._context = _dbContext;
        }
        public IEnumerable<PaAudits> GetAllAudits()
        {
            return _context.PA_Audits.ToList();
        }
        public PaAudits ReadById(int id)
        {
            return _context.PA_Audits.Find(id);
        }
        public void Create(PaAudits PaAudit)
        {
            _context.PA_Audits.Add(PaAudit);
            _context.SaveChanges();
        }
        public void Delete(int PaAuditID)
        {
            PaAudits PaAudit = _context.PA_Audits.Find(PaAuditID);
            _context.PA_Audits.Remove(PaAudit);
        }
        public void Update(PaAudits PaAudit)
        {
            _context.Entry(PaAudit).State = EntityState.Modified;
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
