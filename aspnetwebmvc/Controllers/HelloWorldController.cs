using aspnetwebmvc.Models;
using aspnetwebmvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aspnetwebmvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page.";

            var ViewModel = new Address()
            {
                City = "A",
                State = "A",
                Name = "B",
                PostalCode = "B",
                Street = "B",
            };
            return View(ViewModel);
        }

        public string Welcome(string name, int numTime = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTime is : {numTime}");
        }
    }
}
