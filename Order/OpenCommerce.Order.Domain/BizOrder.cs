using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCommerce.Order.Domain
{
    public class BizOrder
    {
        public long OrderId { get; set; }

        public decimal Amount { get; set; }

        public OrderStatus Status { get; set; }

        List<OrderItem> OrderItems { get; set; }

        public void Submit()
        {

        }

        public void Cancel()
        {

        }
    }
}
