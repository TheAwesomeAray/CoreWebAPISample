using Jets.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace WebAPISample.Controllers
{
    [Route("api/jets")]
    [ApiController]
    public class JetsController : ControllerBase
    {
        private IJetsDataAccess _jetsDA;

        public JetsController(IJetsDataAccess jetsDA)
        {
            _jetsDA = jetsDA;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_jetsDA.GetLookUps());
        }

        [HttpGet("{id}")]
        public IActionResult GetLookUp(int id)
        {
            var lookUp = _jetsDA.GetLookUp(id);
            if (lookUp == null)
                return NotFound();

            return Ok(lookUp);
        }
    }
}
