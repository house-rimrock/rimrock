using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.Interfaces
{
    interface IFavRetailerManager
    {
        Task CreateFavRetailer(FavRetailer favRetailer);
        Task<IEnumerable<FavRetailer>> GetFavRetailers();
    }
}
