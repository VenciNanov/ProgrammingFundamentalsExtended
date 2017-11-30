using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();



            while (true)
            {
                var comm = Console.ReadLine().Split(' ').ToArray();

                if (comm[0]=="END")
                {
                    break;
                }
                if (comm[0] == "Distinct")
                {
                    input = Distinct(input);
                }
                else if (comm[0] == "Reverse")
                {
                    input = Reverse(input);
                }
                else if (comm[0] == "Replace")
                {
                    if (int.Parse(comm[1]) > input.Length-1|| int.Parse(comm[1])<0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        input[int.Parse(comm[1])] = comm[2];
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
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
