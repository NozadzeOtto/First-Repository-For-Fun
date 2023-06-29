using Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        Calc<string> calc1 = new Calc<string>();
        Console.WriteLine(calc1.Substract("ds", "dd"));

        Calc<Tiger> calc2 = new Calc<Tiger>();
        Tiger tiger1 = new Tiger { Name = "One", Age = 20 };
        Tiger tiger2 = new Tiger { Name = "two", Age = 22 };
        Console.WriteLine(calc2.Add(tiger1, tiger2));
    }

    public class Tiger
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}