using System;
using System.Collections.Generic;

namespace finalProjectExample.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<Account> Accounts { get; set; }
    }
}

