using Assignment9;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Program
{
    public static void Main(String[] args)
    {

        void CreateCombatVehicle()
        {
            Combat combat = new Combat();
            combat.GetInfo();
            combat.Models = getModels();
            Console.WriteLine("Shoots? Y/N");
            if (Console.ReadLine().ToLower() == "y") combat.Shoots = true;
            combat.PrintInfo();
            combat.PrintDescription();
        }
        void CreateSportVehicle()
        {
            Sport sport= new Sport();
            sport.GetInfo();
            sport.Models = getModels();
            Console.WriteLine("input horse power:");
            sport.horsePower = int.Parse(Console.ReadLine());
            Console.WriteLine("Input top speed:");
            sport.TopSpeed = int.Parse(Console.ReadLine());
            sport.PrintInfo();
            sport.PrintDescription();
        }


        CreateCombatVehicle();
        void CreateVehicle(int type)
        {
            switch (type)
            {
                case 1: CreateCombatVehicle(); break;
            }
            Console.WriteLine();
        }







        static int ReadInt(int min, int max)
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || result < min || result > max) {
                Console.WriteLine($"Wrong number, input between {min} and {max}");
            }
            return result;
        }

        static Models getModels()
        {
            int number = 0;
            Console.WriteLine("Choose model: ");
            foreach (Models i in Enum.GetValues(typeof(Models)))
            {
                Console.Write($"{number}.{i} ");
                number++;
            }
            Console.WriteLine();

            int modelNumber = ReadInt(0, 7);

            switch (modelNumber)
            {
                case 1: return Models.BMW; 
                case 2: return Models.Honda; 
                case 3: return Models.Ford; 
                case 4: return Models.Honda;
                case 5: return Models.Lamborgini;
                case 6: return Models.Ferrari;
                case 7: return Models.Mercedes_Benz;
                default: return Models.Undefined;
            }
        }

    }
}


