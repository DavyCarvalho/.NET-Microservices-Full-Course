using Microsoft.AspNetCore.Mvc;
using System;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        public IActionResult TestInboundConnection()
        {
            Console.WriteLine("--> POST # Command Service");

            return Ok("Inbound test of from Platforms Controller");
        }
    }
}
