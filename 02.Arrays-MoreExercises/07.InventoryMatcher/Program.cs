using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = Console.ReadLine().Split(' ').ToArray();
            var quant = Console.ReadLine().Split(' ').ToArray();
            var price = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                var input = Console.ReadLine();

                if (input=="done")
                {
                    break;
                }

                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i]==input)
                    {
                        Console.WriteLine($"{input} costs: {price[i]}; Available quantity: {quant[i]}");
                    }
                }
                
            }
        }
    }
}
