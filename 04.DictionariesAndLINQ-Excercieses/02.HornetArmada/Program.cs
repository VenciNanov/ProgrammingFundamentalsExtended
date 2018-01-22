using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            var legionParams = new Dictionary<string, Dictionary<string, long>>();
            var legionActivity = new Dictionary<string, long>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var lastAcivity = long.Parse(input[0]);
                var legionName = input[1];
                var soldierType = input[2];
                var soldierCount = long.Parse(input[3]);

                if (!legionParams.ContainsKey(legionName))
                {
                    legionParams[legionName] = new Dictionary<string, long>();
                    legionActivity[legionName] = lastAcivity;
                }
                if (!legionParams[legionName].ContainsKey(soldierType))
                {
                    legionParams[legionName][soldierType] = 0;
                }
                legionParams[legionName][soldierType] += soldierCount;
                if (legionActivity[legionName] < lastAcivity)
                {
                    legionActivity[legionName] = lastAcivity;
                }
            }

            var lastInput = Console.ReadLine().Split('\\').ToArray();

            if (lastInput.Length < 2)
            {
                var currSoldierType = lastInput[0];

                foreach (var legion in legionActivity.OrderByDescending(x => x.Value))
                {
                    if (legionParams[legion.Key].ContainsKey(currSoldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }

                }
            }
            else
            {
                var currActivity = long.Parse(lastInput[0]);
                var currSoldierType = lastInput[1];

                foreach (var legion in legionParams.OrderByDescending(x=>x.Value[currSoldierType]))
                {
                    if (legionActivity[legion.Key]<currActivity&&legionParams[legion.Key].ContainsKey(currSoldierType))
                    {
                        Console.WriteLine($"{legion.Key} -> {legionParams[legion.Key][currSoldierType]}");
                    }
                }

            }
        }
    }
}
