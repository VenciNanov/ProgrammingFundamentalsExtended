using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> elements = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long sum = 0;

            while (elements.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());

                long element;

                if (index < 0)
                {
                    element = elements[0];
                    elements[0] = elements[elements.Count - 1];
                }
                else if (index >= elements.Count)
                {
                    element = elements[elements.Count - 1];
                    elements[elements.Count - 1] = elements[0];
                }
                else
                {
                    element = elements[index];
                    elements.RemoveAt(index);
                }

                sum += element;

                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i] <= element)
                    {
                        elements[i] += element;
                    }
                    else
                    {
                        elements[i] -= element;
                    }

                }

            }
            Console.WriteLine(sum);
        }
    }
}
