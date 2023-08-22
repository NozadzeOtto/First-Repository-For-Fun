using System.Diagnostics;
using Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    static async Task ChargeAllCars(IEnumerable<ElectricCar> cars)
    {
        var stopwatch = new Stopwatch();
        var chargingStarted = DateTime.Now;
        stopwatch.Start();

        var chargingTasks = cars.Select(car => car.Charge());

        await Task.WhenAll(chargingTasks);

        stopwatch.Stop();

        Console.WriteLine($"Charging started at: " + chargingStarted.ToString());
        Console.WriteLine($"Charging finished at: {DateTime.Now}");
        Console.WriteLine($"Total charging time: {stopwatch.Elapsed.TotalSeconds} seconds");
    }

    static void Main(string[] args)
    {
        var cars = new List<ElectricCar>
        {
            new ElectricCar { Model = "Tesla Model S", Year = 2022, BatteryLevel = 0 },
            new ElectricCar { Model = "Ford Mustang Mach-E", Year = 2023, BatteryLevel = 0 },
            new ElectricCar { Model = "Toyota Prius", Year = 2020, BatteryLevel = 0 }
        };

        Console.WriteLine("Charging electric cars...");
        ChargeAllCars(cars).Wait();
    }
}