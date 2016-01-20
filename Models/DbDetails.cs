using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Mvc.Rendering;

namespace LeecherReg.Models
{
    public class DbDetails
    {
        
        public List<SelectListItem> Defaults { get; set;}
        
         [Required]
        public string Connection { get; set; }
          
           [Required]
        [Display(Name="Data Source")]
        public string DataSource { get; set; }

 [Required]
        [Display(Name = "Initial Catalog")]
        public string InitialCatalog { get; set; }

 [Required]
        [Display(Name = "Integrated Security")]
        public string IntegratedSecurity { get; set; }

 [Required]
        [Display(Name = "Server User Id")]
        public string ServerUserId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        
        public List<SelectListItem> DefaultConnections()
        {
              List<SelectListItem> items = new List<SelectListItem>();

              items.Add(new SelectListItem { Text = "SQL Server", Value = "0"});

              items.Add(new SelectListItem { Text = "SQLite", Value = "1" });

              items.Add(new SelectListItem { Text = "MySQL", Value = "2"});

              return items;      
        } 
        
        public string Database {get; set;}
    }
}