using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Dictionary<string, int>();
            string inputArgs;

            while ((inputArgs = Console.ReadLine()) != "shopping time")
            {
               
                var input = inputArgs.Split().ToArray();

                var format = input[0];
                var product = input[1];
                var quant = int.Parse(input[2]);

                if (format == "stock")
                {
                    if (!stock.ContainsKey(product))
                    {
                        stock[product] = quant;
                    }
                    else
                    {
                        stock[product] += quant;
                    }
                }
            }
            while ((inputArgs = Console.ReadLine()) != "exam time")
            {
                var input = inputArgs.Split().ToArray();

                var format = input[0];
                var product = input[1];
                var quant = int.Parse(input[2]);

                if (format == "buy")
                {
                    if (!stock.ContainsKey(product))
                    {
                        Console.WriteLine($"{product} doesn't exist");
                    }
                    else if (stock.ContainsKey(product))
                    {
                        int itemStock = stock[product];
                        if (itemStock==0)
                        {
                            Console.WriteLine($"{product} out of stock");
                        }
                        else if (quant > itemStock)
                        {
                            stock[product] = 0;
                        }
                        else
                        {
                            stock[product] -= quant;
                        }
                    }
                }
            }
            
            foreach (var item in stock)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
