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

        public void Deposit(Currency amount)
        {
            Balance = new Currency(Balance.Amount + amount.Amount, amount.Code);
        }

        public void Withdraw(Currency amount)
        {
            Balance = new Currency(Balance.Amount - amount.Amount, amount.Code);
        }

        public string BalanceCheck()
        {
            //return $"{Balance.Amount} {Balance.Code}";
            return Balance.ToString();
        }

        //public double Convert(double amount, string code)
        //{
        //    switch (code)
        //    {
        //        case nameof(CurrencyType.USD):
        //            amount *= 2.5;
        //            break;
        //        case nameof(CurrencyType.EUR):
        //            amount *= 2.7;
        //            break;
        //        default:
        //            break;
        //    }
        //    return amount;
        //}

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

    //public enum CurrencyType
    //{
    //    USD,
    //    GEL,
    //    EUR
    //}

}
