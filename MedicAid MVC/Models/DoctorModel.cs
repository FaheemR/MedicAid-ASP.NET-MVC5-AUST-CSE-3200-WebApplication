using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicAid_MVC.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Full Name")]
        public String Name { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Field of Work")]
        public String Specialist { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Hospital Name")]
        public String HospitalName { get; set; }

        [Required]
        [Phone]
        [StringLength(11)]
        [Display(Name = "Contact")]
        public String Contact { get; set; }

        [Required]
        [Display(Name = "Visiting Time")]
        public DateTime VisitTime { get; set; }


        public bool IsAvailable { get; set; }

    }
}