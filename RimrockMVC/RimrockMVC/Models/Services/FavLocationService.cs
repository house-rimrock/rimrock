using Microsoft.EntityFrameworkCore;
using RimrockMVC.Data;
using RimrockMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.Services
{
    public class FavLocationService : IFavLocationManager
    {
        private readonly RimrockDBContext _context;

        public FavLocationService(RimrockDBContext context)
        {
            _context = context;
        }

        public async Task CreateFavLocation(FavLocation favLocation)
        {
            _context.FavLocations.Add(favLocation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FavLocation>> GetFavLocations()
        {
            return await _context.FavLocations.ToListAsync();
        }
    }
}
