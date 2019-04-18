using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// Grabs the Index for the Location search, it can also filter the locations by a region ID if one is provided.
        /// </summary>
        /// <param name="region">The optional region ID to filter by</param>
        /// <returns>The View containing search results.</returns>
        [HttpGet]
        public async Task<IActionResult> Index(int? region)
        {
            Search<Location> search = new Search<Location>
            {
                Results = (region is null || region == 0) ? 
                    await ApiClient.GetLocationsAsync() :
                    await ApiClient.GetLocationsByRegionAsync((int)region),
                Regions = await ApiClient.GetRegionsAsync(),
                FilterOption = (region is null) ? 0 : (int)region
            };

            try
            {
                string userstr = TempData.Peek("User").ToString();
                User user = JsonConvert.DeserializeObject<User>(userstr);
                List<FavLocation> favs = await _manager.GetFavLocations(user.ID);
                List<int> userFavs = new List<int>();
                foreach (var fav in favs)
                {
                    userFavs.Add(fav.LocationId);
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
