using Cobra.Domain.Domain;

namespace Cobra.Api.DTOs
{
    public class OrderDetailsResponse
    {
        public int OrderNumber { get; set; }
        public string ProductOrigin { get; set; }
        public virtual ProductResponse Product { get; set; }
    }
}
