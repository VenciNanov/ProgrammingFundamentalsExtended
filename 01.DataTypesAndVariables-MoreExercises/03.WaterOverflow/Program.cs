using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var waterTank = 0;
            

            for (int i = 0; i < n; i++)
            {
                var q = int.Parse(Console.ReadLine());

                if (waterTank+q<=255)
                {
                    waterTank += q;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterTank);
        }
    }
}
