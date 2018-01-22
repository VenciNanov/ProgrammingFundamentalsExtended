using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictTags = new Dictionary<string, HashSet<string>>();

            string inputArgs;

            while ((inputArgs = Console.ReadLine()) != "filter")
            {
                var input = inputArgs.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var topic = input[0];
                var tags = input[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!dictTags.ContainsKey(topic))
                {
                    dictTags[topic] = new HashSet<string>();

                }
                tags.ForEach(t => dictTags[topic].Add(t));


            }
            var filter = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            dictTags.Values.Distinct();
            foreach (var tag in dictTags)
            {
                var topicTags = tag.Value;
                bool hasAllTags = CheckForTags(filter, topicTags);
                if (hasAllTags)
                {
                    Console.WriteLine($"{tag.Key} | {string.Join(", ",topicTags.Select(t=>$"#{t}"))}");
                }
                
            }
        }
        public static bool CheckForTags(List<string> inputTags,HashSet<string> topicTags)
        {
            bool hasAllTags = true;
            foreach (var tag in inputTags)
            {
                if (!topicTags.Contains(tag))
                {
                    hasAllTags = false;
                    break;
                }
            }
            return hasAllTags;
        }
    }
}
