using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Distinct")
                {
                   input= Distinct(input);
                }
                else if (command[0] == "Reverse")
                {
                    input = Reverse(input);
                }
                else if (command[0] == "Replace")
                {
                    input[int.Parse(command[1])] = command[2];
                    
                }
            }
            Console.WriteLine(string.Join(", ", input));

        }

        private static string[] Distinct(string[] array)
        {
            return array.Distinct().ToArray();
        }
        private static string[] Reverse(string[] array)
        {
            return array.Reverse().ToArray();
        }
       
    }
}
