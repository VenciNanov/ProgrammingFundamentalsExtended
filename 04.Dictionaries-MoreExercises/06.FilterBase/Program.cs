using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageDict = new Dictionary<string, int>();
            var salaryDict = new Dictionary<string, double>();
            var positionDict = new Dictionary<string, string>();

            string str;

            while ((str = Console.ReadLine()) != "filter base")
            {
                var input = str.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];

                var parsedAge = 0;
                bool isAge = int.TryParse(input[1], out parsedAge);
                var parsedSalary = 0.0;
                var isSalary = double.TryParse(input[1], out parsedSalary);

                if (isAge)
                {
                    ageDict[name] = parsedAge;
                }
                else if (isSalary)
                {
                    salaryDict[name] = parsedSalary;
                }
                else
                {
                    positionDict[name] = input[1];
                }
            }

            var inputA = Console.ReadLine();

            if (inputA == "Age")
            {
                foreach (var person in ageDict)
                {
                    Console.WriteLine($"Name: {person.Key}");
                    Console.WriteLine($"Age: {person.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (inputA == "Salary")
            {
                foreach (var person in salaryDict)
                {
                    Console.WriteLine($"Name: {person.Key}");
                    Console.WriteLine($"Salary: {person.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (var person in positionDict)
                {
                    Console.WriteLine($"Name: {person.Key}");
                    Console.WriteLine($"Position: {person.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }




        }
    }
}
