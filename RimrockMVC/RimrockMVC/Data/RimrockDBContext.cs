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
        }

        // Database Tables
        public DbSet<User> Users { get; set; }
        public DbSet<FavLocation> FavLocations { get; set; }
        public DbSet<FavRetailer> FavRetailers { get; set; }
    }
}
