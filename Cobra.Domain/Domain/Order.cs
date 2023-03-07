using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra.Domain.Domain
{
    public class Order : Entity
    {
        public Guid PersonId { get; set; }
        public string MethodPurchase { get; set; }
        public virtual Person Person { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
