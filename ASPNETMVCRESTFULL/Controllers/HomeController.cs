using ASPNETMVCRESTFULL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNETMVCRESTFULL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index(string id, string name)
        {
            return "hello, " + id + ", this is " + name;
        }

        public string   ContactUs(string id, string name)
        {
            return "ContactUS, " + id + ", this is " + name;
        }

        public string AboutUs(string id, string name)
        {
            return "About US, " + id + ", this is " + name;
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