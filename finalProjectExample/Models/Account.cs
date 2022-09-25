using System;
using System.Collections.Generic;

namespace finalProjectExample.Models
{
    public class Account
    {
        public Enum AccountTyoe { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public int WithdrawalLimitPerHour { get; set; }
        public DateTime LastTransactionTime { get; set; }
        public int NumberOfTransactionPerHour { get; set; }
        public List<Guid> TransactionIds { get; set; }
        public List<Transaction> TransacionList { get; set; }
    }
}