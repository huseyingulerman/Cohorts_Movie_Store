using Cohorts_Movie_Store.Business.Services.Customer;
using Cohorts_Movie_Store.Core.Utilities.Response;
using Cohorts_Movie_Store.Dtos.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cohorts_Movie_Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost]
        public async Task<ApiResponse<bool>> Create([FromBody] CustomerRequest request)
        {
            var response = await _customerService.Add(request);
            return response;
        }
        [HttpDelete("{id}")]
        public ApiResponse<bool> Delete(int id)
        {
            var response = _customerService.Remove(id);
            return response;
        }
    }
}
