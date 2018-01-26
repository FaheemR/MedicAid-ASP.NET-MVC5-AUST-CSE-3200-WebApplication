using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicAid_MVC.Models;

namespace MedicAid_MVC.Controllers
{
    public class PharmacyController : Controller
    {
        private ApplicationDbContext _context;

        public PharmacyController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Pharmacy
        public ActionResult Search()
        {

            var pharmacy = _context.Pharmacy.ToList();
            return View(pharmacy);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(PharmacyModel pharmacyModel)
        {
            _context.Pharmacy.Add(pharmacyModel);
            _context.SaveChanges();
            return RedirectToAction("Search", "Pharmacy");
        }
    }
}