using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicAid_MVC.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult CreateAppointment()
        {
            return View();
        }
    }
}