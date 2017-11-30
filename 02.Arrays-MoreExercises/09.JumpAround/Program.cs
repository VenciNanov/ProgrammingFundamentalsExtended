using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var index = input[0];
            var sum = index ;

            while (true)
            {
                if (input.Length>=index)
                {
                    input.Skip(index - 1).Take(1);
                }

            }

        }
    }
}
