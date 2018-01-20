using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicAid_MVC.Models;
using MedicAid_MVC.ViewModels;

namespace MedicAid_MVC.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Search()
        {
            var doctors = new List<DoctorModel>
            {
                new DoctorModel(){ Name = "Doctor 1" , HospitalName = "LabAid" , Specialist = "Eye Doctor" , Contact = "01866452" , IsAvailable = true},
                new DoctorModel(){ Name = "Doctor 2" , HospitalName = "LabAid" , Specialist = "Eye Doctor" , Contact = "01866452" , IsAvailable = true},
                new DoctorModel(){ Name = "Doctor 3" , HospitalName = "LabAid" , Specialist = "Eye Doctor" , Contact = "01866452" , IsAvailable = false}

            };

            var doctorViewModel = new DoctorViewModel
            {
                Doctors = doctors
            };

            return View(doctorViewModel);
        }
    }
}