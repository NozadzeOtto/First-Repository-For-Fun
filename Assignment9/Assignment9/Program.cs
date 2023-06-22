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

        int category = Helpers.ReadInt(1, 4);
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

        //Lets User Create Combat Class Object
        void CreateCombatVehicle()
        {
            Combat vehicle = new Combat();
            int categoryNumber = Helpers.PrintVehiclesCategories(typeof(CombatCar));
            string name = Enum.GetName(typeof(CombatCar), categoryNumber);
            vehicle.GetInfo(name);
            vehicle.Models = Helpers.getModels();
            Console.WriteLine("Shoots? (type: 'Y')");
            if (Console.ReadLine().ToLower() == "y") vehicle.Shoots = true;
            Console.WriteLine("Input more details: ");
            vehicle.Details = Console.ReadLine();
            vehicle.PrintInfo();
            vehicle.PrintDescription();
        }

        ////Lets User Create Sport Class Object
        void CreateSportVehicle()
        {
            Sport vehicle= new Sport();
            int categoryNumber = Helpers.PrintVehiclesCategories(typeof(SportCar));
            string name = Enum.GetName(typeof(SportCar), categoryNumber);
            vehicle.GetInfo(name);
            vehicle.Models = Helpers.getModels();
            Console.WriteLine("Input horse power:");
            vehicle.horsePower = int.Parse(Console.ReadLine());
            Console.WriteLine("Input top speed:");
            vehicle.TopSpeed = int.Parse(Console.ReadLine());
            vehicle.PrintInfo();
            vehicle.PrintDescription();
        }

        //Lets User Create Public Class Object
        void CreatePublicVehicle()
        {
            Public vehicle = new Public();
            int categoryNumber = Helpers.PrintVehiclesCategories(typeof(PublicCar));
            string name = Enum.GetName(typeof(PublicCar), categoryNumber);
            vehicle.GetInfo(name);
            vehicle.Models = Helpers.getModels();
            Console.WriteLine("Input passanger amount:");
            vehicle.PassengerAmount = int.Parse(Console.ReadLine());
            vehicle.PrintInfo();
            vehicle.PrintDescription();
        }

        //Lets User Create Personal Class Object
        void CreatePersonalVehicle()
        {
            Personal vehicle = new Personal();
            int categoryNumber = Helpers.PrintVehiclesCategories(typeof(PersonalCar));
            string name = Enum.GetName(typeof(PersonalCar), categoryNumber);
            vehicle.GetInfo(name);
            vehicle.Models = Helpers.getModels();
            Console.WriteLine("Input amount of seats:");
            vehicle.SeatAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Input color:");
            vehicle.Color = Console.ReadLine();
            vehicle.PrintInfo();
            vehicle.PrintDescription();
        }
    }
}


