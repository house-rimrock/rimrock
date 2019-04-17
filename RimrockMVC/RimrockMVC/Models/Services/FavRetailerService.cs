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
            await _context.FavRetailers.AddAsync(favRetailer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FavRetailer>> GetFavRetailers(int id)
        {
            return await _context.FavRetailers.Where(fr => fr.UserId == id).ToListAsync();
        }
    }
}
