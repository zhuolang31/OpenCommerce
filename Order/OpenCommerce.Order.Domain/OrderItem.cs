using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCommerce.Order.Domain
{
   public  class OrderItem
    {
        public long OrderId { get; set; }

        public long OrderItemId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public BizOrder Order { get; set; }

        public Product Product { get; set; }

    }
}
