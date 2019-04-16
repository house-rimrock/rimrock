using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.Interfaces
{
    public interface IFavRetailerManager
    {
        Task CreateFavRetailer(FavRetailer favRetailer);
        Task<List<FavRetailer>> GetFavRetailers(int id);
    }
}
