using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> plane = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int position = int.Parse(Console.ReadLine());

            var dmg = 1;

            while (true)
            {
                var command = Console.ReadLine().Split(' ');
                if (command[0] == "Supernova")
                {
                    break;
                }
                var direction = command[0];
                var steps = int.Parse(command[1]);
                
                if (direction == "left" && steps != 0)
                {
                    for (int i = 1; i <= steps; i++)
                    {
                        if (position <= 0)
                        {
                            dmg++;
                            position = plane.Count;
                        }
                        plane[position - 1] -= dmg;
                        position--;
                    }
                }
                else if (direction == "right" && steps != 0)
                {
                    for (int i = 1; i <= steps; i++)
                    {
                        if (position >= plane.Count - 1)
                        {
                            dmg++;
                            position = -1;
                        }
                        plane[position + 1] -= dmg;
                        position++; ;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",plane));

        }
    }
}
