using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var avLaps = int.Parse(Console.ReadLine());
            var lengtOfTrack = int.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            var capacityForAllDays = capacityOfTrack * days;
            if (runners>capacityForAllDays)
            {
                runners = capacityForAllDays;
            }
            var total = (runners*avLaps*(double)lengtOfTrack)/ 1000;
            double sum = total * moneyPerKm;
            Console.WriteLine($"Money raised: {sum:f2}");


        }
    }
}
