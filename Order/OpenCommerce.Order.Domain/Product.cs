using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCommerce.Order.Domain
{
    public class Product
    {
        public long ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public Vendor Vendor { get; set; }
    }
}
