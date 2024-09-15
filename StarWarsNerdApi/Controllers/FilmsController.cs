using Microsoft.AspNetCore.Mvc;
using StarWarsNerdApi.Services;

namespace StarWarsNerdApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : ControllerBase
    {
        private readonly IStarWarsService _starWarsService;

        public FilmsController(IStarWarsService starWarsService) => _starWarsService = starWarsService;

        [HttpGet]
        public async Task<IActionResult> GetFilms()
        {
            var films = await _starWarsService.GetFilmsAsync();
            return Ok(films);
        }
    }
}
