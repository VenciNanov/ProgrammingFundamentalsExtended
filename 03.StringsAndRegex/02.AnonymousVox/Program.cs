﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] placeholders = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"([A-Za-z]+)(.*)(\1)";

            var matches = Regex.Matches(text, pattern);

            int count = 0;
            foreach (Match item in matches)
            {
                string newStr = item.Groups[1] + placeholders[count++] + item.Groups[3];
                text = text.Replace(item.Value, newStr);
            }

            Console.WriteLine(text);
        }
    }
}
