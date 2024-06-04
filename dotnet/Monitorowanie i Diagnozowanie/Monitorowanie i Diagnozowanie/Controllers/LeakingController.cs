using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monitorowanie_i_Diagnozowanie.Services;

namespace Monitorowanie_i_Diagnozowanie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeakingController(MyCacheService cacheService) : ControllerBase
    {
        [HttpGet]
        public IActionResult AddDevice()
        {
            var device = new Device(Guid.NewGuid(), new string('x', 10 * 1024), "Kind");

            cacheService.AddDevice(device);
            return Ok();
        }
    }
}
