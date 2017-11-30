using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pokePower = decimal.Parse(Console.ReadLine());
            decimal distanceBetweenTargets = decimal.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            decimal pokePowerOriginalValue = pokePower;
            var counter = 0;

            while (distanceBetweenTargets <= pokePower)
            {

                pokePower -= distanceBetweenTargets;
                counter++;
                if (pokePower==pokePowerOriginalValue/2&& exhaustionFactor>0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(Math.Floor(pokePower));
            Console.WriteLine(counter);
        }
    }
}
