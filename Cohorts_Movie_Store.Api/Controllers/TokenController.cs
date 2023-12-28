using Cohorts_Movie_Store.Core.Utilities.Response;
using Cohorts_Movie_Store.Dtos.Token;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cohorts_Movie_Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService service;
        public TokenController(ITokenService service)
        {
            this.service = service;
        }

        [HttpPost("Login")]
        public async Task<ApiResponse<TokenResponse>> Post([FromBody] TokenRequest request)
        {
            var response = await service.Login(request);
            return response;
        }
    }
}
