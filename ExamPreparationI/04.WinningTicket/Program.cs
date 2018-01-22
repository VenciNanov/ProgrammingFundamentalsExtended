using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var jackpotPattern = @"(@){20}|(\$){20}|(\^){20}|(#){20}";
            var normalPattern = @"((@){6,9}|(\$){6,9}|(#){6,9}|(\^){6,9})";

            var nomalRegex = new Regex(normalPattern);
            var jacpotRegex = new Regex(jackpotPattern);

            for (int i = 0; i < tickets.Length ; i++)
            {
                var ticket = tickets[i];

                if (ticket.Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                if (jacpotRegex.IsMatch(ticket))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[1]} Jackpot!");
                    continue;
                }


                var firtsHalf = ticket.Substring(9);
                var secondHalf = ticket.Substring(0, 10);

                if (nomalRegex.IsMatch(firtsHalf)&&nomalRegex.IsMatch(secondHalf))
                {
                    var firstMatch = nomalRegex.Match(firtsHalf).ToString();
                    var secondMatch = nomalRegex.Match(secondHalf).ToString();

                    if (firstMatch == secondMatch)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {firstMatch.Length}{firstMatch[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }


            }

        }
    }
}
