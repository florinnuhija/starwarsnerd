using Microsoft.AspNetCore.Mvc;
using StarWarsNerdApi.Services;

namespace StarWarsNerdApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StarshipsController : ControllerBase
    {
        private readonly IStarWarsService _starWarsService;

        public StarshipsController(IStarWarsService starWarsService) => _starWarsService = starWarsService;

        [HttpGet]
        public async Task<IActionResult> GetStarships()
        {
            var starships = await _starWarsService.GetStarshipsAsync();
            return Ok(starships);
        }
    }
}
