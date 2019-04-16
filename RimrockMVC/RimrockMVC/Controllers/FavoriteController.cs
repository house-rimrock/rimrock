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
            var locations = await _locContext.GetFavLocations();
            
            var retailers = await _retContext.GetFavRetailers();
            ViewData.Add("FavLoc", locations);
            ViewData.Add("FavRet", retailers);
            return View();
        }
    }
}