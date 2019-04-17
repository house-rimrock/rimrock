using Microsoft.AspNetCore.Mvc;
using RimrockMVC.Models.APImodels;
using RimrockMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Controllers
{
    public class SearchLocationController : Controller
    {
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

            return View(search);
        }
    }
}
