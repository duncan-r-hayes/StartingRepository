using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ProcessAudit2.DAL;
using ProcessAudit2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessAudit2.Controllers
{
    public class FindingController : Controller
    {
        private string connString = "Data Source=S-CTP-JAK-IG01;Initial Catalog=Corporate;User ID=sa;Password=80Vinecrest16;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True";
        private CorporateContext _context;
        private IFindingRepository _findingRepository;
        private IAuditRepository _auditRepository;
        private IWebHostEnvironment _webHostEnviroment;
        private UserManager<AppUser> _userManager;
        public FindingController(CorporateContext context, IWebHostEnvironment webHostEnvironment, UserManager<AppUser> userManager)
        {
            this._context = context;
            this._auditRepository = new AuditRepository(context);
            this._findingRepository = new FindingsRepository(context);
            this._webHostEnviroment = webHostEnvironment;
            this._userManager = userManager;
        }
        // GET: HomeController1
        [Authorize]
        public ActionResult MyActions()
        {
            var user = _userManager.GetUserAsync(this.User).Result;
            var findings = _findingRepository.GetAllFindings().Where(f => f.Assignee == user.UserName && f.Status != "Closed");
            return View(findings);
        }

        // GET: HomeController1/Details/5
        public ActionResult RelatedFindings(int auditId)
        {
            List<PaFinding> findings = _findingRepository.GetAllFindings().Where(f => f.AuditId == auditId).ToList();
            ViewBag.Audit = _auditRepository.ReadById(auditId).Id;
            return View(findings);
        }

        public ActionResult ReturnToAudit(int auditId) 
        {
            var audit = _auditRepository.ReadById(auditId);
            return RedirectToAction("Create", "Finding",audit);
        }
        // GET: HomeController1/Create
        [Authorize]
        public ActionResult Create(PaAudits audit)
        {
            ViewBag.Audit = audit;
            ViewBag.Id = audit.Id;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand($"select Count(AuditId) as Countr FROM PA_Finding WHERE AuditId = {audit.Id}", conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                var count = 0;
                while (reader.Read())
                {
                    count = (int)reader["Countr"];
                }
                ViewBag.CountOfFindings = count;
            }
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PaFinding finding)
        {
            
            if (finding.Picture != null) 
            {
                string folder = "images/";
                folder += Guid.NewGuid().ToString() + finding.Picture.FileName;
                string serverFolder = Path.Combine(_webHostEnviroment.WebRootPath, folder);
                FileStream fs = new FileStream(serverFolder, FileMode.Create);
                await finding.Picture.CopyToAsync(fs);
                fs.Close();
                finding.Image = folder;
            }
            var audit = _auditRepository.ReadById(finding.AuditId);
            finding.Date = DateTime.Now;
            _findingRepository.Create(finding);
            return RedirectToAction("Create", "Finding", audit);
            
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var finding = _findingRepository.ReadById(id);
            return View(finding);
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PaFinding finding)
        {
            
            if (finding.Image != null && finding.Picture != null)
            {
                Debug.WriteLine(finding.Picture);
                System.IO.File.Delete(Path.Combine(_webHostEnviroment.WebRootPath, finding.Image));
                string folder = "images\\";
                folder += Guid.NewGuid().ToString() + finding.Picture.FileName;
                string serverFolder = Path.Combine(_webHostEnviroment.WebRootPath, folder);
                FileStream fs = new FileStream(serverFolder, FileMode.Create);
                await finding.Picture.CopyToAsync(fs);
                fs.Close();
                finding.Image = folder;
            }
            if (finding.Picture != null) 
            {
                string folder = "images\\";
                folder += Guid.NewGuid().ToString() + finding.Picture.FileName;
                string serverFolder = Path.Combine(_webHostEnviroment.WebRootPath, folder);
                FileStream fs = new FileStream(serverFolder, FileMode.Create);
                await finding.Picture.CopyToAsync(fs);
                fs.Close();
                finding.Image = folder;
            }
            try
            {
                finding.Picture = null;
                _findingRepository.Update(finding);
                return RedirectToAction("RelatedFindings","Finding", new { auditId = finding.AuditId });
            }
            catch
            {
                return RedirectToAction("RelatedFindings", "Finding", new { auditId = finding.AuditId });
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            var finding = _findingRepository.ReadById(id);
            return View(finding);
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var finding = _findingRepository.ReadById(id);
            int auditId = finding.AuditId;

            try
            {
                _findingRepository.Delete(id);
                return RedirectToAction("RelatedFindings", "Finding", new { auditId = auditId});
            }
            catch
            {
                return RedirectToAction("RelatedFindings", "Finding", new { auditId = auditId });
            }
        }

        //                                   //
        //      START OF HELPER METHODS      //
        //                                   //
        [Authorize]
        public async Task<ActionResult> ResumeAudit() 
        {

            var user = await _userManager.GetUserAsync(this.User);
            Debug.WriteLine(user);
            var auditId = 0;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand command = new SqlCommand($"select top 1 * from PA_Audits where Auditor = '{user}' AND Complete = 'false' Order By Id desc", conn);
            conn.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    auditId = (int)reader["ID"];
                }
            }
            var audit = _auditRepository.ReadById(auditId);
            if (audit != null)
            {
                return RedirectToAction("Create", "Finding", audit);
            }
            else 
            {
                TempData["shortMessage"] = "Error, No Previous Audit Avaliable";
                return RedirectToAction("Index", "Home");
            }


        }

        public IEnumerable<String> SetAssignees(string plantName)
        {
            IEnumerable<AppUser> list = _userManager.GetUsersInRoleAsync("User").Result;
            var options = list.Select(x => x.UserName).Distinct();
            return options;
        }

        public IActionResult CompleteFinding(int id)
        {
            var finding = _findingRepository.ReadById(id);
            finding.Status = "Closed";
            _findingRepository.Update(finding);
            return RedirectToAction("MyActions");
        }
    }
}
