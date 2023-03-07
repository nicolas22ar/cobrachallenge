using Cobra.Domain.Domain;

namespace Cobra.Domain
{
    public class Customer : Entity
    {
        public int Age { get; set; }
        public string Occupation { get; set; }
        public string MartialStatus { get; set; }
        public Guid PersonId { get; set; }
        
    }
}