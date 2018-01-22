using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Key_KeyValue_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            var inputKey = Console.ReadLine();
            var inputValue = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var key = input[0];
                var values = input[1];

                if (key.Contains(inputKey))
                {
                    dict[key] = new List<string>();

                    var valuesSplit = values.Split(';').ToArray();
                    foreach (var item in valuesSplit)
                    {
                        if (item.Contains(inputValue))
                        {
                            dict[key].Add(item);
                        }
                    }
                }
            }
            foreach (var key in dict)
            {
                Console.WriteLine($"{key.Key}:");
                foreach (var value in key.Value)
                {
                    if (value.Contains(inputValue))
                    {
                        Console.WriteLine($"-{value}");
                    }
                   
                }
            }
        }
    }
}
