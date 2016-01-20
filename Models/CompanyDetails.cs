using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace LeecherReg.Models
{
    public class CompanyDetails
    {
       
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Please enter minimum 100 characters", MinimumLength = 100)]
        public string Description {get; set;}
    }
}