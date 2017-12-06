using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var name = input[0];
                var grade = double.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }
            foreach (var pair in grades)
            {
                var name = pair.Key;
                var grade = pair.Value;

                var avg = grade.Average();

                Console.Write($"{name} -> ");

                foreach (var gr in grade)
                {
                    Console.Write($"{gr:f2} ");
                }
                Console.WriteLine($"(avg: {avg:f2})");
            }

        }
    }
}
