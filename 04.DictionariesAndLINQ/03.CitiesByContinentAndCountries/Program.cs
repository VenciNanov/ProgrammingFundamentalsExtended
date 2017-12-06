using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CitiesByContinentAndCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            var countriesByContinent = new Dictionary<string, Dictionary<string, List<string>>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var continent = input[0];
                var country = input[1];
                var town = input[2];

                if (!countriesByContinent.ContainsKey(continent))
                {
                    countriesByContinent[continent] = new Dictionary<string, List<string>>();
                }
                if (!countriesByContinent[continent].ContainsKey(country))
                {
                    countriesByContinent[continent][country] = new List<string>();
                }
                countriesByContinent[continent][country].Add(town);
            }
            foreach (var continent in countriesByContinent)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }

        }
    }
}
