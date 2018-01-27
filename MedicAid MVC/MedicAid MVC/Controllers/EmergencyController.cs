using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicAid_MVC.Models;

namespace MedicAid_MVC.Controllers
{
    public class EmergencyController : Controller
    {
        private ApplicationDbContext _context;

        public EmergencyController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Emergency
        public ActionResult Search(bool getOnlyTypes = true, string typeFilter = "", string nameFilter = "", string locationFilter = "")
        {

            if (getOnlyTypes)
            {
                var emergencyType = from emergency in _context.Emergency group emergency by emergency.Type into dateGroup select dateGroup.Key;

                List<string> types = new List<string>();

                foreach (var e in emergencyType.ToList())
                {
                    types.Add(e);
                }

                ViewBag.emergencyTypes = types;
                ViewBag.emergencyTypeCount = types.Count();
            }


            var emergencies = from emergency in _context.Emergency select emergency;

            if (!string.IsNullOrEmpty(typeFilter))
            {
                emergencies = emergencies.Where(e => e.Type.Contains(typeFilter));
            }

            if (!string.IsNullOrEmpty(nameFilter))
            {
                emergencies = emergencies.Where(e => e.Name.Contains(nameFilter));
            }

            if (!string.IsNullOrEmpty(locationFilter))
            {
                emergencies = emergencies.Where(e => e.Location.Contains(locationFilter));
            }

            ViewBag.nameFilter = nameFilter;
            ViewBag.locationFilter = locationFilter;
            ViewBag.typeFilter = typeFilter;

            return View(emergencies.ToList());

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(EmergencyModel emergencyModel)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new EmergencyModel();
                viewModel = emergencyModel;
                return View("Create", viewModel);
            }
            _context.Emergency.Add(emergencyModel);
            _context.SaveChanges();
            return RedirectToAction("Search", "Emergency");
        }
    }
}