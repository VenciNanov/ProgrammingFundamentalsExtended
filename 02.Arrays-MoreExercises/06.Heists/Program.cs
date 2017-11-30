using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var jewPrice = prices[0];
            var goldPrice = prices[1];

            var jewCount = 0;
            var goldCount = 0;
            var expensesCount = 0;
            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                var heist = input[0];
                var expenses = input[1];

                if (input[0] == "Jail" && input[1] == "Time")
                {
                    break;
                }
                for (int i = 0; i < heist.Length; i++)
                {
                    var robery = input[0].ToCharArray();

                    if (robery[i] == '%')
                    {
                        jewCount++;
                    }
                    else if (robery[i] == '$')
                    {
                        goldCount++;
                    }
                }
                expensesCount += int.Parse(expenses);
            }
            var jewSum = jewCount * jewPrice;
            var goldSum = goldCount * goldPrice;
            var heistSum = jewSum + goldSum;

            if (heistSum >= expensesCount)
            {
                var sum = expensesCount - heistSum;
                Console.WriteLine($"Heists will continue. Total earnings: {Math.Abs(sum)}.");
            }
            else
            {
                var sum = heistSum - expensesCount;
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(sum)}.");
            }

        }
    }
}
