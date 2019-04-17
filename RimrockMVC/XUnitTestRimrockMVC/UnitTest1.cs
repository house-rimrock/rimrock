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
    }
}
