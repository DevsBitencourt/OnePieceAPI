using Microsoft.AspNetCore.Mvc;

namespace OnePieceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PirateTripulationController : ControllerBase
    {
        [HttpGet(Name = "GetPirate")]
        public async Task<IActionResult> Get()
        {
            var pirate = new Models.PirateTripulation();

            var triplulation = pirate.GetCharacters();
            
            return Ok(await triplulation);
        }
    }
}
