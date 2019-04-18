﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RimrockMVC.Models;
using RimrockMVC.Models.APImodels;
using RimrockMVC.Models.Interfaces;
using RimrockMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Controllers
{
    public class SearchLocationController : Controller
    {
        private readonly IFavLocationManager _manager;

        public SearchLocationController(IFavLocationManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? region)
        {
            Search<Location> search = new Search<Location>
            {
                Results = region is null ? 
                    await ApiClient.GetLocationsAsync() :
                    await ApiClient.GetLocationsByRegionAsync((int)region),
                Regions = await ApiClient.GetRegionsAsync()
            };

            try
            {
                string userstr = TempData.Peek("User").ToString();
                User user = JsonConvert.DeserializeObject<User>(userstr);
                List<FavLocation> favs = await _manager.GetFavLocations(user.ID);
                ViewData["User"] = user.Name;
            }
            catch
            {
            }
            
            return View(search);
        }
    }
}
