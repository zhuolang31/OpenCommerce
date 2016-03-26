using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCommerce.Order.AppService
{
    interface IOrderAppService
    {
        /// <summary>
        /// 提交订单
        /// </summary>
       void SubmitOrder();

        /// <summary>
        /// 取消订单
        /// </summary>
       void CancelOrder();
    }
}
