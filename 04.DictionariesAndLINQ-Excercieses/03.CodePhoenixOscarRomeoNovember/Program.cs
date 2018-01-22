using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CodePhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            var creatures = new Dictionary<string, HashSet<string>>();
            List<string> check = new List<string>();

            string str;

            while ((str = Console.ReadLine()) != "Blaze it!")
            {


                var data = str.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string creature = data[0];
                var squadMate = data[1];

                check.Add(squadMate + "" + creature);

                if (!creatures.ContainsKey(creature))
                {
                    creatures.Add(creature, new HashSet<string>());
                }
                if (creature == squadMate || check.Contains(creature + "" + squadMate))
                {
                    creatures[squadMate].Remove(creature);
                    continue;
                }
                creatures[creature].Add(squadMate);
            }

            foreach (var item in creatures.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");

            }
        }
    }
}
