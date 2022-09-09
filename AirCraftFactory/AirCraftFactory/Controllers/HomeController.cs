using AirCraftFactory.Models;
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
    }
}