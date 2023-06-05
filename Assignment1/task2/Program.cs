internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("airchiet:\nqva - 0, makrateli - 1, qagaldi - 2");
        string userChose = Console.ReadLine();
        int userNumber = int.Parse(userChose);

        if (userNumber < 0 || userNumber > 2) { Console.WriteLine("Tqven sheiyvanet araswori mnishvneloba"); return; }


        Random rnd = new Random();
        int randomNumber = rnd.Next(0, 3);
        string randomChose;

        switch (randomNumber)
        {
            case 0:
                randomChose = "Qva";
                break;
            case 1:
                randomChose = "Makrateli";
                break;
            default:
                randomChose = "Qagaldi";
                break;
        }

        Console.WriteLine("kompiuterma airchia: " + randomChose);
        string winner = "aravin";
        switch (randomNumber)
        {
            case 0:
                if (userNumber == 0) { winner = "aravin"; }
                else if (userNumber == 1) { winner = "kompiuteri"; }
                else { winner = "momxmarebeli"; }
                break;

            case 1:
                if (userNumber == 0) { winner = "momxmarebeli"; }
                else if (userNumber == 1) { winner = "aravin"; }
                else { winner = "kompiuteri"; }
                break;

            case 2:
                if (userNumber == 0) { winner = "kompiuteri"; }
                else if (userNumber == 1) { winner = "momxmarebeli"; }
                else { winner = "aravin"; }
                break;
        }
        Console.WriteLine("gamarjvebulia " + winner);
    }
}