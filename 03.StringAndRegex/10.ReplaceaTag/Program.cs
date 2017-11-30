using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.ReplaceaTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var replacement = @"[URL href=$1]$2[/URL]";

                var replaced = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(replaced);

                text = Console.ReadLine();

            }
        }
    }
}
