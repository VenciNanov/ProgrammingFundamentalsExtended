using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var racers = Console.ReadLine().Split();

            var track = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var checkPoints = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var dict = new Dictionary<string, double>();

            foreach (var racer in racers)
            {

                double fuel = (double)racer[0];

                for (int j = 0; j < track.Length; j++)
                {
                    var counter = 0;
                    var fuelReduction = track[j];

                    if (checkPoints.Contains(j))
                    {
                        fuel += track[j];
                        counter++;

                    }
                    else
                    {
                        fuel -= fuelReduction;
                    }
                    if (fuel < 0)
                    {
                        Console.WriteLine($"{racer} - reached {j}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{racer} - fuel left {fuel:f2}");
                }

            }

            //foreach (var racer in dict)
            //{
            //    if (racer.Value <= 0)
            //    {
            //        Console.WriteLine($"{racer.Key} - reached ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{racer.Key} - fuel left {racer.Value:f2}");
            //    }
            //}


        }
    }
}
