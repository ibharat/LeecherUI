using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Mvc.Rendering;

namespace LeecherReg.Models
{
    public class UserViewModel
    {
        public List<UserDetails> Users { get; set; }

        public UserDetails Userdetails { get; set; }

    }
}
