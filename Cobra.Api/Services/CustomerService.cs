using AutoMapper;
using Cobra.Api.Data;
using Cobra.Api.DTOs;
using Cobra.Domain;
using Cobra.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cobra.Api.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CobraChallengeDataContext _context;
        private readonly IMapper _mapper;
        public CustomerService(CobraChallengeDataContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CustomerResponse> GetCustomer(string productId)
        {
            if (!_context.Products.Any(x => x.ProductId == productId))
                throw new Exception("Invalid Product Id");

            var result = await _context.OrderDetails
                .Include(x => x.Product)
                .Include(x=>x.Order)
                .ThenInclude(x=>x.Person)
                .ThenInclude(x => x.Customer)
                .FirstOrDefaultAsync(x => x.Product.ProductId == productId);


            if (result == null)
                return null;

            return new CustomerResponse 
            { 
                Age = result.Order.Person.Customer.Age,
                FirstName = result.Order.Person.FirstName,
                LastName = result.Order.Person.LastName,
                FullName = result.Order.Person.FirstName + ' ' + result.Order.Person.LastName,
                Order = new OrderResponse
                {
                    MethodPurchase = result.Order.MethodPurchase,
                    OrderDetails = new List<OrderDetailsResponse>
                    {
                        new OrderDetailsResponse
                        {
                            OrderNumber = result.OrderNumber,
                            ProductOrigin = result.ProductOrigin,
                            Product = new ProductResponse
                            {
                                ProducId = result.Product.ProductId,
                                Name = result.Product.Name,
                                Description = result.Product.Description
                            }
                        }   
                    }
                }

            };
        }
    }
}
