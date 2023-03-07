namespace Cobra.Api.DTOs
{
    public class CustomerResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }
        public int Age { get; set; }

        public OrderResponse Order { get; set; }

    }
}
