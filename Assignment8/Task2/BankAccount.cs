using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class BankAccount
    {
        private readonly string _accountNumber;
        private readonly string _accountHolderName;
        public Currency Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolderName, Currency balance)
        {
            _accountHolderName = accountHolderName;
            _accountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(Currency depositCurrency)
        {
            Balance = new Currency(Balance.Amount + depositCurrency.Amount, depositCurrency.Code);
        }

        public void Withdraw(Currency withdrawCurrency)
        {
            Balance = new Currency(Balance.Amount - withdrawCurrency.Amount, withdrawCurrency.Code);
        }

        public string BalanceCheck()
        {
            return Balance.ToString();
        }

    }

    public struct Currency
    {
        public double Amount { get; set; }
        public string Code { get; set; }
        public Currency(double amount, string code) 
        {
            Amount = amount;
            Code = code;
        }

        public override string ToString()
        {
            return $"{Amount} {Code}";
        }
        
    }
}
