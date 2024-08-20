using ApiWithStrategyPattern.Request;
using ApiWithStrategyPattern.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithStrategyPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpPost("send")]
        public async Task<IActionResult> Send([FromBody] NotificationRequest request)
        {
            var service = new NotificationService();

            service.Notify(request.Channel,request.Menssage,request.Destination);

            return Ok("teste");
        }
    }
}
