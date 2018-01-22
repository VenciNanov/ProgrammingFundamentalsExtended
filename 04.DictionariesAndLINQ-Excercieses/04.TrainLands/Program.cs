using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrainLands
{
    class Program
    {
        static void Main(string[] args)
        {

            var trains = new Dictionary<string, Dictionary<string, long>>();

            string str;

            while ((str = Console.ReadLine()) != "It's Training Men!")
            {
                bool flag = false;
                if (str.IndexOf('=') != -1)
                {
                    flag = true;
                }

                var input = str.Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);



                if (input.Length > 2)
                {
                    string trainName = input[0];
                    string wagonName = input[1];
                    long wagonPower = long.Parse(input[2]);

                    if (trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, long>());
                    }
                    trains[trainName][wagonName] = wagonPower;
                }
                else
                {
                    string trainName = input[0];
                    string otherTrainName = input[1];

                   
                    if (flag)
                    {
                        trains.Remove(trainName);
                    }
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, long>());
                    }

                    foreach (var item in trains[otherTrainName])
                    {
                        trains[item.Key].Add(item.Key, item.Value);
                    }

                    if (!flag)
                    {
                        trains.Remove(otherTrainName);
                    }
                }

                foreach (var item in trains.OrderByDescending(x=>x.Value.Sum(e=>e.Value)).OrderBy(k=>k.Value.Count))
                {
                    Console.WriteLine($"Train: {item.Key}");

                    foreach (var inner in item.Value.OrderByDescending(x=>x.Value))
                    {
                        Console.WriteLine($"###{inner.Key} - {inner.Value}");
                    }

                }


            }
        }
    }
}
