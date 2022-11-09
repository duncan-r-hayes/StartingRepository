using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProcessAudit2.DAL;
using ProcessAudit2.Models;

namespace ProcessAudit2.Controllers
{
    public class LocationController : Controller
    {
        private CorporateContext _context;
        private IAreaRepository _area;
        private IWorkCenterRepository _workCenters;
        private IAuditRepository _auditRepository;
        private IFindingRepository _findingRepository;
        private ILocationRepository _locationRepository;
        private UserManager<AppUser> userManager;
        public LocationController(CorporateContext context, UserManager<AppUser> userManager)
        {
            this._context = context;
            this._area = new AreaRepository(context);
            this._locationRepository = new LocationRepository(context);
            this._auditRepository = new AuditRepository(context);
            this._findingRepository = new FindingsRepository(context);
            this._workCenters = new WorkCenterRepository(context);
            this.userManager = userManager;
        }
        // GET: HomeController1
        public ActionResult Index()
        {
            var list = _locationRepository.GetAll();
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PaLocation location)
        {
            try
            {
                _locationRepository.Create(location);
                return RedirectToAction(nameof(Index));
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
            var model = _locationRepository.ReadById(id);
            return View(model);
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PaLocation location)
        {
            try
            {
                _locationRepository.Delete(location);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
