using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string input = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(input, pattern);


            foreach (Match m in matchedNames)
            {
                Console.Write(m.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
