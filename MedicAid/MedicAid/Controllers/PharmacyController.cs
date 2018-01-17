using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicAid.Controllers
{
    public class PharmacyController : Controller
    {
        public ActionResult Pharmacy()
        {
            ViewBag.Message = "Your Pharmacy page.";

            return View();
        }
    }
}