﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] revesrse = input.ToCharArray();
            Array.Reverse(revesrse);
            Console.WriteLine(revesrse);
        }
    }
}
