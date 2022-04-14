using EdizGoldeli_Lab4_WebApi1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EdizGoldeli_Lab4_WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<AppMessage> Get()
        {
            List<AppMessage> messages = new List<AppMessage>();
            messages.Add(new AppMessage() { Message = "Hello World! ." });
            messages.Add(new AppMessage() { Message = "Hello Galaxy! ." });
            return messages;

        }
    }
}
