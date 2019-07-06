using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    // Controller
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            string message = "This is my message to you ooo ooo!";

            return View("Index", message);
        }

        [HttpGet("numbers")]
        public ViewResult Numbers()
        {
            int[] numbers =
            {
                5,
                19,
                12,
                1,
                10,
                7,
                9
            };
            return View("Numbers", numbers);
        }
        [HttpGet("users")]
        public ViewResult Users()
        {
            List<User> users = new List<User>();
            User User1 = new User()
            {
                FirstName = "Steve",
                LastName = "Yzerman"
            };
            User User2 = new User()
            {
                FirstName = "Nick",
                LastName = "Lidstrom"
            };
            User User3 = new User()
            {
                FirstName = "Gordie",
                LastName = "Howe"
            };
            users.Add(User1);
            users.Add(User2);
            users.Add(User3);

            return View("Users", users);
        }
        [HttpGet("user")]
        public ViewResult User()
        {
            User User1 = new User()
            {
                FirstName = "Steve",
                LastName = "Yzerman"
            };
            return View("User", User1);
        }
    }
}
