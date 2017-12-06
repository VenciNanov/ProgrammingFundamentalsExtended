using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            List<string> output = new List<string>();

            for (int i = 1; i <= input.Count-1; i++)
            {
                if (i%2!=0)
                {
                    output.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join("",output));

        }
    }
}
