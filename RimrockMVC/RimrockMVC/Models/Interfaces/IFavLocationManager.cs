using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.Interfaces
{
    interface IFavLocationManager
    {
        Task CreateFavLocation(FavLocation favLocation);
        Task<IEnumerable<FavLocation>> GetFavLocations();
    }
}
