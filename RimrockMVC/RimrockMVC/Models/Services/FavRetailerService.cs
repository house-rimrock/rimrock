using Microsoft.EntityFrameworkCore;
using RimrockMVC.Data;
using RimrockMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.Services
{
    public class FavRetailerService : IFavRetailerManager
    {
        private readonly RimrockDBContext _context;

        public FavRetailerService(RimrockDBContext context)
        {
            _context = context;
        }

        public async Task CreateFavRetailer(FavRetailer favRetailer)
        {
            _context.FavRetailers.Add(favRetailer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<FavRetailer>> GetFavRetailers()
        {
            return await _context.FavRetailers.ToListAsync();
        }
    }
}
