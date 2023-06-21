using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    interface IDescription
    {
        void PrintDescription();
    }
    public abstract class Vehicles
    {
        public string Name { get; set; }
        public Models Models { get; set; }
        public abstract void GetInfo();
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Model: {Models.ToString()}");
        }
    }


    public class Combat : Vehicles, IDescription
    {
        public bool Shoots { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine("Choose combat vehicle:");
            Console.WriteLine("Tank");
            Console.WriteLine("Armoured Car");
            Name = Console.ReadLine();
        }
        public void PrintDescription()
        {
            Console.WriteLine("Combat vehicles are used for wars.");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Shoots: {Shoots}");
        }
    }

    public class Sport : Vehicles, IDescription
    {
        public int TopSpeed{ get; set; }
        public int horsePower { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine("Choose combat vehicle:");
            Console.WriteLine("F1");
            Console.WriteLine("SuperCar");
            Console.WriteLine("RallyCar");
            Name = Console.ReadLine();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Horse power: {horsePower}");
            Console.WriteLine($"Top speen: {TopSpeed}");
        }
        public void PrintDescription()
        {
            Console.WriteLine("Sport vehicles are used for racing.");
        }
    }

    public class Public : Vehicles, IDescription
    {
        public int PassengerAmount { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine("Choose combat vehicle:");
            Console.WriteLine("Bus");
            Console.WriteLine("Trum");
            Name = Console.ReadLine();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Passenger amount: {PassengerAmount}");
        }
        public void PrintDescription()
        {
            Console.WriteLine("Public vehicles are used public transport.");
        }
    }

    public class Personal : Vehicles, IDescription
    {
        public int PassengerAmount { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine("Choose combat vehicle:");
            Console.WriteLine("Bus");
            Console.WriteLine("Trum");
            Name = Console.ReadLine();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Passenger amount: {PassengerAmount}");
        }
        public void PrintDescription()
        {
            Console.WriteLine("Personal vehicles are used family or personal use.");
        }
    }

    public enum Models
    {
        Undefined = 0,
        BMW = 1,
        Honda = 2,
        Ford = 3,
        Hyunday = 4,
        Lamborgini = 5,
        Ferrari = 6,
        Mercedes_Benz = 7,
    }
}
