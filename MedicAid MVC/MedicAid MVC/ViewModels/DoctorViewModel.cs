using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicAid_MVC.Models;

namespace MedicAid_MVC.ViewModels
{
    public class DoctorViewModel
    {
        public List<DoctorModel> Doctors { get; set; }
    }
}