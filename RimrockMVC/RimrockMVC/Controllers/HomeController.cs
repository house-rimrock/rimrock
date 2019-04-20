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
        /// <summary>
        /// Returns Home Index View with login.
        /// </summary>
        /// <returns>Home Index View</returns>
        [HttpGet]
		public IActionResult Index()
        {
			return View();
        }
        /// <summary>
        /// Takes in the username from the form on the home index and logs in the user. It then redirects to the Favorites
        /// </summary>
        /// <param name="Name">the username</param>
        /// <returns>Redirect to Favorites</returns>
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
