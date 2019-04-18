using Microsoft.EntityFrameworkCore;
using RimrockMVC.Data;
using RimrockMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.Services
{
    public class UserService : IUserManager
    {
        private RimrockDBContext _context;
        public UserService(RimrockDBContext context)
        {
            _context = context;

        }

		/// <summary>
		/// Adds new user to DB
		/// </summary>
		/// <param name="user">User object to save to DB</param>
		/// <returns>Task object</returns>
        public async Task CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

		/// <summary>
		/// Get user by name from DB
		/// </summary>
		/// <param name="userName">user's name</param>
		/// <returns>User object</returns>
        public async Task<User> GetUser(string userName)
        {
            User user = await _context.Users.FirstOrDefaultAsync<User>(u => u.Name == userName);
            if (user == null)
            {
                User cUser = new User { Name = userName };
                await CreateUser(cUser);
                user = await _context.Users.FirstOrDefaultAsync<User>(u => u.Name == userName);
            }
            return user;
        }
    }
}
