using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var distancePer1000Flaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var distance = (n / 1000) * distancePer1000Flaps;

            var flapsPerSecond = n / 100;
            var rest = (n / endurance) * 5;
            var sum = flapsPerSecond + rest;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{sum} s.");


        }
    }
}
