using IdentityWebApi.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> TestEndpoint()
        {
            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        [Authorize(Roles = User_Roles.Admin)]
        public async Task<IActionResult> TestAdmin()
        {
            return Ok(new { message = "Hello you are an admin" });
        }
    }
}
