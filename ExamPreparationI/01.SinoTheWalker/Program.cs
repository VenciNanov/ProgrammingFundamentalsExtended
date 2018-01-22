using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputTime = Console.ReadLine();
            var numberOfSteps = int.Parse(Console.ReadLine())%86400;
            var timeForStepInSeconds = int.Parse(Console.ReadLine())%86400;

            var secondsToGoHome = numberOfSteps * timeForStepInSeconds;

            var timeParsed = TimeSpan.Parse(inputTime);

            var finishTime = timeParsed.Add(TimeSpan.FromSeconds(timeForStepInSeconds));

            Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}",finishTime);
        }
    }
}
