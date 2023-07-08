using Assignment14;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1. Create Quizz");
            Console.WriteLine("2. Fill Existing Quizz");
            Console.WriteLine("3. Quit");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    CreateQuizz(); break;
                case 2:
                    OpenQuizz(); break;
                case 3: Console.WriteLine("You Quit."); break;
                default: Console.WriteLine("Wrong answer!"); break;
            }
            break;
        }        
    }

    static void CreateQuizz()
    {
        Console.WriteLine("Enter File Name:");
        string fileName = Console.ReadLine();
        string path = Helpers.GetPath(fileName);

        if (File.Exists(path))
        {
            var fileInfo = new FileInfo(path);

            if (fileInfo.Length != 0)
            {
                Console.WriteLine("Would you like to delete old questions? Y/N");
                if (Console.ReadLine().ToLower() == "y")
                {
                    AddQuestionsInQuizz(fileName, Helpers.FileOption.CreateNewOrOverWrite);
                }
                else
                {
                    AddQuestionsInQuizz(fileName, Helpers.FileOption.AppendToOldQuestions);
                }
            }
            else
            {
                AddQuestionsInQuizz(fileName, Helpers.FileOption.AppendToOldQuestions);
            }
        }
        else
        {
            AddQuestionsInQuizz(fileName, Helpers.FileOption.CreateNewOrOverWrite);
        }

    }

    // Open existed quizz 
    static void OpenQuizz()
    {
        Console.WriteLine("Enter File Name:");
        string fileName = Console.ReadLine();
        string path = Helpers.GetPath(fileName);

        if (File.Exists(path))
        {
            using var fs = new StreamReader(path);
            Quizz quizz = GetQuizzFromFile(fs);
            FillOutQuizz(quizz);
        }
        else
        {
            Console.WriteLine($"File '{fileName}' does not exists");
        }
    }

    // user fills out questions
    private static void FillOutQuizz(Quizz quizz)
    {
        int answerKey;
        int correctAnswersCount = 0;
        int score = 0;
        Console.WriteLine($"Fill out the Quizz - {quizz.Name}");
        Console.WriteLine("Enter you Full Name:");
        string user = Console.ReadLine();
        Console.WriteLine();
        foreach (Questions question in quizz.Questions)
        {
            Console.WriteLine($"{question.Question} ({question.Score} Score)");
            for (int i = 0; i < question.PossibleAnswers.Count; i++)
            {
                Console.Write($"{i}){question.PossibleAnswers[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("Answer with number:");
            answerKey = int.Parse(Console.ReadLine());
            if (answerKey == question.RealAnswerKey)
            {
                correctAnswersCount++;
                score+= question.Score;
            }
        }

        Console.WriteLine($"{user}, You answered {correctAnswersCount} questions correctly. Your score is {score}");

    }

    // Reads File and converts to Quizz object
    private static Quizz GetQuizzFromFile(StreamReader fs)
    {
        var quizz = new Quizz();
        quizz.Name = fs.ReadLine();

        string line;
        while ((line = fs.ReadLine()) != null)
        {
            var questions = new Questions();
            questions.Question = line;
            questions.Score = int.Parse(fs.ReadLine());
            questions.RealAnswerKey = int.Parse(fs.ReadLine());
            string possibleAnswer;
            while ((possibleAnswer = fs.ReadLine()) != null && possibleAnswer != "--")
            {
                questions.PossibleAnswers.Add(possibleAnswer);
            }
            quizz.Questions.Add(questions);
        }

        return quizz;
    }


    // user inputs questions, score, possible answers and correct answer
    private static void AddQuestionsInQuizz(string fileName,  Helpers.FileOption fileption)
    {
        Quizz quizz= new Quizz();
        if((int)fileption!=2)
        {
            Console.WriteLine("Enter Quizz Name:");
            quizz.Name = Console.ReadLine();
        }


        bool finnished = false;
        while (!finnished)
        {
            // write question
            Questions question = new();
            Console.WriteLine("Write question:");
            string qstn;
            while ((qstn = Console.ReadLine()) == "")
            {
                Console.WriteLine("Write question:");
            }
            question.Question = qstn;

            // Add Possible answers
            Console.WriteLine("Add possible answers and write 'Done' to stop.");
            while (true)
            {
                var answer = Console.ReadLine();
                if (answer.ToLower() == "done")
                {
                    break;
                }
                else if (answer != "")
                {
                    question.PossibleAnswers.Add(answer);
                }
            }

            // choose Correct answer
            Console.WriteLine("Which One is correct answer?");
            for (int i = 0; i < question.PossibleAnswers.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, question.PossibleAnswers[i]);
            }
            question.RealAnswerKey = int.Parse(Console.ReadLine());

            // Score Of Question
            Console.WriteLine("What is score of the question?");
            question.Score = int.Parse(Console.ReadLine());

            quizz.Questions.Add(question);

            // finished?
            bool madeChoice = false;
            while (!madeChoice)
            {
                Console.WriteLine("1. finnish! ");
                Console.WriteLine("2. Add another Question!");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: finnished = madeChoice = true; break;
                    case 2: madeChoice = true; break;
                    default: Console.WriteLine("Wrong choice!"); break;
                }
            }
        }
        SaveQuizz(quizz, fileName, fileption);
    }

    private static void SaveQuizz(Quizz quizz, string fileName, Helpers.FileOption fileOption)
    {
        // Save the quizz?
        bool saveChanges = false;
        while (true)
        {
            Console.WriteLine("Save the quizz? Y/N");
            if(Console.ReadLine().ToUpper() == "Y")
            {
                saveChanges = true;
                break;
            }else if (Console.ReadLine().ToUpper() == "N")
            {
                break;
            }
        }

        // Saving...
        if (saveChanges)
        { 
            string path = Helpers.GetPath(fileName);

            //CreateNewOrOverWrite = 1,
            //AppendToOldQuestions = 2,
            if ((int)fileOption == 2)
            {
                using var fs = File.AppendText(path);
                WriteInFile(fs, quizz);
            }
            else
            {
                using var fs = File.CreateText(path);
                WriteInFile(fs, quizz);
            }
        }
    }

    // writes text in File
    private static void WriteInFile(StreamWriter fs, Quizz quizz)
    {
        fs.WriteLine(quizz.Name);
        foreach (Questions question in quizz.Questions)
        {
            fs.WriteLine(question.Question);
            fs.WriteLine(question.Score);
            fs.WriteLine(question.RealAnswerKey);
            for (int i = 0; i < question.PossibleAnswers.Count; i++)
            {
                fs.WriteLine(question.PossibleAnswers[i]);
            }
            fs.Write("--");
        }
    }
}


