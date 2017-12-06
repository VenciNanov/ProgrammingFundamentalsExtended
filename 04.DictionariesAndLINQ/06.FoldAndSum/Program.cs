using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int token= (input.Count/2)/2;

            var leftHalfList = new List<int>(input.Take(token).Reverse());

            var rightHalfList = new List<int>(input.Skip(input.Count-token).Take(token).Reverse());

            List<int> firstRow = new List<int>(leftHalfList.Concat(rightHalfList));
            List<int> secondRow = new List<int>(input.Skip(token).Take(input.Count / 2));

           
            
               var sum = firstRow.Select((x, index) => x + secondRow[index]).ToList();
            
            Console.WriteLine(string.Join(" ",sum));

        }
    }
}
