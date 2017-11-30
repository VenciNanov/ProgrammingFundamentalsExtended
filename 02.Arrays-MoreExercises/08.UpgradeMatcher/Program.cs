using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UpgradeMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = Console.ReadLine().Split(' ').ToArray();
            var quant = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            while (true)
            {
                var input = Console.ReadLine().Split(' ');

                if (input[0] == "done")
                {
                    break;
                }

                var product = input[0];
                var quantWanted = long.Parse(input[1]);



                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == product && (quant.Count<=i || quantWanted > quant[i]))
                    {
                        Console.WriteLine($"We do not have enough {product}");
                        break;
                    }
                    else if (inventory[i] == product && quantWanted <= quant[i])
                    {
                        long sum = quantWanted * (long)price[i];
                        quant[i] -= quantWanted;
                        Console.WriteLine($"{product} x {quantWanted} costs {sum:f2}");
                        break;
                    }


                }

            }
        }
    }
}
//