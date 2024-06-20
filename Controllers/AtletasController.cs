using Deportes.Services;
using Microsoft.AspNetCore.Mvc;

namespace Deportes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtletasController:ControllerBase
    {


        [HttpGet("atletas")]
        public IActionResult ReturnAtletes()
        {
            ServiceAtletas sa = new();
            return Ok(sa.Atletas());
        }
    }
}
