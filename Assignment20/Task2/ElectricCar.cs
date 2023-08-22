using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ElectricCar
    {
        public int BatteryLevel { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public async Task Charge()
        {
            while (BatteryLevel < 100)
            {
                await Task.Delay(10000); 
                BatteryLevel += 5;
                Console.WriteLine($"{Model} ({Year}) Battery Level: {BatteryLevel}%");
            }
        }
    }
}
