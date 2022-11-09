using Microsoft.EntityFrameworkCore;
using ProcessAudit2.Controllers;
using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.DAL
{
    public class FindingsRepository : IFindingRepository
    {
        private CorporateContext _context;
        public FindingsRepository(CorporateContext _DbContext)
        {
            this._context = _DbContext;
        }
        public IEnumerable<PaFinding> GetAllFindings()
        {
            return _context.Pa_Finding.ToList();
        }
        public PaFinding ReadById(int id)
        {
            return _context.Pa_Finding.Find(id);
        }
        public void Create(PaFinding finding)
        {
            Debug.WriteLine(finding.AuditId);
            _context.Pa_Finding.Add(finding);
            _context.SaveChanges();
        }
        public void Delete (int findingID)
        {
            PaFinding finding = _context.Pa_Finding.Find(findingID);
            _context.Pa_Finding.Remove(finding);
            _context.SaveChanges();
        }
        public void Update(PaFinding finding)
        {
            _context.Entry(finding).State = EntityState.Modified;
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
