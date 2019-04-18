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

		/// <summary>
		/// Saves new favorited retailer to DB
		/// </summary>
		/// <param name="favRetailer">object containing favorited retailer</param>
		/// <returns>Task</returns>
		public async Task CreateFavRetailer(FavRetailer favRetailer)
        {
            await _context.FavRetailers.AddAsync(favRetailer);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Removes a specific favorite from the database
        /// </summary>
        /// <param name="id">The Id of the location to remove</param>
        /// <returns>Task</returns>
        public async Task DeleteFavRetailer(int id)
        {
            _context.FavRetailers.Remove(await _context.FavRetailers.FindAsync(id));
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets favorited retailers as list
        /// </summary>
        /// <param name="userID">user id</param>
        /// <returns>List of user's favorited retailers</returns>
        public async Task<List<FavRetailer>> GetFavRetailers(int userID)
        {
            return await _context.FavRetailers.Where(fr => fr.UserId == userID).ToListAsync();
        }
    }
}
