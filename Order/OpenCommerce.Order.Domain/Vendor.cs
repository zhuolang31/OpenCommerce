using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCommerce.Order.Domain
{
    public class Vendor
    {
        public long VendorId { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }
    }
}
