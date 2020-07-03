namespace StarChart.Controllers
{
    using Data;
    using Microsoft.AspNetCore.Mvc;

    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext context) =>
            _context = context;
    }
}
