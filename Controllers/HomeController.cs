using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Message initmess = new Message()
            {
                text = "This is the inital message for the landing page for the site. This message is rendered with the models file."
            };
            return View("Index", initmess);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            NumberArray newnumarr = new NumberArray()
            {
                numArr = new int[] {1,2,3,10,43,5}
            };
            return View("Numbers", newnumarr);
        }
        [HttpGet("user")]
        public IActionResult NewUser()
        {
            NewUser newuser = new NewUser()
            {
                name = "Moose Phillips"
            };
            return View("NewUser", newuser);
        }
        [HttpGet("users")]
        public IActionResult UserList()
        {
            List<NewUser> newlist = new List<NewUser>()
            {
                new NewUser(){name="Moose Phillips"},
                new NewUser(){name="Sarah"},
                new NewUser(){name="Jerry"},
                new NewUser(){name="Rene Ricky"},
                new NewUser(){name="Barbarah"},
            };
            return View("UserList", newlist);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
