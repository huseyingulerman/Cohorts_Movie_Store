using Cohorts_Movie_Store.Business.Services.Purchased;
using Cohorts_Movie_Store.Core.Utilities.Response;
using Cohorts_Movie_Store.Dtos.Purchased;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cohorts_Movie_Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasedController : ControllerBase
    {
        private readonly IPurchasedService _purchasedService;
        public PurchasedController(IPurchasedService purchasedService)
        {
            _purchasedService = purchasedService;
        }
        [HttpGet]
        public async Task<ApiResponse<List<PurchasedResponse>>> GetAllByUserId()
        {
            var userid = (User.Identity as ClaimsIdentity).FindFirst("Id")?.Value;
            var id = Convert.ToInt32(userid);
            var response = await _purchasedService.GetAllWithParameters(x => x.IsActive==true, x => x.CustomerId==id);
            return response;
        }
        [HttpPost]
        public async Task<ApiResponse<bool>> Create([FromBody] PurchasedRequest request)
        {
            var userid = (User.Identity as ClaimsIdentity).FindFirst("Id")?.Value;
            var id = Convert.ToInt32(userid);
            request.CustomerId = id;
            var response = await _purchasedService.Add(request);
            return response;
        }
    }
}
