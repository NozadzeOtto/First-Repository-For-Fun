Boolean play = true;

while (play)
{
    int countAnswers = 0;
    Boolean incorrect = true;
    Console.WriteLine("Min: ");
    int startRange = int.Parse(Console.ReadLine());
    Console.WriteLine("Max: ");
    int endRange = int.Parse(Console.ReadLine());

    Random rand = new Random();
    int randomNumber = rand.Next(startRange, endRange + 1);

    Console.WriteLine("programam airchia rcxvi diapazonishi, ecade gamoicno!");
    while (incorrect)
    {
        int guessInput = int.Parse(Console.ReadLine());
        countAnswers++;
        if (guessInput == randomNumber) incorrect = false;
    }

    Console.WriteLine("sworia! gamosacnobad dagchirda " + countAnswers + " mcdeloba");
    Console.WriteLine("gsurs gagrdzeleba? Y/N");
    string answer = Console.ReadLine();
    if (answer.ToUpper() == "N") play = false;
    else if (answer.ToUpper() == "Y") continue;
    else { Console.WriteLine("gaugebari mnishvneloba"); };

}