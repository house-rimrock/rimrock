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

        [Fact]
        public async void CanGetUser()
        {
            DbContextOptions<RimrockDBContext> options =
                new DbContextOptionsBuilder<RimrockDBContext>()
                .UseInMemoryDatabase("CanGetUser").Options;

            using (RimrockDBContext context = new RimrockDBContext(options))
            {
                User testUser = new User() { Name = "xXBloodyFangzXx" };
                await context.AddAsync(testUser);
                await context.SaveChangesAsync();
                UserService service = new UserService(context);

                User result = await service.GetUser(testUser.Name);

                Assert.Equal(testUser.Name, result.Name);
            }
        }
    }
}
