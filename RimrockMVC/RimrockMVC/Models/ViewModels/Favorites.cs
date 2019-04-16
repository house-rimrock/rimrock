using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.ViewModels
{
    public class Favorites
    {
        public List<FavLocation> Locations { get; set; }
        public List<FavRetailer> Retailers { get; set; }
    }
}
