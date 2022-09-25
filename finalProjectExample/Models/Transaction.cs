using System;
using finalProjectExample.Enum;

namespace finalProjectExample.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public TransactionType TransactionType { get; set; }
        public int AmountTransfer { get; set; }
        public DateTime TransferTime { get; set; }
        public decimal Balance { get; set; }
    }
}

