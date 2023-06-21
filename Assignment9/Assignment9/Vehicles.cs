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
        public string CategoryName { get; set; }
        public Models Models { get; set; }
        public abstract void GetInfo(string name);
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Category: {CategoryName}");
            Console.WriteLine($"Model: {Models}");
        }
    }

    public class Combat : Vehicles, IDescription
    {
        public bool Shoots { get; set; }
        public string Details { get; set; }
        public override void GetInfo(string name)
        {
            CategoryName = name;
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
        public override void GetInfo(string name)
        {
            CategoryName = name;
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
        public override void GetInfo(string name)
        {
            CategoryName = name;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Passenger amount: {PassengerAmount}");
        }
        public void PrintDescription()
        {
            Console.WriteLine("Public vehicles are used for public transport.");
        }
    }

    public class Personal : Vehicles, IDescription
    {
        public string Color { get; set; }
        public int SeatAmount { get; set; }
        public override void GetInfo(string name)
        {
            CategoryName = name;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Amount of seats: {SeatAmount}");
        }
        public void PrintDescription()
        {
            Console.WriteLine("Personal vehicles are used for family or personal use.");
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
        Volvo = 8,
    }

    public enum SportCar
    {
        Off_Road = 1,
        Rally = 2,
        F1 = 3,
        SuperCar = 4,
    }

    public enum PublicCar
    {
        Bus = 1,
        Trum = 2,
    }

    public enum PersonalCar
    {
        SUV = 1,
        Sedan = 2,
        Motorcycle = 3,
        Bicycle = 4,
    }

    public enum CombatCar
    {
        Tank = 1,
        ArmouredCar = 2,
    }
}
