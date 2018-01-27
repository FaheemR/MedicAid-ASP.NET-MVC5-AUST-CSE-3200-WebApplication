using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MedicAid_MVC.Models;

namespace MedicAid_MVC.Controllers
{
    public class HospitalController : Controller
    {
        private ApplicationDbContext _context;

        public HospitalController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Hospital
        public ActionResult Search(string nameFilter = "", string locationFilter = "")
        {

            var hospitals = from hospital in _context.Hospitals select hospital;


            if (!string.IsNullOrEmpty(nameFilter))
            {
                hospitals = hospitals.Where(p => p.Name.Contains(nameFilter));
            }

            if (!string.IsNullOrEmpty(locationFilter))
            {
                hospitals = hospitals.Where(p => p.Location.Contains(locationFilter));
            }

            ViewBag.nameFilter = nameFilter;
            ViewBag.locationFilter = locationFilter;

            return View(hospitals.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(HospitalModel hospitalModel)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new HospitalModel();
                viewModel = hospitalModel;
                return View("Create", viewModel);
            }
            _context.Hospitals.Add(hospitalModel);
            _context.SaveChanges();
            return RedirectToAction("Search", "Hospital");
        }
    }
}