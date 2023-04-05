using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WareHouseMVC.Application.Interfaces;
using WareHouseMVC.Application.Services;
using WareHouseMVC.Web.Models;

namespace WareHouseMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemService _itemService;

        public HomeController(ILogger<HomeController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            List<int> items = _itemService.GetAllItems();
            return View(items);
        }

        public IActionResult ViewListOfItems()
        {
            ViewData["TemporaryData"] = "szt.";
            List<Item> items = new List<Item>();
            items.Add(new Item() { Id = 1, Name = "Alien", CategoryName = "T-Shirts", Amount = 10 });
            items.Add(new Item() { Id = 2, Name = "Hoddie", CategoryName = "Hoddies", Amount = 5 });
            items.Add(new Item() { Id = 3, Name = "Sticker", CategoryName = "Gadgets", Amount = 100 });
            items.Add(new Item() { Id = 4, Name = "Alien", CategoryName = "Hoddies", Amount = 7 });

            return View(items);
        }

        public IActionResult ViewListOfCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category() { Id = 1, Name = "T-Shirts" });
            categories.Add(new Category() { Id = 2, Name = "Hoddies" });
            categories.Add(new Category() { Id = 3, Name = "Trousers" });
            categories.Add(new Category() { Id = 4, Name = "Gadgets" });

            return View(categories);
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