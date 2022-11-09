using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProcessAudit2.DAL;
using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Controllers
{
    public class AuditController : Controller
    {
        private CorporateContext _context;
        private IAreaRepository _area;
        private IWorkCenterRepository _workCenters;
        private IAuditRepository _auditRepository;
        private IFindingRepository _findingRepository;
        private UserManager<AppUser> userManager;

        
        public AuditController(CorporateContext context, UserManager<AppUser> userManager)
        {
            this._context = context;
            this._area = new AreaRepository(context);
            this._auditRepository = new AuditRepository(context);
            this._findingRepository = new FindingsRepository(context);
            this._workCenters = new WorkCenterRepository(context);
            this.userManager = userManager;
        }
        [Authorize]
        public ActionResult Index()
        {
            var audits = from audit in _auditRepository.GetAllAudits()
                        select audit;
            return View(audits);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
        [Authorize]
        public ActionResult Create()
        {
            IEnumerable<SelectListItem> items = _area.GetAll().Select(item => new SelectListItem
            {
                Value = item.Name,
                Text = item.Name
            });
            ViewBag.AreaList = items;
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PaAudits audit)
        {
            

            audit.Date = DateTime.Now;
            var user =  await userManager.GetUserAsync(this.User);
            audit.Auditor = user.ToString();
            try
            {
                if (ModelState.IsValid)
                {
                    _auditRepository.Create(audit);
                    return RedirectToAction("Create", "Finding", audit);
                }
                else
                {
                    return View(audit);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //                         //
        // START OF HELPER METHODS //
        //                         // 

        public ActionResult SetComplete(int id)
        {
            var audit = _auditRepository.ReadById(id);
            audit.Complete = true;
            _auditRepository.Update(audit);
            return RedirectToAction("Index", "Home");
        }

        public IEnumerable<String> SetAreas(string plantName) 
        {
            IEnumerable<PaArea> list = _area.GetAll();
            var options = list.Where(x => x.Plant == plantName).Select(x => x.Name).Distinct();
            return options;
        }
        public IEnumerable<String> SetWorkCenters(string areaName) 
        {
            IEnumerable<PaArea> list = _area.GetAll();
            var area = list.Where(x => x.Name == areaName).FirstOrDefault();
            IEnumerable<String> clist = _workCenters.GetAllWorkCenters().Where(x => x.AreaID == area.Id).Select(x => x.Name); ;
            return clist;
        }

        //public IEnumerable<String> SetLocations() 
        //{
        //    //IEnumerable<String> list = _location.GetAll().Select(x => x.Name).Distinct();
        //    return list;
        //}
    }
}
