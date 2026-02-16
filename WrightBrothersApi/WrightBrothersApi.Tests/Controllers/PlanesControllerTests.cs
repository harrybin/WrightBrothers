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
        public void GetById_WithValidId_ReturnsPlane()
        {
            // Arrange
            var testPlanes = new List<Plane>
            {
                new Plane { Id = 1, Name = "Test Plane", Year = 2020, Description = "Test", RangeInKm = 100 }
            };
            _planesController.SetupPlanesData(testPlanes);

            // Act
            var result = _planesController.GetById(1);

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedPlane = (Plane)okObjectResult.Value!;
            returnedPlane.Id.Should().Be(1);
            returnedPlane.Name.Should().Be("Test Plane");
        }

        [Fact]
        public void GetById_WithInvalidId_ReturnsNotFound()
        {
            // Act
            var result = _planesController.GetById(999);

            // Assert
            result.Result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public void Post_WithValidPlane_ReturnsCreatedAtAction()
        {
            // Arrange
            var newPlane = new Plane { Id = 10, Name = "New Plane", Year = 2024, Description = "New", RangeInKm = 200 };

            // Act
            var result = _planesController.Post(newPlane);

            // Assert
            var createdAtActionResult = (CreatedAtActionResult)result.Result!;
            createdAtActionResult.ActionName.Should().Be(nameof(PlanesController.GetById));
            var returnedPlane = (Plane)createdAtActionResult.Value!;
            returnedPlane.Id.Should().Be(10);
            returnedPlane.Name.Should().Be("New Plane");
        }

        [Fact]
        public void Post_WithNullPlane_ReturnsBadRequest()
        {
            // Act
            var result = _planesController.Post(null!);

            // Assert
            result.Result.Should().BeOfType<BadRequestResult>();
        }

        [Fact]
        public void Put_WithValidIdAndPlane_ReturnsOk()
        {
            // Arrange
            var testPlanes = new List<Plane>
            {
                new Plane { Id = 1, Name = "Original Plane", Year = 2020, Description = "Original", RangeInKm = 100 }
            };
            _planesController.SetupPlanesData(testPlanes);

            var updatedPlane = new Plane { Id = 1, Name = "Updated Plane", Year = 2021, Description = "Updated", RangeInKm = 150 };

            // Act
            var result = _planesController.Put(1, updatedPlane);

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedPlane = (Plane)okObjectResult.Value!;
            returnedPlane.Id.Should().Be(1);
            returnedPlane.Name.Should().Be("Updated Plane");
            returnedPlane.Year.Should().Be(2021);
            returnedPlane.Description.Should().Be("Updated");
            returnedPlane.RangeInKm.Should().Be(150);
        }

        [Fact]
        public void Put_WithMismatchedId_ReturnsBadRequest()
        {
            // Arrange
            var plane = new Plane { Id = 2, Name = "Plane", Year = 2020, Description = "Test", RangeInKm = 100 };

            // Act
            var result = _planesController.Put(1, plane);

            // Assert
            var badRequestResult = (BadRequestObjectResult)result.Result!;
            badRequestResult.Value.Should().Be("ID mismatch");
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
        public void Put_WithNonExistentId_ReturnsNotFound()
        {
            // Arrange
            var plane = new Plane { Id = 999, Name = "Plane", Year = 2020, Description = "Test", RangeInKm = 100 };

            // Act
            var result = _planesController.Put(999, plane);

            // Assert
            result.Result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public void Delete_WithValidId_ReturnsNoContent()
        {
            // Arrange
            var testPlanes = new List<Plane>
            {
                new Plane { Id = 1, Name = "Test Plane", Year = 2020, Description = "Test", RangeInKm = 100 }
            };
            _planesController.SetupPlanesData(testPlanes);

            // Act
            var result = _planesController.Delete(1);

            // Assert
            result.Should().BeOfType<NoContentResult>();

            // Verify plane was removed
            var getResult = _planesController.GetById(1);
            getResult.Result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public void Delete_WithInvalidId_ReturnsNotFound()
        {
            // Act
            var result = _planesController.Delete(999);

            // Assert
            result.Should().BeOfType<NotFoundResult>();
        }

    }
}