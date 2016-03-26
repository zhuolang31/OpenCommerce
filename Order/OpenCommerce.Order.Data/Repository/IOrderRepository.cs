using OpenCommerce.Order.Data.Infrastructure;
using OpenCommerce.Order.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCommerce.Order.Data.Repository
{
    interface IOrderRepository : IRepository<BizOrder>
    {
    }
}
