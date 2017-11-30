using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(<\[[^a-zA-Z0-9\n]*]\.)(\.\[[a-zA-Z0-9]*]\.)*$";
            string input = Console.ReadLine();

            RegexOptions options = RegexOptions.Multiline;
            while (input != "Traincode!")
            {
                foreach (Match m in Regex.Matches(input, pattern, options))
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }


        }
    }
}
