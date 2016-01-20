using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace LeecherReg.Models
{
    public class UserDetails
    {
        
        [Required]
        public string Username { get; set; }

 [Required]
  [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }


        public static List<UserDetails> get()
        {
            var list = new List<UserDetails>();
            var user = new UserDetails();
            user.Email = "macbharat@gmail.com";
            user.Username = "bharat";

            list.Add(user);
            list.Add(new UserDetails() { Email = "bharat@yahoo.com", Username = "matt" });
            return list;
        }
    }
}