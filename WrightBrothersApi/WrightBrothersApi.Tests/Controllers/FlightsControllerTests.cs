using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WrightBrothersApi.Tests.Controllers
{
    public class FlightsControllerTests
    {
        private readonly ILogger<FlightsController> _logger;
        private readonly FlightsController _flightsController;

        public FlightsControllerTests()
        {
            _logger = Substitute.For<ILogger<FlightsController>>();
            _flightsController = new FlightsController(_logger);
        }

        [Fact]
        public void GetAll_ReturnsListOfFlights()
        {
            // Act
            var result = _flightsController.GetAll();

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedFlights = (List<Flight>)okObjectResult.Value!;
            returnedFlights.Should().NotBeEmpty();
            returnedFlights.Should().HaveCountGreaterThan(0);
        }

        [Fact]
        public void GetById_WithValidId_ReturnsFlight()
        {
            // Act
            var result = _flightsController.GetById(1);

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedFlight = (Flight)okObjectResult.Value!;
            returnedFlight.Id.Should().Be(1);
            returnedFlight.FlightNumber.Should().Be("WB001");
        }

        [Fact]
        public void GetById_WithInvalidId_ReturnsNotFound()
        {
            // Act
            var result = _flightsController.GetById(999);

            // Assert
            result.Result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public void Post_WithValidFlight_ReturnsCreatedAtAction()
        {
            // Arrange
            var newFlight = new Flight
            {
                Id = 100,
                FlightNumber = "WB100",
                Origin = "Test Origin",
                Destination = "Test Destination",
                DepartureTime = DateTime.Now.AddHours(2),
                ArrivalTime = DateTime.Now.AddHours(3),
                Status = FlightStatus.Scheduled,
                FuelRange = 200,
                FuelTankLeak = false,
                FlightLogSignature = "TEST-SIG",
                AerobaticSequenceSignature = "TEST-SEQ"
            };

            // Act
            var result = _flightsController.Post(newFlight);

            // Assert
            var createdAtActionResult = (CreatedAtActionResult)result.Result!;
            createdAtActionResult.ActionName.Should().Be(nameof(FlightsController.GetById));
            var returnedFlight = (Flight)createdAtActionResult.Value!;
            returnedFlight.Id.Should().Be(100);
            returnedFlight.FlightNumber.Should().Be("WB100");
        }

        [Fact]
        public void Put_WithValidIdAndFlight_ReturnsOk()
        {
            // Arrange
            var updatedFlight = new Flight
            {
                Id = 1,
                FlightNumber = "WB001-UPDATED",
                Origin = "Updated Origin",
                Destination = "Updated Destination",
                DepartureTime = new DateTime(2024, 1, 1, 10, 0, 0),
                ArrivalTime = new DateTime(2024, 1, 1, 12, 0, 0),
                Status = FlightStatus.Delayed,
                FuelRange = 150,
                FuelTankLeak = true,
                FlightLogSignature = "UPDATED-SIG",
                AerobaticSequenceSignature = "UPDATED-SEQ"
            };

            // Act
            var result = _flightsController.Put(1, updatedFlight);

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedFlight = (Flight)okObjectResult.Value!;
            returnedFlight.Id.Should().Be(1);
            returnedFlight.FlightNumber.Should().Be("WB001-UPDATED");
            returnedFlight.Origin.Should().Be("Updated Origin");
            returnedFlight.Destination.Should().Be("Updated Destination");
            returnedFlight.Status.Should().Be(FlightStatus.Delayed);
            returnedFlight.FuelRange.Should().Be(150);
            returnedFlight.FuelTankLeak.Should().BeTrue();
        }

        [Fact]
        public void Put_WithMismatchedId_ReturnsBadRequest()
        {
            // Arrange
            var flight = new Flight
            {
                Id = 2,
                FlightNumber = "WB002",
                Origin = "Test",
                Destination = "Test",
                DepartureTime = DateTime.Now,
                ArrivalTime = DateTime.Now.AddHours(1),
                Status = FlightStatus.Scheduled,
                FuelRange = 100,
                FuelTankLeak = false,
                FlightLogSignature = "TEST",
                AerobaticSequenceSignature = "TEST"
            };

            // Act
            var result = _flightsController.Put(1, flight);

            // Assert
            var badRequestResult = (BadRequestObjectResult)result.Result!;
            badRequestResult.Value.Should().Be("ID mismatch");
        }

        [Fact]
        public void Put_WithNullFlight_ReturnsBadRequest()
        {
            // Act
            var result = _flightsController.Put(1, null!);

            // Assert
            result.Result.Should().BeOfType<BadRequestResult>();
        }

        [Fact]
        public void Put_WithNonExistentId_ReturnsNotFound()
        {
            // Arrange
            var flight = new Flight
            {
                Id = 999,
                FlightNumber = "WB999",
                Origin = "Test",
                Destination = "Test",
                DepartureTime = DateTime.Now,
                ArrivalTime = DateTime.Now.AddHours(1),
                Status = FlightStatus.Scheduled,
                FuelRange = 100,
                FuelTankLeak = false,
                FlightLogSignature = "TEST",
                AerobaticSequenceSignature = "TEST"
            };

            // Act
            var result = _flightsController.Put(999, flight);

            // Assert
            result.Result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public void Delete_WithValidId_ReturnsNoContent()
        {
            // Act
            var result = _flightsController.Delete(1);

            // Assert
            result.Should().BeOfType<NoContentResult>();

            // Verify flight was removed
            var getResult = _flightsController.GetById(1);
            getResult.Result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public void Delete_WithInvalidId_ReturnsNotFound()
        {
            // Act
            var result = _flightsController.Delete(999);

            // Assert
            result.Should().BeOfType<NotFoundResult>();
        }
    }
}
