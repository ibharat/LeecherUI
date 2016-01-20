using LeecherReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;

namespace LeecherReg.Controllers
{
     public class AccountController : Controller
    {
        //
        // GET: /Account/
        [HttpGet]
        public ActionResult CompanyDetails()
        {
            var model = new CompanyDetails();
            ViewBag.Title = "Company Details";
            return View(model);
        }

        [HttpPost]
        public ActionResult CompanyDetails(CompanyDetails Company)
        {
            if (ModelState.IsValid)
            {
                 string json = JsonConvert.SerializeObject(Company);
                System.IO.File.WriteAllText(@"f:\UI\LeecherReg\Settings\settings.json", json);
                return RedirectToAction("DBConnectionDetails");
            }
            else {
                return View(Company);
            }
        }

        public ActionResult DBConnectionDetails()
        {
            var model = new DbDetails();
            model.Defaults = model.DefaultConnections();
            ViewBag.Title = "Connection Details";
            return View(model);
        }

        [HttpPost]
        public ActionResult DBConnectionDetails(DbDetails details)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("AddUser");
            }
            else
            {
                return View(details);
            }
        }


        public ActionResult AddUser()
        {
            var users = new UserViewModel();
            users.Users = UserDetails.get();
            ViewBag.Title = "User Details";
               string json = JsonConvert.SerializeObject(users.Users);
                System.IO.File.WriteAllText(@"f:\UI\LeecherReg\Settings\settings.json", json);
            return View(users);
        }

       [HttpPost]
        public ActionResult AddUser(UserViewModel details)
        {
            if (ModelState.IsValid)
            {
                var users = new UserViewModel();
                users.Users = UserDetails.get();
                users.Users.Add(new UserDetails() { Email = details.Userdetails.Email, Username = details.Userdetails.Username });
                return View(users);
            }
            else {
                ViewBag.success = false;
                return View(details);
            }
        }
          public ActionResult Finish() {
            return View();
        }
    }
}
