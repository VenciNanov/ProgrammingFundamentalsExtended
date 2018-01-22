using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TravelCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            string inputArgs;

            while ((inputArgs = Console.ReadLine()) != "ready")
            {
                var input = inputArgs.Split(':').ToArray();

                var city = input[0];
                var transport = input[1];

                if (!dict.ContainsKey(city))
                {
                    dict[city] = new Dictionary<string, int>();
                }

                var transportSplited = transport.Split(',').ToArray();

                foreach (var vehicle in transportSplited)
                {
                    var splitedVehicle = vehicle.Split('-').ToArray();
                    var veh = splitedVehicle[0];
                    var capp = int.Parse(splitedVehicle[1]);

                    if (!dict[city].ContainsKey(veh))
                    {
                        dict[city][veh] = capp;
                    }
                    else
                    {
                        dict[city][veh] = capp;
                    }
                }
            }
            var citiesAndTourist = new Dictionary<string, int>();


            while ((inputArgs = Console.ReadLine()) != "travel time!")
            {
                var input = inputArgs.Split().ToArray();

                var city = input[0];
                var tourists = int.Parse(input[1]);

                citiesAndTourist[city] = tourists;
               
            }

            int touristsInCity, sumOfAllppl;

            foreach (var city in citiesAndTourist.Keys)
            {
                touristsInCity = sumOfAllppl = 0;
                touristsInCity = citiesAndTourist[city];
                foreach (var item in dict[city])
                {
                    sumOfAllppl += item.Value;
                }
                if (sumOfAllppl>=touristsInCity)
                {
                    Console.WriteLine($"{city} -> all {touristsInCity} accommodated");
                }
                else if (sumOfAllppl<touristsInCity)
                {
                    Console.WriteLine($"{city} -> all except {touristsInCity-sumOfAllppl} accommodated");
                }
            }


        }
    }
}
