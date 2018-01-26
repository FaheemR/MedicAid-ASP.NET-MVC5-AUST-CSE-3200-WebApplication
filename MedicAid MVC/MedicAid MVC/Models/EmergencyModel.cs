using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicAid_MVC.Models
{
    public class EmergencyModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public String Name { get; set; }

        public String Type { get; set; }
        public String Location { get; set; }

        [Required]
        [Phone]
        [StringLength(11)]
        [Display(Name = "Contact")]
        public String Contact { get; set; }
    }
}