using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var num = double.Parse(Console.ReadLine());

            switch (type)
            {
                case "miles":
                    Console.WriteLine($"{num} miles = {num*1.6:f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{num} inches = {num * 2.54:f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{num} feet = {num * 30:f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{num} yards = {num * 0.91:f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{num} gallons = {num * 3.8:f2} liters");
                    break;


            }
        }
    }
}
