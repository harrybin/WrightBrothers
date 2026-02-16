using WrightBrothersApi.Controllers;
using WrightBrothersApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WrightBrothersApi.Tests.Controllers
{
    public class PlanesControllerTests
    {
        private readonly ILogger<PlanesController> _logger;
        private readonly PlanesController _planesController;

        public PlanesControllerTests()
        {
            _logger = Substitute.For<ILogger<PlanesController>>();
            _planesController = new PlanesController(_logger);
            
            // Reset planes data before each test
            var initialPlanes = new List<Plane>
            {
                new Plane
                {
                    Id = 1,
                    Name = "Wright Flyer",
                    Year = 1903,
                    Description = "The first powered aircraft.",
                    RangeInKm = 12
                },
                new Plane
                {
                    Id = 2,
                    Name = "Wright Flyer II",
                    Year = 1904,
                    Description = "Original Flyer with better performance.",
                    RangeInKm = 24
                },
                new Plane
                {
                    Id = 3,
                    Name = "Wright Model A",
                    Year = 1908,
                    Description = "The first commercial airplane.",
                    RangeInKm = 40
                }
            };
            _planesController.SetupPlanesData(initialPlanes);
        }

        [Fact]
        public void GetAll_ReturnsListOfPlanes()
        {
            // Act
            var result = _planesController.GetAll();

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedPlanes = (List<Plane>)okObjectResult.Value!;
            returnedPlanes.Should().NotBeEmpty();
        }

        [Fact]
        public void Put_UpdatesExistingPlane_ReturnsOk()
        {
            // Arrange
            var updatedPlane = new Plane
            {
                Id = 1,
                Name = "Updated Wright Flyer",
                Year = 1903,
                Description = "Updated description.",
                RangeInKm = 15
            };

            // Act
            var result = _planesController.Put(1, updatedPlane);

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedPlane = (Plane)okObjectResult.Value!;
            returnedPlane.Name.Should().Be("Updated Wright Flyer");
            returnedPlane.RangeInKm.Should().Be(15);
        }

        [Fact]
        public void Put_WithNonExistentId_ReturnsNotFound()
        {
            // Arrange
            var plane = new Plane
            {
                Id = 999,
                Name = "Non-existent Plane",
                Year = 2000,
                Description = "Does not exist.",
                RangeInKm = 100
            };

            // Act
            var result = _planesController.Put(999, plane);

            // Assert
            result.Result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public void Put_WithNullPlane_ReturnsBadRequest()
        {
            // Act
            var result = _planesController.Put(1, null!);

            // Assert
            result.Result.Should().BeOfType<BadRequestResult>();
        }

        [Fact]
        public void Put_WithMismatchedId_ReturnsBadRequest()
        {
            // Arrange
            var plane = new Plane
            {
                Id = 2,
                Name = "Updated Plane",
                Year = 1904,
                Description = "Updated description.",
                RangeInKm = 20
            };

            // Act
            var result = _planesController.Put(1, plane);

            // Assert
            var badRequestResult = result.Result.Should().BeOfType<BadRequestObjectResult>().Subject;
            badRequestResult.Value.Should().Be("Plane ID in request body does not match the ID in the URL.");
        }

        [Fact]
        public void Delete_WithValidId_ReturnsNoContent()
        {
            // Act
            var result = _planesController.Delete(1);

            // Assert
            result.Should().BeOfType<NoContentResult>();
        }

        [Fact]
        public void Delete_WithNonExistentId_ReturnsNotFound()
        {
            // Act
            var result = _planesController.Delete(999);

            // Assert
            result.Should().BeOfType<NotFoundResult>();
        }

    }
}