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

            // Reset flights data before each test
            var initialFlights = new List<Flight>
            {
                new Flight
                {
                    Id = 1,
                    FlightNumber = "WB001",
                    Origin = "Kitty Hawk, NC",
                    Destination = "Manteo, NC",
                    DepartureTime = new DateTime(1903, 12, 17, 10, 35, 0),
                    ArrivalTime = new DateTime(1903, 12, 17, 10, 35, 0).AddMinutes(12),
                    Status = FlightStatus.Scheduled,
                    FuelRange = 100,
                    FuelTankLeak = false,
                    FlightLogSignature = "171203-DEP-ARR-WB001",
                    AerobaticSequenceSignature = "L4B-H2C-R3A-S1D-T2E"
                },
                new Flight
                {
                    Id = 2,
                    FlightNumber = "WB002",
                    Origin = "Kitty Hawk, NC",
                    Destination = "Manteo, NC",
                    DepartureTime = new DateTime(1903, 12, 17, 10, 35, 0),
                    ArrivalTime = new DateTime(1903, 12, 17, 10, 35, 0).AddMinutes(12),
                    Status = FlightStatus.Scheduled,
                    FuelRange = 100,
                    FuelTankLeak = false,
                    FlightLogSignature = "171203-DEP-ARR-WB002",
                    AerobaticSequenceSignature = "L1A-H1B-R1C-T1E"
                },
                new Flight
                {
                    Id = 3,
                    FlightNumber = "WB003",
                    Origin = "Fort Myer, VA",
                    Destination = "Fort Myer, VA",
                    DepartureTime = new DateTime(1908, 9, 17, 10, 35, 0),
                    ArrivalTime = new DateTime(1908, 9, 17, 10, 35, 0).AddMinutes(12),
                    Status = FlightStatus.Scheduled,
                    FuelRange = 100,
                    FuelTankLeak = true,
                    FlightLogSignature = "170908-DEP-ARR-WB003",
                    AerobaticSequenceSignature = "L2A-H2B-R2C"
                }
            };
            _flightsController.SetupFlightsData(initialFlights);
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
        }

        [Fact]
        public void Put_UpdatesExistingFlight_ReturnsOk()
        {
            // Arrange
            var updatedFlight = new Flight
            {
                Id = 1,
                FlightNumber = "WB001-UPDATED",
                Origin = "Updated Origin",
                Destination = "Updated Destination",
                DepartureTime = new DateTime(1903, 12, 17, 10, 35, 0),
                ArrivalTime = new DateTime(1903, 12, 17, 10, 47, 0),
                Status = FlightStatus.Scheduled,
                FuelRange = 150,
                FuelTankLeak = false,
                FlightLogSignature = "UPDATED-SIGNATURE",
                AerobaticSequenceSignature = "UPDATED-AEROBATIC"
            };

            // Act
            var result = _flightsController.Put(1, updatedFlight);

            // Assert
            var okObjectResult = (OkObjectResult)result.Result!;
            var returnedFlight = (Flight)okObjectResult.Value!;
            returnedFlight.FlightNumber.Should().Be("WB001-UPDATED");
            returnedFlight.FuelRange.Should().Be(150);
        }

        [Fact]
        public void Put_WithNonExistentId_ReturnsNotFound()
        {
            // Arrange
            var flight = new Flight
            {
                Id = 999,
                FlightNumber = "WB999",
                Origin = "Unknown",
                Destination = "Unknown",
                DepartureTime = DateTime.Now,
                ArrivalTime = DateTime.Now.AddHours(1),
                Status = FlightStatus.Scheduled,
                FuelRange = 100,
                FuelTankLeak = false,
                FlightLogSignature = "UNKNOWN",
                AerobaticSequenceSignature = "UNKNOWN"
            };

            // Act
            var result = _flightsController.Put(999, flight);

            // Assert
            result.Result.Should().BeOfType<NotFoundResult>();
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
        public void Put_WithMismatchedId_ReturnsBadRequest()
        {
            // Arrange
            var flight = new Flight
            {
                Id = 2,
                FlightNumber = "WB002-UPDATED",
                Origin = "Updated Origin",
                Destination = "Updated Destination",
                DepartureTime = new DateTime(1903, 12, 17, 10, 35, 0),
                ArrivalTime = new DateTime(1903, 12, 17, 10, 47, 0),
                Status = FlightStatus.Scheduled,
                FuelRange = 150,
                FuelTankLeak = false,
                FlightLogSignature = "UPDATED",
                AerobaticSequenceSignature = "UPDATED"
            };

            // Act
            var result = _flightsController.Put(1, flight);

            // Assert
            var badRequestResult = result.Result.Should().BeOfType<BadRequestObjectResult>().Subject;
            badRequestResult.Value.Should().Be("Flight ID in request body does not match the ID in the URL.");
        }

        [Fact]
        public void Delete_WithValidId_ReturnsNoContent()
        {
            // Act
            var result = _flightsController.Delete(1);

            // Assert
            result.Should().BeOfType<NoContentResult>();
        }

        [Fact]
        public void Delete_WithNonExistentId_ReturnsNotFound()
        {
            // Act
            var result = _flightsController.Delete(999);

            // Assert
            result.Should().BeOfType<NotFoundResult>();
        }
    }
}
