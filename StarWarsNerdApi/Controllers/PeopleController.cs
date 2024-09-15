using Microsoft.AspNetCore.Mvc;
using StarWarsNerdApi.Services;

namespace StarWarsNerdApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IStarWarsService _starWarsService;

        public PeopleController(IStarWarsService starWarsService) => _starWarsService = starWarsService;

        [HttpGet]
        public async Task<IActionResult> GetPeople()
        {
            var people = await _starWarsService.GetPeopleAsync();
            return Ok(people);
        }
    }
}
