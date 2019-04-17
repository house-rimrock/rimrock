using Microsoft.AspNetCore.Mvc;
using RimrockMVC.Models.APImodels;
using RimrockMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Controllers
{
    public class SearchRetailerController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(int? region)
        {
            Search<Retailer> search = new Search<Retailer>()
            {
                Results = region is null ?
                    await ApiClient.GetRetailersAsync() :
                    await ApiClient.GetRetailersByRegionAsync((int)region),
                Regions = await ApiClient.GetRegionsAsync()
            };

            return View(search);
        }
    }
}
