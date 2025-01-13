using AuthAPI.Models.Dtos;
using AuthAPI.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth auth;

        public AuthController(IAuth auth)
        {
            this.auth = auth;
        }

        [HttpPost("Login")]
        public async Task<ActionResult> LoginPost(LoginRequestDto loginRequest)
        {
            
            return Ok();
        }

        [HttpPost("Register")]
        public async Task<ActionResult> RegisterPost(RegisterRequestDto registerRequestDto)
        {
            return Ok();
        }
    }
}
