﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCommerce.Order.Domain
{
    public class User
    {
        public long UserId { get; set; }

        public string UserName { get; set; }

        public string UserDisplayName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public List<BizOrder> Orders { get; set; }
    }
}
