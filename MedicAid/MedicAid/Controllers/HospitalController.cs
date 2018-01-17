using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicAid.Controllers
{
    public class HospitalController : Controller
    {
        public ActionResult Hospital()
        {
            ViewBag.Message = "Your hospital page.";

            return View();
        }

    }
}