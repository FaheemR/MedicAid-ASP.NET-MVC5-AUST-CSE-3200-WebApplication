using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicAid_MVC.Utilities
{
    public static class Utilities
    {
        public static string IsActive(this HtmlHelper html, string controler, string action, string action2 = "")
        {
            var routeAction = html.ViewContext.RouteData.Values["action"];
            var routeController = html.ViewContext.RouteData.Values["controller"];

            if(!string.IsNullOrEmpty(action2))
            {
                return (string)routeAction == action && (string)routeController == controler ? "active" : "";

            }

            return (string)routeAction == action && (string)routeController == controler ? "active" : "";
        }
    }
}