using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var healthPattern = @"[^0-9+*-\/]";
            var dmgPattern = @"[0-9+*-\/]";

            var healthRegex = new Regex(healthPattern);
            var dmgRegex = new Regex(dmgPattern);

            foreach (var demon in demons)
            {
                double demonHealth = GetDemonHealth(demon);
                decimal demonDamage = GetDemonDamage(demon);
                Console.WriteLine($"{demon} - {demonHealth} health, {demonDamage:f2} damage");
            }


            
        }

        private static double GetDemonHealth(string demon)
        {
            string demonHealthPattern = @"[^\d\.\+\-\*\/\s\,]";
            Regex regex = new Regex(demonHealthPattern);
            MatchCollection collection = regex.Matches(demon);
            double health = 0;
            foreach (Match str in collection)
            {
                foreach (char c in str.ToString())
                {
                    health += (int)c;
                }
            }
            return health;
        }

        private static decimal GetDemonDamage(string demon)
        {
            string demonDamagePattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
            Regex regex = new Regex(demonDamagePattern);
            MatchCollection collection = regex.Matches(demon);
            decimal dmg = 0;
            foreach (var number in collection)
            {
                dmg += decimal.Parse(number.ToString());
            }

            foreach (char c in demon.Where(c=>c=='*'||c=='/'))
            {
                if (c=='*')
                {
                    dmg *= 2;
                }
                else
                {
                    dmg /= 2;
                }
            }
            return dmg;
        }
    }
}
