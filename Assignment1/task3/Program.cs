// წელი % 12 = x
// ვირთხა -     2008 - 4     
// ხარი -       2009 - 5  
// ვეფხვი -     2010 - 6      
// კურდღელი - 2011 - 7
// დრაკონი -   2012 - 8  
// გველი -     2013 - 9      
// ცხენი -      2014 - 10  
// ცხვარი -     2015 - 11   
// მაიმუნი -    2016 - 0      
// მამალი -     2017 - 1    
// ძაღლი -     2018 - 2     
// ღორი -      2019 - 3          

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        string yearInputed = Console.ReadLine();
        int year = int.Parse(s: yearInputed);
        int devided = year % 12;

        switch (devided)
        {
            case 0: Console.WriteLine("maimunis "); break;
            case 1: Console.WriteLine("mamlis "); break;
            case 2: Console.WriteLine("dzaglis "); break;
            case 3: Console.WriteLine("goris "); break;
            case 4: Console.WriteLine("virTxis "); break;
            case 5: Console.WriteLine("xaris "); break;
            case 6: Console.WriteLine("vefvis "); break;
            case 7: Console.WriteLine("kurdglis "); break;
            case 8: Console.WriteLine("drakonis "); break;
            case 9: Console.WriteLine("gvelis "); break;
            case 10: Console.WriteLine("cxenis "); break;
            case 11: Console.WriteLine("cxvris "); break;
            default: Console.WriteLine("Error "); break;
        }
    }
}