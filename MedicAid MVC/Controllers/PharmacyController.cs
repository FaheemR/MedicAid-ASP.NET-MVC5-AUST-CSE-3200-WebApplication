﻿using System;
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
        public ActionResult Search(string nameFilter = "", string locationFilter ="")
        {

            var pharmacies = from pharmacy in _context.Pharmacy select pharmacy;

            if(!string.IsNullOrEmpty(nameFilter))
            {
                pharmacies = pharmacies.Where(p => p.Name.Contains(nameFilter));
            }

            if (!string.IsNullOrEmpty(locationFilter))
            {
                pharmacies = pharmacies.Where(p => p.Location.Contains(locationFilter));
            }

            ViewBag.nameFilter = nameFilter;
            ViewBag.locationFilter = locationFilter;

            return View(pharmacies.ToList());
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