using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginRegPartials.Models;

namespace LoginRegPartials.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("user/create")]
        public IActionResult Reg(RegUser user)
        {
            if (ModelState.IsValid)
            {
                RegUser newUser = new RegUser()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password
                };
                Console.WriteLine($"First Name: {user.FirstName} Last Name: {user.LastName} Email: {user.Email} Password: {user.Password}");
                return RedirectToAction("Success");

            }
            else
                return View("Index");

        }
        public IActionResult Login(LogUser loggedIn)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine($"Email: {loggedIn.LogEmail} Password: {loggedIn.LogPassword}");
                return RedirectToAction("Success");

            }
            else
                return View("Index");

        }
        public IActionResult Success()
        {
            return View();
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
