using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, long>();

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0]=="Over")
                {
                    break;
                }
                var name = input[0];
                var phone = input[1];

                long phone2 =0;
                var isDigit = long.TryParse(name, out phone2);

                if (isDigit)
                {
                    phoneBook[phone] = phone2;
                }
                else
                {

                    phoneBook[name] = long.Parse(phone);
                }

            }
            foreach (var phone in phoneBook)
            {
                Console.WriteLine($"{phone.Key} -> {phone.Value}");
            }
        }
    }
}
