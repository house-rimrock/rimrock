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
        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUser(string name)
        {
            User user = await _context.Users.FirstOrDefaultAsync<User>(u => u.Name == name);
            if (user == null)
            {
                User cUser = new User { Name = name };
                await CreateUser(cUser);
            }
            return user;
        }
    }
}
