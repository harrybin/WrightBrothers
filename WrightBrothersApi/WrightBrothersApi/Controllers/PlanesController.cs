using Microsoft.AspNetCore.Mvc;
using WrightBrothersApi.Models;

namespace WrightBrothersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanesController : ControllerBase
    {
        private readonly ILogger<PlanesController> _logger;

        public PlanesController(ILogger<PlanesController> logger)
        {
            _logger = logger;
        }

    private static readonly List<Plane> Planes = new List<Plane>
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

        [HttpGet]
        public ActionResult<List<Plane>> GetAll()
        {
            _logger.LogInformation("GET all ✈✈✈ NO PARAMS ✈✈✈");

            return Ok(Planes);
        }

        [HttpGet("{id}")]
        public ActionResult<Plane> GetById(int id)
        {
            _logger.LogInformation("GET ✈✈✈ {id} ✈✈✈", id);

            var plane = Planes.Find(p => p.Id == id);

            if (plane == null)
            {
                _logger.LogWarning("GET ✈✈✈ {id} NOT FOUND ✈✈✈", id);
                return NotFound();
            }

            return Ok(plane);
        }

        [HttpPost]
        public ActionResult<Plane> Post(Plane plane)
        {
            if(plane == null)
            {
                _logger.LogWarning("POST ✈✈✈ INVALID PAYLOAD ✈✈✈");
                return BadRequest();
            }

            Planes.Add(plane);
            _logger.LogInformation("POST ✈✈✈ {id} ✈✈✈", plane.Id);

            return CreatedAtAction(nameof(GetById), new { id = plane.Id }, plane);
        }

        [HttpPost("setup")]
        public ActionResult SetupPlanesData(List<Plane> planes)
        {
            if (planes == null)
            {
                _logger.LogWarning("POST setup ✈✈✈ INVALID PAYLOAD ✈✈✈");
                return BadRequest();
            }

            Planes.Clear();
            Planes.AddRange(planes);
            _logger.LogInformation("POST setup ✈✈✈ {count} ✈✈✈", planes.Count);

            return Ok();
        }
        
    }
}
