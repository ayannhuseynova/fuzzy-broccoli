using System;
namespace finalProjectExample.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public string TransactionName { get; set; }
        public decimal AmountTransfer { get; set; }
        public DateTime TransferTime { get; set; }
        public decimal Balance { get; set; }
    }
}

