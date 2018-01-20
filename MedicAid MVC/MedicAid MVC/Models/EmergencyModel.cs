using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicAid_MVC.Models
{
    public class EmergencyModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String Location { get; set; }
        public String Contact { get; set; }
    }
}