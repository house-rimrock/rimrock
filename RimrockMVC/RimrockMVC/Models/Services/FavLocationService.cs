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

		/// <summary>
		/// Saves new favorited location to DB
		/// </summary>
		/// <param name="favLocation">favorited location to save</param>
		/// <returns>Task</returns>
        public async Task CreateFavLocation(FavLocation favLocation)
        {
            await _context.FavLocations.AddAsync(favLocation);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Removes a specific favorite from the database
        /// </summary>
        /// <param name="id">The Id of the location to remove</param>
        /// <returns>Task</returns>
        public async Task DeleteFavLocation(int id)
        {
            _context.FavLocations.Remove(await _context.FavLocations.FindAsync(id));
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets favorited locations as list
        /// </summary>
        /// <param name="userID">user ID</param>
        /// <returns>List of favorited locations</returns>
        public async Task<List<FavLocation>> GetFavLocations(int userID)
        {
            return await _context.FavLocations.Where(fl => fl.UserId == userID).ToListAsync();
        }
    }
}
