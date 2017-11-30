using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var n = int.Parse(Console.ReadLine());

            List<string> ingredients = new List<string>();
            var count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToCharArray().Length==n)
                {
                    Console.WriteLine($"Adding {input[i]}.");
                    count++;
                    ingredients.Add(input[i]);
                }
                if (count==10)
                {
                    break;
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",ingredients)}.");
            

        }
    }
}
