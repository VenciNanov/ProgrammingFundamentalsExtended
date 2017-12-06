using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> inputTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var length = Math.Max(inputOne.Count, inputTwo.Count);

            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}
