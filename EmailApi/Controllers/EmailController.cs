using Microsoft.AspNetCore.Mvc;

namespace EmailApi.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {


        [HttpPost("send")]

        public IActionResult SendEmail([FromBody] EmailRequest emailRequest)
        {
            return Ok("E-mail byl úspěšně odeslán.");
        }
    }
}

public class EmailRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}
