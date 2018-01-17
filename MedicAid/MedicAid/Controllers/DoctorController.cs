using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicAid.Controllers
{
    public class DoctorController : Controller
    {
        
        public ActionResult Doctor()
        {
            ViewBag.Message = "Your Doctor page.";

            return View();
        }
    }
}