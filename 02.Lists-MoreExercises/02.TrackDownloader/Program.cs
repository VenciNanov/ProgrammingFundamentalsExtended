using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> singers = Console.ReadLine().Split(' ').ToList();
            char[] separator = { ' ', ',', '.', '-' };
            List<string> output = new List<string>();

            while (true)
            {
                string fileName = Console.ReadLine();
                if (fileName=="end")
                {
                    break;
                }

                List<string> fileNameWords = fileName.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

                bool contain = false;
                for (int i = 0; i < singers.Count; i++)
                {
                    if (fileName.Contains(singers[i]))
                    {
                        contain = true;
                        break;
                    }

                }
                if (!contain)
                {
                    output.Add(fileName);
                
                }
                
            }
            output.Sort();
            foreach (string word in output)
            {
                Console.WriteLine(word);
            }

            
        }
    }
}
