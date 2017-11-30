using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split();

            var temp = inputArr[inputArr.Length-1];

            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                var element = inputArr[i];
                inputArr[i] = inputArr[i + 1];
                inputArr[i+1] = element;

            }
            inputArr[0] = temp;
            Console.WriteLine(string.Join(" ",inputArr));
        }
    }
}
