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
        public void GetSorted_ByYearAscending_ReturnsPlanesInYearOrder()
        {
            // Act
            var result = _planesController.GetSorted("year");

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedPlanes = (List<Plane>)okObjectResult.Value!;
            returnedPlanes.Select(plane => plane.Year).Should().BeInAscendingOrder();
        }

        [Fact]
        public void GetSorted_ByRangeDescending_ReturnsPlanesInDescendingRangeOrder()
        {
            // Act
            var result = _planesController.GetSorted("rangeInKm", descending: true);

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedPlanes = (List<Plane>)okObjectResult.Value!;
            returnedPlanes.Select(plane => plane.RangeInKm).Should().BeInDescendingOrder();
        }

        [Fact]
        public void GetSorted_WithUnsupportedProperty_ReturnsBadRequest()
        {
            // Act
            var result = _planesController.GetSorted("unsupported");

            // Assert
            result.Result.Should().BeOfType<BadRequestObjectResult>();
        }

    }
}