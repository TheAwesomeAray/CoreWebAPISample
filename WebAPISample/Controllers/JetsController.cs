using Jets.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JetsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<LookUpDto> Get()
        {
            return new LookUpDto() { Id = 1, LookUpValue = "Test Lookup" };
        }
    }
}
