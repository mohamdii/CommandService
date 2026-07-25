 
namespace CommandService.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/c/Platforms")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {   
        public PlatformsController()
        {
        }

        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound test of from Platforms Controller");
        }
    }
}
