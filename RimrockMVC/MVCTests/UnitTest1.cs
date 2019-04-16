using System;
using Xunit;
using RimrockMVC.Models;
using RimrockMVC.Models.Services;
using Microsoft.EntityFrameworkCore;
using RimrockMVC.Data;
using System.Linq;

namespace MVCTests
{
    public class UnitTest1
    {
        [Fact]
        public async void CanCreateUser()
        {
            DbContextOptions<RimrockDBContext> options =
                new DbContextOptionsBuilder<RimrockDBContext>()
                .UseInMemoryDatabase("CanCreateUser").Options;

            using (RimrockDBContext context = new RimrockDBContext(options))
            {
                UserService users = new UserService(context);
                User user = new User() { Name = "FrankOceanLuvr720" };
                await users.CreateUser(user);

                User dbUser = context.Users.Where(u => u.Name == user.Name).FirstOrDefault();

                Assert.Equal(user.Name, dbUser.Name);
            }
        }
    }
}
