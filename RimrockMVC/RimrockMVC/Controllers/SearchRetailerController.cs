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
    public class SearchRetailerController : Controller
    {
        private readonly IFavRetailerManager _manager;

        public SearchRetailerController(IFavRetailerManager manager)
        {
            _manager = manager;
        }

        /// <summary>
        /// Grabs the Index for the Retailer search, it can also filter the Retailers by a region ID if one is provided.
        /// </summary>
        /// <param name="region">The optional region ID to filter by</param>
        /// <returns>The View containing search results.</returns>
        [HttpGet]
        public async Task<IActionResult> Index(int? region)
        {
            Search<Retailer> search = new Search<Retailer>()
            {
                Results = (region is null || region == 0) ?
                    await ApiClient.GetRetailersAsync() :
                    await ApiClient.GetRetailersByRegionAsync((int)region),
                Regions = await ApiClient.GetRegionsAsync(),
                FilterOption = (region is null)? 0 : (int)region
            };

            try
            {
                string userstr = TempData.Peek("User").ToString();
                User user = JsonConvert.DeserializeObject<User>(userstr);
                List<FavRetailer> favs = await _manager.GetFavRetailers(user.ID);
                List<int> userFavs = new List<int>();
                foreach (var fav in favs)
                {
                    userFavs.Add(fav.RetailerId);
                }
                search.UserFavorites = userFavs;
                ViewData["User"] = user.Name;
            }
            catch
            {
            }

            return View(search);
        }
    }
}
