using RimrockMVC.Models;
using RimrockMVC.Models.APImodels;
using System;
using Xunit;

namespace XUnitTestRimrockMVC
{
    public class UnitTest1
    {
        /////////////////////////////////
        // Test getters and setters
        /////////////////////////////////

        // API MODELS

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

    }
}
