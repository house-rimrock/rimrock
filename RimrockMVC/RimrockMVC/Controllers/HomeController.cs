using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost, ActionName("Signin")]
        public async Task<IActionResult> Signin(string username)
        {
            User user = await _context.GetUser(username);
            return RedirectToAction("Index", "Favorite", new { User = user });
        }
    }
}
