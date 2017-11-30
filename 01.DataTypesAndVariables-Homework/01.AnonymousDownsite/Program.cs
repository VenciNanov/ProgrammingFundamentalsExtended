using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            List<string> sites = new List<string>();
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                var site = input[0];
                var siteVisits = decimal.Parse(input[1]);
                var commercials = decimal.Parse(input[2]);

                sites.Add(site);
                sum += (siteVisits * commercials);
            }
            foreach (var site in sites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {sum:f20}");
            BigInteger tokens = BigInteger.Pow(securityKey, sites.Count);
            Console.WriteLine($"Security Token: {tokens}");


        }
    }
}
