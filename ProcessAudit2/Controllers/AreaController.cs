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
    public class AreaController : Controller
    {
        private AreaRepository _areaRepository;

        // GET: HomeController1
        public AreaController(CorporateContext context, UserManager<AppUser> userManager)
        {
            this._areaRepository = new AreaRepository(context);
        }
        public ActionResult Index()
        {
            return View(_areaRepository.GetAll());
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
        public ActionResult Create(PaArea area)
        {
            try
            {
                _areaRepository.Create(area);
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
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PaArea area)
        {
            try
            {
                _areaRepository.Delete(area);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IEnumerable<string> SetArea(int plantId) 
        {
            var list = _areaRepository.GetAll().Where(a => a.PlantID == plantId);
            var listed = list.Select(x => x.Name);
            return listed;
        }

        public void GetPlants()
        {
            
        }
    }
}
