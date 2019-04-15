using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Models.Interfaces
{
    public interface IUserManager
    {
        Task CreateUser(User user);

        Task<User> GetUser(string name);
    }
}
