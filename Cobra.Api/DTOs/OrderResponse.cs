using Cobra.Domain.Domain;

namespace Cobra.Api.DTOs
{
    public class OrderResponse
    {
        public string MethodPurchase { get; set; }
        public IEnumerable<OrderDetailsResponse> OrderDetails { get; set; }
    }
}
