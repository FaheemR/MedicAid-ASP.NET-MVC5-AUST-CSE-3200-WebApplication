using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicAid_MVC.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Specialist { get; set; }
        public String HospitalName { get; set; }
        public String Contact { get; set; }
        public bool IsAvailable { get; set; }

    }
}