using Microsoft.EntityFrameworkCore;
using RimrockMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RimrockMVC.Data
{
    public class RimrockDBContext : DbContext
    {

        public RimrockDBContext(DbContextOptions<RimrockDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { ID = 1, Name = "TestUserOne" });
            modelBuilder.Entity<User>().HasData(new User { ID = 2, Name = "TestUserTwo" });
            modelBuilder.Entity<FavLocation>().HasData(new FavLocation
            { Id = 1, Name = "TestLocation", RegionId = 1, Cost = "$", UserId = 1 });
            modelBuilder.Entity<FavLocation>().HasData(new FavLocation
            { Id = 2, Name = "TestLocation2", RegionId = 1, Cost = "$", UserId = 1 });
            modelBuilder.Entity<FavLocation>().HasData(new FavLocation
            { Id = 3, Name = "TestLocation3", RegionId = 1, Cost = "$", UserId = 2 });
            modelBuilder.Entity<FavLocation>().HasData(new FavLocation
            { Id = 4, Name = "TestLocation4", RegionId = 1, Cost = "$", UserId = 1 });
            modelBuilder.Entity<FavLocation>().HasData(new FavLocation
            { Id = 5, Name = "TestLocation5", RegionId = 1, Cost = "$", UserId = 2 });

            modelBuilder.Entity<FavRetailer>().HasData(new FavRetailer
            { Id = 1, Name = "TestRetailer", RegionId = 1, Specialty = "Stuff", UserId = 1 });
            modelBuilder.Entity<FavRetailer>().HasData(new FavRetailer
            { Id = 2, Name = "TestRetailer2", RegionId = 1, Specialty = "Stuff", UserId = 2 });
            modelBuilder.Entity<FavRetailer>().HasData(new FavRetailer
            { Id = 3, Name = "TestRetailer3", RegionId = 1, Specialty = "Stuff", UserId = 2 });
            modelBuilder.Entity<FavRetailer>().HasData(new FavRetailer
            { Id = 4, Name = "TestRetailer4", RegionId = 1, Specialty = "Stuff", UserId = 1 });
            modelBuilder.Entity<FavRetailer>().HasData(new FavRetailer
            { Id = 5, Name = "TestRetailer5", RegionId = 1, Specialty = "Stuff", UserId = 2 });
        }


        // Database Tables.
        public DbSet<User> Users { get; set; }
        public DbSet<FavLocation> FavLocations { get; set; }
        public DbSet<FavRetailer> FavRetailers { get; set; }

    }
}
