using System;
using System.Collections.Generic;
using finalProjectExample.Enum;
using finalProjectExample.Models;

namespace finalProjectExample.Data
{
    public class FeedDatabase : CollectionStorageBase
    {
        Random random = new Random();

        public FeedDatabase()
        {
            CustomerList.Add(new Customer
            {
                CustomerId = $"{random.Next(0, 1000)}",
                CustomerName = "Ayasha",
                Accounts = new List<Account>()
                {
                    new Account()
                    {
                        AccountTyoe = AccountType.Saving,
                        AccountNumber = random.Next(1000000000, 999999999),
                        CurrentBalance = 500000,
                        WithdrawalLimitPerHour = 100000,
                        LastTransactionTime = DateTime.Now,
                        NumberOfTransactionPerHour = 2,
                        TransacionList = new List<Transaction>()
                        {
                            new Transaction()
                            {
                                TransactionId = new Guid(),
                                TransactionType = TransactionType.Debit,
                                AmountTransfer = random.Next(1, ConstValueDatas.WithdrawalLimitPerHour),
                                TransferTime = DateTime.Now,
                                Balance = 20000
                            },
                            new Transaction()
                            {
                                TransactionId = new Guid(),
                                TransactionType = TransactionType.Credit,
                                AmountTransfer = random.Next(1, ConstValueDatas.WithdrawalLimitPerHour),
                                TransferTime = DateTime.Now,
                                Balance = 27000
                            }
                        }
                    },
                    new Account()
                    {
                        AccountTyoe = AccountType.Saving,
                        AccountNumber = random.Next(1000000000, 999999999),
                        CurrentBalance = 5450000,
                        WithdrawalLimitPerHour = 12000,
                        LastTransactionTime = DateTime.Now,
                        NumberOfTransactionPerHour = ConstValueDatas.NumberOfTransactionPerHour,
                    },
                }
            }) ;
            CustomerList.Add(new Customer
            {
                CustomerId = $"{random.Next(0, 1000)}",
                CustomerName = "Lumbusha",
                Accounts = new List<Account>()
                {
                    new Account()
                    {
                        AccountTyoe = AccountType.Saving,
                        AccountNumber = random.Next(1000000000, 999999999),
                        CurrentBalance = 50045600,
                        WithdrawalLimitPerHour = 100000,
                        LastTransactionTime = DateTime.Now,
                        NumberOfTransactionPerHour = 1,
                        TransacionList = new List<Transaction>()
                        {
                            new Transaction()
                            {
                                TransactionId = new Guid(),
                                TransactionType = TransactionType.Debit,
                                AmountTransfer = random.Next(1, ConstValueDatas.WithdrawalLimitPerHour),
                                TransferTime = DateTime.Now,
                                Balance = 30000
                            }
                        }
                    },
                    new Account()
                    {
                        AccountTyoe = AccountType.Saving,
                        AccountNumber = random.Next(1000000000, 999999999),
                        CurrentBalance = 54546900,
                        WithdrawalLimitPerHour = 15000,
                        LastTransactionTime = DateTime.Now,
                        NumberOfTransactionPerHour = ConstValueDatas.NumberOfTransactionPerHour,
                    },
                }
            });
            CustomerList.Add(new Customer
            {
                CustomerId = $"{random.Next(0, 1000)}",
                CustomerName = "Tate",
                Accounts = new List<Account>()
                {
                    new Account()
                    {
                        AccountTyoe = AccountType.Saving,
                        AccountNumber = random.Next(1000000000, 999999999),
                        CurrentBalance = 50045660,
                        WithdrawalLimitPerHour = 10100,
                        LastTransactionTime = DateTime.Now,
                        NumberOfTransactionPerHour = 3,
                        TransacionList = new List<Transaction>()
                        {
                            new Transaction()
                            {
                                TransactionId = new Guid(),
                                TransactionType = TransactionType.Credit,
                                AmountTransfer = random.Next(1, ConstValueDatas.WithdrawalLimitPerHour),
                                TransferTime = DateTime.Now,
                                Balance = 190000
                            },
                            new Transaction()
                            {
                                TransactionId = new Guid(),
                                TransactionType = TransactionType.Debit,
                                AmountTransfer = random.Next(1, ConstValueDatas.WithdrawalLimitPerHour),
                                TransferTime = DateTime.Now,
                                Balance = 23000
                            }
                        }
                    }
                }
            });
            CustomerList.Add(new Customer
            {
                CustomerId = $"{random.Next(0, 1000)}",
                CustomerName = "Kyla"
            });
        }
    }
}

