using Deportes.Models;
using Deportes.Pattertn.ChainofResponsability;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Deportes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeightliftingController : ControllerBase
    {
        
        [HttpPost("calculate")]
        public ActionResult<WeightliftingScoreResponse> Calculate([FromBody] WeightliftingScoreRequest request)
        {
            try
            {
                var r = new WeightliftingScoreResponse();
                AlterofiliaChain chain = new(); 
                chain.Handle(request,r );
                return Ok(r);

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
