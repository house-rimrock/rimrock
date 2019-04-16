using System;
using Xunit;
using RimrockMVC.Models;
using RimrockMVC.Models.Services;
using Microsoft.EntityFrameworkCore;
using RimrockMVC.Data;
using System.Linq;
using System.Collections.Generic;

namespace MVCTests
{
    public class UnitTest1
    {
        /*-------------------
        | UserService Tests |
        -------------------*/

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

        /*--------------------------
        | FavLocationService Tests |
        --------------------------*/
        
        [Fact]
        public async void CanCreateFavLocation()
        {
            DbContextOptions<RimrockDBContext> options =
                new DbContextOptionsBuilder<RimrockDBContext>()
                .UseInMemoryDatabase("CanCreateFavLocation").Options;

            using (RimrockDBContext context = new RimrockDBContext(options))
            {
                FavLocation location = new FavLocation() { Name = "Smith Rock" };
                FavLocationService service = new FavLocationService(context);
                await service.CreateFavLocation(location);

                FavLocation result = context.FavLocations.Where(fl => fl.Name == location.Name).FirstOrDefault();

                Assert.Equal(location.Name, result.Name);
            }
        }

        [Fact]
        public async void CanGetFavLocations()
        {
            DbContextOptions<RimrockDBContext> options =
                new DbContextOptionsBuilder<RimrockDBContext>()
                .UseInMemoryDatabase("CanGetFavLocations").Options;

            using (RimrockDBContext context = new RimrockDBContext(options))
            {
                List<FavLocation> locations = new List<FavLocation>()
                {
                    new FavLocation() {Name = "Smith Rock"},
                    new FavLocation() {Name = "Mount Everest"},
                    new FavLocation() {Name = "The Arrowhead"}
                };

                await context.FavLocations.AddRangeAsync(locations);
                await context.SaveChangesAsync();

                FavLocationService service = new FavLocationService(context);

                var result = await service.GetFavLocations();

                Assert.Equal(3, result.Count());
            }
        }

        /*--------------------------
        | FavRetailerService Tests |
        --------------------------*/

        [Fact]
        public async void CanCreateFavRetailer()
        {
            DbContextOptions<RimrockDBContext> options =
                new DbContextOptionsBuilder<RimrockDBContext>()
                .UseInMemoryDatabase("CanCreateFavRetailer").Options;

            using (RimrockDBContext context = new RimrockDBContext(options))
            {
                FavRetailerService service = new FavRetailerService(context);
                FavRetailer retailer = new FavRetailer() { Name = "REI" };
                await service.CreateFavRetailer(retailer);

                FavRetailer result = context.FavRetailers.Where(fr => fr.Name == "REI").FirstOrDefault();

                Assert.Equal(retailer.Name, result.Name);
            }
        }

        [Fact]
        public async void CanGetFavRetailers()
        {
            DbContextOptions<RimrockDBContext> options =
                new DbContextOptionsBuilder<RimrockDBContext>()
                .UseInMemoryDatabase("CanGetFavRetailer").Options;

            using (RimrockDBContext context = new RimrockDBContext(options))
            {
                List<FavRetailer> retailers = new List<FavRetailer>()
                {
                    new FavRetailer() {Name = "Rick's Rock Rodeo"},
                    new FavRetailer() {Name = "Bill's Bouldering Boutique"},
                    new FavRetailer() {Name = "Ropez 'n' Thangz"}
                };

                await context.FavRetailers.AddRangeAsync(retailers);
                await context.SaveChangesAsync();
                FavRetailerService service = new FavRetailerService(context);

                var result = await service.GetFavRetailers();

                Assert.Equal(3, result.Count());
            }
        }
    }
}
