using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse);

            var result = new List<int>(input.OrderByDescending(x => x).Take(3));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
