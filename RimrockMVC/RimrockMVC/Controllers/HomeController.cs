using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RimrockMVC.Models;
using RimrockMVC.Models.Interfaces;

namespace RimrockMVC.Controllers
{
    public class HomeController : Controller
    {
        public readonly IUserManager _context;

        public HomeController(IUserManager context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
			await ApiClient.GetRegionsAsync();
			return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Index(string Name)
        {
            User user = await _context.GetUser(Name);
            TempData.Clear();
            TempData.Add("User", JsonConvert.SerializeObject(user));
            TempData.Keep("User");
            return RedirectToAction("Index", "Favorite");
        }
    }
}
