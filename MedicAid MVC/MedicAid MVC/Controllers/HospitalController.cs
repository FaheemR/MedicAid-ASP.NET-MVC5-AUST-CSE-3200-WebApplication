using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public ActionResult Search()
        {

            var hospitals = _context.Hospitals.ToList();
            return View(hospitals);
        }
    }
}