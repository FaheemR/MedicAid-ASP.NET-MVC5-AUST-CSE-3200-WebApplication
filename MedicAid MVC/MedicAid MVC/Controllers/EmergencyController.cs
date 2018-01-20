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
        public ActionResult Search()
        {

            var emergency = _context.Emergency.ToList();
            return View(emergency);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}