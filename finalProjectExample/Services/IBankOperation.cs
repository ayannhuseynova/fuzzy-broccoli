using System;
namespace finalProjectExample.Services
{
    public interface IBankOperation
    {
        void DisplayBalance(string CustomerId);
        void DisplayBalance(int AccountBalance);
        void ShowAccountStatement(int AccountNumber);
        void ShowAllDetails();
    }
}

