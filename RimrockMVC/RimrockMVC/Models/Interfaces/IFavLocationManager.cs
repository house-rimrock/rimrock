using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.Interfaces
{
    public interface IFavLocationManager
    {
        Task CreateFavLocation(FavLocation favLocation);
        Task<List<FavLocation>> GetFavLocations(int id);
        Task DeleteFavLocation(int id);
    }
}
