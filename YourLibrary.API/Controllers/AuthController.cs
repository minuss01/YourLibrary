using Microsoft.AspNetCore.Mvc;

namespace YourLibrary.API.Controllers
{
    public class AuthController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
