using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RimrockMVC.Models;
using RimrockMVC.Models.Interfaces;
using RimrockMVC.Models.ViewModels;

namespace RimrockMVC.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavLocationManager _locContext;
        private readonly IFavRetailerManager _retContext;

        public FavoriteController(IFavLocationManager locContext, IFavRetailerManager retContext)
        {
            _locContext = locContext;
            _retContext = retContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string userSer = TempData.Peek("User").ToString();
            User user = JsonConvert.DeserializeObject<User>(userSer);
            Favorites favs = new Favorites();
            favs.Locations = await _locContext.GetFavLocations(user.ID);
            favs.Retailers = await _retContext.GetFavRetailers(user.ID);
            return View(favs);
        }
    }
}