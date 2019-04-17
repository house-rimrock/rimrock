using Microsoft.EntityFrameworkCore;
using RimrockMVC.Data;
using RimrockMVC.Models;
using RimrockMVC.Models.APImodels;
using RimrockMVC.Models.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestRimrockMVC
{
    public class UnitTest1
    {
        /////////////////////////////////
        // Test getters and setters
        /////////////////////////////////

        // MODELS THAT REPLICATE API MODELS (FOR PARSING JSON FROM API)

        [Fact]
        public void CanGetRegionID()
        {
            // Arrange
            Region region = new Region();

            // Assert
            Assert.Equal(0, region.ID);
        }

        [Fact]
        public void CanSetRegionID()
        {
            // Arrange
            Region region = new Region();

            // Act
            region.ID = 3;

            // Assert
            Assert.Equal(3, region.ID);
        }

        [Fact]
        public void CanGetRegionName()
        {
            // Arrange
            Region region = new Region();

            // Assert
            Assert.Null(region.Name);
        }

        [Fact]
        public void CanSetRegionName()
        {
            // Arrange
            Region region = new Region();

            // Act
            region.Name = "The Okanogan, WA";

            // Assert
            Assert.Equal("The Okanogan, WA", region.Name);
        }

        [Fact]
        public void CanGetLocationID()
        {
            // Arrange
            Location location = new Location();

            // Assert
            Assert.Equal(0, location.ID);
        }

        [Fact]
        public void CanSetLocationName()
        {
            // Arrange
            Location location = new Location();

            // Act
            location.Name = "Dry Falls";

            // Assert
            Assert.Equal("Dry Falls", location.Name);
        }

        [Fact]
        public void CanGetLocationCost()
        {
            // Arrange
            Location location = new Location();

            // Assert
            Assert.Null(location.Cost);
        }

        [Fact]
        public void CanSetLocationCost()
        {
            // Arrange
            Location location = new Location();

            // Act
            location.Cost = "$$";

            // Assert
            Assert.Equal("$$", location.Cost);
        }

        [Fact]
        public void CanGetLocationForeignKey()
        {
            // Arrange
            Location location = new Location();

            // Assert
            Assert.Equal(0, location.RegionID);
        }

        [Fact]
        public void CanSetLocationForeignKey()
        {
            // Arrange
            Location location = new Location();

            // Act
            location.RegionID = 2;

            // Assert
            Assert.Equal(2, location.RegionID);
        }

        [Fact]
        public void CanGetRetailerID()
        {
            // Arrange
            Retailer retailer = new Retailer();

            // Assert
            Assert.Equal(0, retailer.ID);
        }

        [Fact]
        public void CanSetRetailerID()
        {
            // Arrange
            Retailer retailer = new Retailer();

            // Act
            retailer.Name = "Second Ascents";

            // Assert
            Assert.Equal("Second Ascents", retailer.Name);
        }

        [Fact]
        public void CanGetRetailerSpecialty()
        {
            // Arrange
            Retailer retailer = new Retailer();

            // Assert
            Assert.Null(retailer.Specialty);
        }

        [Fact]
        public void CanSetRetailerSpecialty()
        {
            // Arrange
            Retailer retailer = new Retailer();

            // Act
            retailer.Specialty = "Climbing";

            // Assert
            Assert.Equal("Climbing", retailer.Specialty);
        }

        [Fact]
        public void CanGetRetailerForeignKey()
        {
            // Arrange
            Retailer retailer = new Retailer();

            // Assert
            Assert.Equal(0, retailer.RegionID);
        }

        [Fact]
        public void CanSetRetailerForeignKey()
        {
            // Arrange
            Retailer retailer = new Retailer();

            // Act
            retailer.RegionID = 2;

            // Assert
            Assert.Equal(2, retailer.RegionID);
        }

        // Main models

        [Fact]
        public void CanGetFavRetailerID()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Assert
            Assert.Equal(0, favRetailer.Id);
        }

        [Fact]
        public void CanSetFavRetailerID()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Act
            favRetailer.Id = 3;

            // Assert
            Assert.Equal(3, favRetailer.Id);
        }

        [Fact]
        public void CanGetFavRetailerUserId()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Assert
            Assert.Equal(0, favRetailer.UserId);
        }

        [Fact]
        public void CanSetFavRetailerUserId()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Act
            favRetailer.UserId = 3;

            // Assert
            Assert.Equal(3, favRetailer.UserId);
        }

        [Fact]
        public void CanGetFavRetailerRegionId()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Assert
            Assert.Equal(0, favRetailer.RegionId);
        }

        [Fact]
        public void CanSetFavRetailerRegionId()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Act
            favRetailer.RegionId = 3;

            // Assert
            Assert.Equal(3, favRetailer.RegionId);
        }

        [Fact]
        public void CanGetFavRetailerName()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Assert
            Assert.Null(favRetailer.Name);
        }

        [Fact]
        public void CanSetFavRetailerName()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Act
            favRetailer.Name = "Climbing Emporium";

            // Assert
            Assert.Equal("Climbing Emporium", favRetailer.Name);
        }

        [Fact]
        public void CanGetFavRetailerSpecialty()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Assert
            Assert.Null(favRetailer.Specialty);
        }

        [Fact]
        public void CanSetFavRetailerSpecialty()
        {
            // Arrange
            FavRetailer favRetailer = new FavRetailer();

            // Act
            favRetailer.Specialty = "Rocks";

            // Assert
            Assert.Equal("Rocks", favRetailer.Specialty);
        }

        [Fact]
        public void CanGetUserId()
        {
            // Arrange
            User user = new User();

            // Assert
            Assert.Equal(0, user.ID);
        }

        [Fact]
        public void CanSetUserId()
        {
            // Arrange
            User user = new User();

            // Act
            user.ID = 3;

            // Assert
            Assert.Equal(3, user.ID);
        }

        [Fact]
        public void CanGetUserName()
        {
            // Arrange
            User user = new User();

            // Assert
            Assert.Null(user.Name);
        }

        [Fact]
        public void CanSetUserName()
        {
            // Arrange
            User user = new User();

            // Act
            user.Name = "Andrew";

            // Assert
            Assert.Equal("Andrew", user.Name);
        }

        ///////////////////////////////////////////

        [Fact]
        public void CanGetFavLoctionID()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();

            // Assert
            Assert.Equal(0, favLocation.Id);
        }

        [Fact]
        public void CanSetFavLoctionID()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();


            // Act
            favLocation.Id = 3;

            // Assert
            Assert.Equal(3, favLocation.Id);
        }

        [Fact]
        public void CanGetFavLoctionUserId()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();


            // Assert
            Assert.Equal(0, favLocation.UserId);
        }

        [Fact]
        public void CanSetFavLoctionUserId()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();


            // Act
            favLocation.UserId = 3;

            // Assert
            Assert.Equal(3, favLocation.UserId);
        }

        [Fact]
        public void CanGetFavLoctionRegionId()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();


            // Assert
            Assert.Equal(0, favLocation.RegionId);
        }

        [Fact]
        public void CanSetFavLoctionRegionId()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();


            // Act
            favLocation.RegionId = 3;

            // Assert
            Assert.Equal(3, favLocation.RegionId);
        }

        [Fact]
        public void CanGetFavLoctionName()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();


            // Assert
            Assert.Null(favLocation.Name);
        }

        [Fact]
        public void CanSetFavLoctionName()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();


            // Act
            favLocation.Name = "Climbing Rock";

            // Assert
            Assert.Equal("Climbing Rock", favLocation.Name);
        }

        [Fact]
        public void CanGetFavLoctionCost()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();


            // Assert
            Assert.Null(favLocation.Cost);
        }

        [Fact]
        public void CanSetFavLoctionCost()
        {
            // Arrange
            FavLocation favLocation = new FavLocation();

            // Act
            favLocation.Cost = "Rocks";

            // Assert
            Assert.Equal("Rocks", favLocation.Cost);
        }


		/////////////////////////////////////
		// Tests for MVC app CRUD operations
		/////////////////////////////////////

		/// <summary>
		/// Tests whether can create a new user in DB
		/// </summary>
		[Fact]
		public async void CreateUser_CanCreateSingleUser()
		{
			DbContextOptions<RimrockDBContext> options = new DbContextOptionsBuilder<RimrockDBContext>().UseInMemoryDatabase("CanCreateSingleUser").Options;

			using (RimrockDBContext context = new RimrockDBContext(options))
			{
				// Arrange
				User newUser = new User();
				newUser.ID = 1;
				newUser.Name = "Phil Werner";

				// Act
				UserService userService = new UserService(context);

				await userService.CreateUser(newUser);

				User userFromDb = await context.Users
									.FirstOrDefaultAsync(u => u.Name == newUser.Name);

				// Assert
				Assert.Equal(userFromDb, newUser);
			};
		}

		/// <summary>
		/// Tests whether can get user by name from DB
		/// </summary>
		[Fact]
		public async void GetUser_CanGetSingleUser()
		{
			DbContextOptions<RimrockDBContext> options = new DbContextOptionsBuilder<RimrockDBContext>().UseInMemoryDatabase("CanGetSingleUserByName").Options;

			using (RimrockDBContext context = new RimrockDBContext(options))
			{
				// Arrange
				User newUser = new User();
				newUser.ID = 1;
				newUser.Name = "Jason Burns";

				// Act
				UserService userService = new UserService(context);
				await context.Users.AddAsync(newUser);
				await context.SaveChangesAsync();

				User userFromDb = await userService.GetUser(newUser.Name);

				// Assert
				Assert.Equal(userFromDb, newUser);
			};
		}

		/// <summary>
		/// Tests whether can save a new favorite location to DB
		/// </summary>
		[Fact]
		public async void CreateFavLocation_CanAddNewFavLocationInDatabase()
		{
			DbContextOptions<RimrockDBContext> options = new DbContextOptionsBuilder<RimrockDBContext>().UseInMemoryDatabase("CanCreateNewFavLocation").Options;

			using (RimrockDBContext context = new RimrockDBContext(options))
			{
				// Arrange
				FavLocation favLocation = new FavLocation();
				favLocation.Id = 1;
				favLocation.Name = "Yosemite";
				favLocation.Cost = "$$";

				// Act
				FavLocationService favLocService = new FavLocationService(context);

				await favLocService.CreateFavLocation(favLocation);

				FavLocation favLocationFromDb = await context.FavLocations
											.FirstOrDefaultAsync(fl => fl.Name == favLocation.Name);

				// Assert
				Assert.Equal(favLocationFromDb, favLocation);
			};
		}

		/// <summary>
		/// Tests whether can get favorite location by ID from DB
		/// </summary>
		[Theory]
		[InlineData(1, 4, 4, true)]
		[InlineData(2, 7, 5, false)]
		public async void GetFavLocation_CanGetFavLocationById(int numForFavLocId, int numToTest, int numForUserId, bool expectedBool)
		{
			DbContextOptions<RimrockDBContext> options = new DbContextOptionsBuilder<RimrockDBContext>().UseInMemoryDatabase("CanGetFavLocById").Options;

			using (RimrockDBContext context = new RimrockDBContext(options))
			{
				// Arrange
				FavLocation newFavLocation = new FavLocation();
				newFavLocation.Id = numForFavLocId;
				newFavLocation.UserId = numForUserId;
				newFavLocation.RegionId = 2;
				newFavLocation.Name = "Grand Teton";
				newFavLocation.Cost = "$$";

				FavLocationService favLocService = new FavLocationService(context);

				await context.FavLocations.AddAsync(newFavLocation);
				await context.SaveChangesAsync();

				// Act
				List<FavLocation> favLocationListFromDb = await favLocService.GetFavLocations(newFavLocation.UserId);

				// Boolean test (needed for Theory-type unit test)
				bool actualBool = false; 
				if (numToTest == favLocationListFromDb[0].UserId)
				{
					actualBool = true;
				}

				// Assert
				Assert.Equal(actualBool, expectedBool);
			};
		}

		/// <summary>
		/// Tests whether can save a new favorite retailer to DB
		/// </summary>
		[Fact]
		public async void CreateFavRetailer_CanAddNewFavRetailerInDatabase()
		{
			DbContextOptions<RimrockDBContext> options = new DbContextOptionsBuilder<RimrockDBContext>().UseInMemoryDatabase("CanCreateNewFavRetailer").Options;

			using (RimrockDBContext context = new RimrockDBContext(options))
			{
				// Arrange
				FavRetailer favRetailer = new FavRetailer();
				favRetailer.Id = 1;
				favRetailer.Name = "Second Ascents";
				favRetailer.Specialty = "Climbing";

				// Act
				FavRetailerService favRetailerService = new FavRetailerService(context);

				await favRetailerService.CreateFavRetailer(favRetailer);

				FavRetailer favRetailersFromDb = await context.FavRetailers
											.FirstOrDefaultAsync(fl => fl.Name == favRetailer.Name);

				// Assert
				Assert.Equal(favRetailersFromDb, favRetailer);
			};
		}

		/// <summary>
		/// Tests whether can get favorite retailer by ID from DB
		/// </summary>
		[Theory]
		[InlineData(1, 4, 4, true)]
		[InlineData(2, 7, 5, false)]
		public async void GetFavRetailer_CanGetFavRetailerById(int numForFavRetailerId, int numToTest, int numForUserId, bool expectedBool)
		{
			DbContextOptions<RimrockDBContext> options = new DbContextOptionsBuilder<RimrockDBContext>().UseInMemoryDatabase("CanGetFavRetailerById").Options;

			using (RimrockDBContext context = new RimrockDBContext(options))
			{
				// Arrange
				FavRetailer newFavRetailer = new FavRetailer();
				newFavRetailer.Id = numForFavRetailerId;
				newFavRetailer.UserId = numForUserId;
				newFavRetailer.RegionId = 2;
				newFavRetailer.Name = "Grand Teton";
				newFavRetailer.Specialty = "Mountaineering";

				FavRetailerService favRetailerService = new FavRetailerService(context);

				await context.FavRetailers.AddAsync(newFavRetailer);
				await context.SaveChangesAsync();

				// Act
				List<FavRetailer> favRetailerListFromDb = await favRetailerService.GetFavRetailers(newFavRetailer.UserId);

				// Boolean test (needed for Theory-type unit test)
				bool actualBool = false;
				if (numToTest == favRetailerListFromDb[0].UserId)
				{
					actualBool = true;
				}

				// Assert
				Assert.Equal(actualBool, expectedBool);
			};
		}


	}
}
