Boolean play = true;

while (play)
{
    int countAnswers = 0;
    Boolean incorrect = true;
    Console.WriteLine("Sheiyvanet diapazonis sawyisi: ");
    int startRange = int.Parse(Console.ReadLine());
    Console.WriteLine("Sheiyvanet diapazonis bolo: ");
    int endRange = int.Parse(Console.ReadLine());

    Random rand = new Random();
    int randomNumber = rand.Next(startRange, endRange);

    Console.WriteLine("programam airchia rcxvi diapazonishi, ecade gamoicno!");
    while (incorrect)
    {
        countAnswers++;
        int guessInput = int.Parse(Console.ReadLine());
        if (guessInput == randomNumber) incorrect = false;
    }

    Console.WriteLine("sworia! gamosacnobad dagchirda " + countAnswers + " mcdeloba");
    Console.WriteLine("gsurs gagrdzeleba? Y/N");
    string answer = Console.ReadLine();
    if (answer.ToUpper() == "N") play = false;
    else if (answer.ToUpper() == "Y") continue;
    else { Console.WriteLine("gaugebari mnishvneloba"); };

}