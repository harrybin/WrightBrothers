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

        [Fact]
        public void DeleteMultiple_RemovesPlanesWithMatchingIds()
        {
            var originalPlanes = ((List<Plane>)((OkObjectResult)_planesController.GetAll().Result!).Value!).ToList();
            var planes = new List<Plane>
            {
                new() { Id = 901, Name = "Plane 901" },
                new() { Id = 902, Name = "Plane 902" },
                new() { Id = 903, Name = "Plane 903" }
            };

            try
            {
                _planesController.SetupPlanesData(planes);

                var result = _planesController.DeleteMultiple([901, 903]);

                var okResult = result.Should().BeOfType<OkObjectResult>().Subject;
                okResult.Value.Should().BeEquivalentTo(new { DeletedCount = 2 });
                var remainingPlanes = (List<Plane>)((OkObjectResult)_planesController.GetAll().Result!).Value!;
                remainingPlanes.Select(plane => plane.Id).Should().Equal(902);
            }
            finally
            {
                _planesController.SetupPlanesData(originalPlanes);
            }
        }

        [Theory]
        [MemberData(nameof(InvalidPlaneIds))]
        public void DeleteMultiple_RejectsEmptyOrInvalidIds(List<int>? planeIds)
        {
            var result = _planesController.DeleteMultiple(planeIds!);

            result.Should().BeOfType<BadRequestResult>();
        }

        public static IEnumerable<object?[]> InvalidPlaneIds =>
        [
            [null],
            [new List<int>()],
            [new List<int> { 1, 0 }]
        ];
    }
}