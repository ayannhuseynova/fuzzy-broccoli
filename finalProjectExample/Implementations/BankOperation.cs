using System;
using System.Collections.Generic;
using System.Linq;
using finalProjectExample.Data;
using finalProjectExample.Models;
using finalProjectExample.Services;

namespace finalProjectExample.Implementations
{
    public class BankOperation : CollectionStorageBase, IBankOperation
    {
        public void DisplayBalance(string CustomerId)
        {
            Customer cust = CustomerList.FirstOrDefault(x => x.CustomerId == CustomerId);

            if (cust != null)
            {
                if (cust.Accounts.Count != 0)
                {
                    foreach (var item in cust.Accounts)
                    {
                        Console.WriteLine(item.CurrentBalance);
                    }
                }
                else
                {
                    Console.WriteLine("No account found. Create a new one");
                    return;
                }
            }
            else
            {
                Console.WriteLine("This customer not found");
                return;
            }


        }

        public void DisplayBalance(int AccountNumber)
        {
            Account account = CustomerList.Select(x => x.Accounts.FirstOrDefault(c => c.AccountNumber == AccountNumber))
                .FirstOrDefault();

            if (account != null)
            {
                Console.WriteLine($"Current Available Balance for this {AccountNumber} account number: {account.CurrentBalance}$");
            }
            else
            {
                Console.WriteLine("No account under this account number");
            }
        }

        public void ShowAccountStatement(int AccountNumber)
        {
            Account account = CustomerList.Select(x => x.Accounts.FirstOrDefault(x => x.AccountNumber == AccountNumber)).FirstOrDefault();
            account.TransacionList.ForEach(x => Console.WriteLine($"{x.TransferTime}, Amount: {x.AmountTransfer}, Balance = {x.Balance}"));
        }

        public void ShowAllDetails()
        {
            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine($"Customer Id: {customer.CustomerId}, Customer Name: {customer.CustomerName}");
                customer.Accounts.ForEach(x => Console.WriteLine($"Account Type: {x.AccountTyoe}, Account Number: {x.AccountNumber}" +
                    $"Account Balance: {x.CurrentBalance}"));
            }
        }
    }
}

