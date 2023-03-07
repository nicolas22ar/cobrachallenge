using Cobra.Api.DTOs;

namespace Cobra.Api.Services
{
    public interface ICustomerService
    {
        Task<CustomerResponse> GetCustomer(string productId);
    }
}
