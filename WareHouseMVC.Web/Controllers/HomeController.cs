using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WareHouseMVC.Web.Models;

namespace WareHouseMVC.Web.Controllers
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

        public IActionResult ViewListOfItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Id = 1, Name = "Alien", CategoryName = "T-Shirts" });
            items.Add(new Item() { Id = 2, Name = "Hoddie", CategoryName = "Hoddies" });

            return View(items);
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