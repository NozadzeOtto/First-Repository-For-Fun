using Assignment14;
using System.ComponentModel.Design;

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
                    FillQuizz(); break;
                case 3: break;
                default: Console.WriteLine("Wrong answer!"); break;
            }
            break;
        }

        
    }

    private static void AddQuestions(FileStream fs)
    {
        
    }

    static void FillQuizz()
    {
        throw new NotImplementedException();
    }

    static void CreateQuizz()
    {
        Console.WriteLine("Enter File Name:");
        string path = Helpers.GetPath(Console.ReadLine());
        bool deleteOldQuestions = false;
        FileStream fs;

        if (File.Exists(path))
        {
            var fileInfo = new FileInfo(path);

            if (fileInfo.Length != 0)
            {
                Console.WriteLine("Would you like to delete old questions? Y/N");
                if (Console.ReadLine().ToLower() == "y")
                {
                    fs = File.Open(path, FileMode.Create);
                }
                else
                {
                    fs = File.Open(path, FileMode.Append);
                }
            }
            else
            {
                fs = File.Open(path, FileMode.Append);
            }
        }
        else 
        {
            
            fs = File.Create(path); Console.WriteLine("created"); 
        }
    
        AddQuestions(fs);
        
    }
}
