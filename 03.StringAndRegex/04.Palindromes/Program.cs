using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',', '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> palindromes = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                bool isPalindrome = RevereseString(input[i]) == input[i];
                if (isPalindrome==true)
                {
                    palindromes.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(", ",palindromes.Distinct().OrderBy(x=>x).ToList()));


        }
        public static string RevereseString(string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
