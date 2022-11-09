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
    public class WorkCenterController : Controller
    {
        private WorkCenterRepository _workCenterRepository;

        public WorkCenterController(CorporateContext context, UserManager<AppUser> userManager)
        {
            this._workCenterRepository = new WorkCenterRepository(context);
        }
        // GET: HomeController1
        public ActionResult Index()
        {
            var centers = _workCenterRepository.GetAllWorkCenters();
            return View(centers);
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
        public ActionResult Create(PaWorkCenter center)
        {
            try
            {
                _workCenterRepository.Create(center);
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
            return View(_workCenterRepository.ReadById(id));
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PaWorkCenter center)
        {
            try
            {
                _workCenterRepository.Delete(center);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
