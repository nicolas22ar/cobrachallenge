using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobra.Domain.Domain
{
    public class OrderDetails : Entity
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public int OrderNumber { get; set; }
        public Guid ProductId { get; set; }
        public string ProductOrigin { get; set; }
        public virtual Product Product { get; set; }
    }
}
