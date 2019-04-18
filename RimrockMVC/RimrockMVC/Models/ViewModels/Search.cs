using RimrockMVC.Models.APImodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.ViewModels
{
    public class Search<T>
    {
        public List<T> Results { get; set; }
        public List<Region> Regions { get; set; }
        public List<int> UserFavorites { get; set; }
    }
}
