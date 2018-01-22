using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SplinterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripDistance = double.Parse(Console.ReadLine());
            var tankCapacity = double.Parse(Console.ReadLine());
            var milesInHeavyWinds = double.Parse(Console.ReadLine());

            var milesInNonHeavyWinds = tripDistance - milesInHeavyWinds;
            var nonHeavyWindsConsumption = milesInNonHeavyWinds * 25;
            var heavyWindsConsumption = milesInHeavyWinds * (25 * 1.5);
            var totalConsumption = nonHeavyWindsConsumption + heavyWindsConsumption;
            var tolerance = totalConsumption * 0.05;
            var totalFuelConsumption = totalConsumption + tolerance;

            var remainingFuel = tankCapacity - totalFuelConsumption;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
            if (remainingFuel < 0)
            {
                Console.WriteLine($"We need {Math.Abs(remainingFuel):f2}L more fuel.");
            }
            else
            {
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
            }
        }
    }
}
