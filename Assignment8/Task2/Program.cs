using System.Linq.Expressions;
using Task2;

public class programm
{
    public static void Main(string[] args)
    {
        Currency curency = new Currency(500, "GEL");
        BankAccount anonymusBank = new BankAccount("111", "Anonym", new Currency(100, "USD"));
        BankAccount ottosBank = new BankAccount("222", "Otto", curency);
        Console.WriteLine($"Balance otto: {ottosBank.BalanceCheck()}");
        Console.WriteLine($"Balance anonymus: {anonymusBank.BalanceCheck()}");
        Console.WriteLine();

        ottosBank.Deposit(new Currency(400, "USD"));
        Console.WriteLine($"Balance otto after deposit: {ottosBank.BalanceCheck()}");

        ottosBank.Withdraw(new Currency(200, "EUR"));
        Console.WriteLine($"Balance otto after withdraw: {ottosBank.BalanceCheck()}");
        Console.WriteLine();

        ottosBank.TransferFunds(anonymusBank, new Currency(100, "GEL"));
        Console.WriteLine($"Balance otto: {ottosBank.BalanceCheck()}");
        Console.WriteLine($"Balance anonymus: {anonymusBank.BalanceCheck()}");

    }
}