using System.Linq.Expressions;
using Task2;

public class programm
{
    public static void Main(string[] args)
    {
        Currency curency = new Currency(500, "GEL");
        //Console.WriteLine(curency.ToString());
        BankAccount ottosBank = new BankAccount("12313453223423", "Otto", curency);

        Console.WriteLine(ottosBank.Balance.ToString());

        Console.WriteLine(ottosBank.BalanceCheck);
        curency.Amount = 100;
        curency.Code = "USD";

        ottosBank.Deposit(curency);

        Console.WriteLine(ottosBank.BalanceCheck);
    }
}