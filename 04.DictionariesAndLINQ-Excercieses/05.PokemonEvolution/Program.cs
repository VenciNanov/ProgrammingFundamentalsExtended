using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //{pokemonName}{evolutionType}{evolutionIndex}
            //{string}{string}{int}
            var dict = new Dictionary<string, List<string>>();

            string str;

            while ((str = Console.ReadLine()) != "wubbalubbadubdub")
            {
                var input = str.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var pokemon = input[0];
                if (input.Length > 1)
                {
                    string evoType = input[1];
                    int evoIndex = int.Parse(input[2]);

                    if (!dict.ContainsKey(pokemon))
                    {
                        dict[pokemon] = new List<string>();
                    }
                    var indexEvoType= evoType+" <-> "+evoIndex;
                    dict[pokemon].Add(evoType + " <-> " + evoIndex);
                }
                else
                {
                    if (dict.ContainsKey(pokemon))
                    {
                        Console.WriteLine($"# {pokemon}");
                        foreach (var evo in dict[pokemon])
                        {
                            Console.WriteLine($"{evo}");
                        }
                    }
                }
            }

            foreach (var item in dict)
            {
                string name = item.Key;

                Console.WriteLine("# " + name);

                foreach (var typeAndNumber in item
                    .Value
                    .OrderByDescending(x => int.Parse(x.Split(new string[] { " <-> " }, StringSplitOptions.None)
                    .Skip(1)
                    .First())))
                {
                    Console.WriteLine(typeAndNumber);
                }
            }
        }
    }
}
