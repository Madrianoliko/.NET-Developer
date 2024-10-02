using EventScheduler.Controllers.Base;
using EventScheduler.Data;
using EventScheduler.Model.Auth;
using EventScheduler.Services.Model.Event;
using EventScheduler.Services.Model.External.Google;
using EventScheduler.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EventScheduler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WebHooksController : BaseController
    {
        private readonly IEventDataService _eventDataService;
        public WebHooksController(IEventDataService eventDataService)
        {
            _eventDataService = eventDataService;
        }

        [HttpPost]
        [Route("googleclanedar")]
        public IActionResult AddEvent([FromBody] GoogleEvent gEvent)
        {
            //Create event from googlecalendar webhook
          
            return Ok();
        }
       
    }
}
