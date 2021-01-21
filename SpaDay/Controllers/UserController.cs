using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        //GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        // render the form
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Password do not match! Try again!";
                ViewBag.UserName = newUser.UserName;
                ViewBag.eMail = newUser.Email;
                return View("Add");
            }
        }
    }
    
}
