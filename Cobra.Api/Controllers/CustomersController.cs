using Cobra.Api.DTOs;
using Cobra.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cobra.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        [HttpGet("productId")]
        public async Task<ActionResult<CustomerResponse>> GetCustomer(string productId)
        {
            return await _customerService.GetCustomer(productId);
        }
    }
}
