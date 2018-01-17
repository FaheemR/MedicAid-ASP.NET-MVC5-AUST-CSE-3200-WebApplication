using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicAid_MVC.Controllers
{
    public class EmergencyController : Controller
    {
        // GET: Emergency
        public ActionResult Search()
        {
            return View();
        }
    }
}