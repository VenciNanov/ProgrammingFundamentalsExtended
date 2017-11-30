using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            var length = beehives.Count;
            var counter = 0;

            List<long> beehivesFinal = beehives;


            while (counter != length)
            {

                if (hornets.Count<=0)
                {
                    break;
                }

                var power = hornets.Sum();
                var hive = beehives[counter];


                if (power <= hive)
                {
                    hornets.RemoveAt(0);
                    beehivesFinal[counter] -= power;
                }
                else
                {
                    beehivesFinal[counter] -= power;
                }
                
                counter++;
            }

            beehivesFinal.RemoveAll(x => x <= 0);

            if (beehivesFinal.Count>0)
            {
                Console.WriteLine(string.Join(" ",beehivesFinal));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
        }
    }
}
