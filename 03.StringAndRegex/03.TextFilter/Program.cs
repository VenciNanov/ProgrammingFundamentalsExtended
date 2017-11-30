using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var badword in words)
            {
                var replacement = (new string('*', badword.Length));
                text = text.Replace(badword, replacement);
            }

            Console.WriteLine(text);

        }
    }
}
