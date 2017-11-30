using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            var numType = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            long final = 0;
            for (int i = 0; i < n; i++)
            {
                var id = long.Parse(Console.ReadLine());

                if (numType == "sbyte" && (id < sbyte.MaxValue && id > sbyte.MinValue))
                {
                    final =id;
                }
            }
            Console.WriteLine(final);
        }
    }
}
