using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicAid.Controllers
{
    public class EmergencyContactsController : Controller
    {
        public ActionResult EmergencyContact()
        {
            ViewBag.Message = "Your EmergencyContact page.";

            return View();
        }

    }
}