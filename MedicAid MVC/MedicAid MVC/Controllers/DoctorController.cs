using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicAid_MVC.Models;
using MedicAid_MVC.ViewModels;

namespace MedicAid_MVC.Controllers
{
    public class DoctorController : Controller
    {
        private ApplicationDbContext _context;

        public DoctorController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Doctor
        public ActionResult Info(string specialistFilter = "")
        {
            var doctors = from doctor in _context.Doctors group doctor by doctor.Specialist into dateGroup select dateGroup.Key;

            List<string> types = new List<string>();

            foreach (var e in doctors.ToList())
            {
                types.Add(e);
            }

            ViewBag.doctorTypes = types;
            ViewBag.doctorTypeCount = types.Count();

            return View(doctors.ToList());
        }

        // GET: Doctor
        public ActionResult Search(string nameFilter = "", string field = "", string hospitalNameFilter = "")
        {
            var doctors = from doctor in _context.Doctors select doctor ;

            /*var doctorViewModel = new DoctorViewModel
            {
                Doctors = doctors
            };*/

            string specialistFilter = field;

            if (!string.IsNullOrEmpty(nameFilter))
            {
                doctors = doctors.Where(m => m.Name.Contains(nameFilter));
            }

            if (!string.IsNullOrEmpty(specialistFilter))
            {
                doctors = doctors.Where(m => m.Specialist.Contains(specialistFilter));
            }

            if (!string.IsNullOrEmpty(hospitalNameFilter))
            {
                doctors = doctors.Where(m => m.HospitalName.Contains(hospitalNameFilter));
            }

            ViewBag.Name = nameFilter;
            ViewBag.Specialist = specialistFilter;
            ViewBag.HospitalName = hospitalNameFilter;

            return View(doctors.ToList());
        }

        [Authorize(Roles = RoleName.Admin)]
        public ActionResult Create()
        {
            if (Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(DoctorModel doctorModel)
        {
            if (Request.IsAuthenticated)
            {
                _context.Doctors.Add(doctorModel);
                _context.SaveChanges();
                return RedirectToAction("Search", "Doctor");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                DoctorModel doctor = _context.Doctors.Find(id);
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
            }
            catch (RetryLimitExceededException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Search");
            }
            return RedirectToAction("Search");
        }
    }
}