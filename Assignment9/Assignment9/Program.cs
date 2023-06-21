using Assignment9;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Choose vehicle category:");
        Console.WriteLine("1.Combat");
        Console.WriteLine("2.Persnal");
        Console.WriteLine("3.Public");
        Console.WriteLine("4.Sport");
        int category = ReadInt(1, 4);

        CreateVehicle(category);

        void CreateVehicle(int category)
        {
            switch (category)
            {
                case 1: CreateCombatVehicle(); break;
                case 2: CreatePersonalVehicle(); break;
                case 3: CreatePublicVehicle(); break;
                case 4: CreateSportVehicle(); break;
            }
            Console.WriteLine();
        }

        void CreateCombatVehicle()
        {
            Combat vehicle = new Combat();
            int categoryNumber = PrintSportCarsCategories(typeof(CombatCar));
            string name = Enum.GetName(typeof(CombatCar), categoryNumber);
            vehicle.GetInfo(name);
            vehicle.Models = getModels();
            Console.WriteLine("Shoots? (type: 'Y')");
            if (Console.ReadLine().ToLower() == "y") vehicle.Shoots = true;
            vehicle.PrintInfo();
            vehicle.PrintDescription();
        }
        void CreateSportVehicle()
        {
            Sport vehicle= new Sport();
            int categoryNumber = PrintSportCarsCategories(typeof(SportCar));
            string name = Enum.GetName(typeof(SportCar), categoryNumber);
            vehicle.GetInfo(name);
            vehicle.Models = getModels();
            Console.WriteLine("Input horse power:");
            vehicle.horsePower = int.Parse(Console.ReadLine());
            Console.WriteLine("Input top speed:");
            vehicle.TopSpeed = int.Parse(Console.ReadLine());
            vehicle.PrintInfo();
            vehicle.PrintDescription();
        }
        void CreatePublicVehicle()
        {
            Public vehicle = new Public();
            int categoryNumber = PrintSportCarsCategories(typeof(PublicCar));
            string name = Enum.GetName(typeof(PublicCar), categoryNumber);
            vehicle.GetInfo(name);
            vehicle.Models = getModels();
            Console.WriteLine("Input passanger amount:");
            vehicle.PassengerAmount = int.Parse(Console.ReadLine());
            vehicle.PrintInfo();
            vehicle.PrintDescription();
        }
        void CreatePersonalVehicle()
        {
            Personal vehicle = new Personal();
            int categoryNumber = PrintSportCarsCategories(typeof(PersonalCar));
            string name = Enum.GetName(typeof(PersonalCar), categoryNumber);
            vehicle.GetInfo(name);
            vehicle.Models = getModels();
            Console.WriteLine("Input amount of seats:");
            vehicle.SeatAmount = int.Parse(Console.ReadLine());
            vehicle.PrintInfo();
            vehicle.PrintDescription();
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

        static int PrintSportCarsCategories(Type enumType)
        {
            int number = 1;
            int categoryNumber;
            Console.WriteLine($"Enter the name of {enumType.Name} vehicle from the list below:");
            foreach (var i in Enum.GetValues(enumType))
            {
                Console.WriteLine($"{number}.{i} ");
                number++;
            }
            categoryNumber = ReadInt(0, number);
            return categoryNumber;
        }
    }
}


