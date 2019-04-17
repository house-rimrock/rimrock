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
		//TODO we'll need to restore the method signature below in place of the one below it once we remove the call to the GetRegionsAsync() method we added for testing purposes
		//public IActionResult Index()
		public async Task<IActionResult> Index()
        {
			//TODO remove line below once we've got a better way of testing success of call to API
			// ...because it's just there so we can put a breakpoint on the GetRegionsAsync() method and run it
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
