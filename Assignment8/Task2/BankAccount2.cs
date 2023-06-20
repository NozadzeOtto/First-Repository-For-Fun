using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class BankAccount
    {
        public void TransferFunds(BankAccount target, Currency amount)
        {
            this.Withdraw(amount);
            target.Deposit(amount);
        }
    }
}
