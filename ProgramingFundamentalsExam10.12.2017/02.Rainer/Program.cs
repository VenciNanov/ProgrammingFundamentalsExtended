using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> field = new List<int>(inputArr.Reverse().Skip(1).Reverse());

            List<int> originalField = new List<int>(field);


            int donaldIndex = inputArr.Last();

            var stepsDone = 0;

            while (true)
            {
                field = field.Select(x => x - 1).ToList();
                stepsDone++;

                Again:
                if (field.Contains(0))
                {
                    var zeroIndex = field.FindIndex(x => x == 0);

                    if (donaldIndex == zeroIndex)
                    {
                        break;
                    }
                    else
                    {
                        field[zeroIndex] = originalField
                            [zeroIndex];

                        goto Again;
                    }
                }
                donaldIndex = int.Parse(Console.ReadLine());
            }
            //printing
            Console.WriteLine(string.Join(" ", field));

            Console.WriteLine(stepsDone - 1);


        }
    }
}
