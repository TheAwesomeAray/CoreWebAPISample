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
        public JsonResult Get()
        {
            return new JsonResult(_jetsDA.GetLookUps());
        }

        [HttpGet("{id}")]
        public JsonResult GetLookUp(int id)
        {
            return new JsonResult(_jetsDA.GetLookUp(id));
        }
    }
}
