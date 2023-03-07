using AutoMapper;
using Cobra.Api.DTOs;
using Cobra.Domain;
using Cobra.Domain.Domain;

namespace Cobra.Api.MappingProfile
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Customer, CustomerResponse>();
            CreateMap<Order, OrderResponse>();
            CreateMap<OrderDetails, OrderDetailsResponse>();
            CreateMap<Product, ProductResponse>();
        }
    }
}
