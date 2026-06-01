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
        public void GetById_LogsInformationMessage()
        {
            // Act
            _planesController.GetById(1);

            // Assert
            _logger.Received().Log(
                LogLevel.Information,
                Arg.Any<EventId>(),
                Arg.Is<object>(state => state.ToString()!.Contains("GET ✈✈✈ 1 ✈✈✈")),
                Arg.Any<Exception>(),
                Arg.Any<Func<object, Exception?, string>>());
        }

        [Fact]
        public void GetById_NotFound_LogsWarningMessage()
        {
            // Act
            _planesController.GetById(999);

            // Assert
            _logger.Received().Log(
                LogLevel.Warning,
                Arg.Any<EventId>(),
                Arg.Is<object>(state => state.ToString()!.Contains("NOT FOUND")),
                Arg.Any<Exception>(),
                Arg.Any<Func<object, Exception?, string>>());
        }

    }
}