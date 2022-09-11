using AirCraftFactory.Models;
using AirCraftFactory.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AirCraftFactory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            var IsAuth = AuthenticationService.CheckAuthentication(Request);

            if(IsAuth == false)
                return RedirectToAction("Login", "Authorization");

            return View();
        }
    }
}