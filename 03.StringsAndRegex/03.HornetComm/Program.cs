using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<string> broadcasts = new List<string>();
            List<string> messages = new List<string>();

            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                string[] inputParams = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputParams.Length!=2)
                {
                    continue;
                }

                bool isMessage = true;
                bool isBroadcast = true;


                foreach (char c in inputParams[0])
                {
                    if (!char.IsDigit(c))
                    {
                        isMessage = false;
                        break;
                    }
                }


                foreach (char c in inputParams[1])
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        isMessage = false;
                        isBroadcast = false;
                        break;
                    }
                }


                foreach (char c in inputParams[0])
                {
                    if (char.IsDigit(c))
                    {
                        isBroadcast = false;
                        break;
                    }
                }

                if (isMessage)
                {
                    var messageRecipient = RevereseString(inputParams[0]);
                    messages.Add(messageRecipient + " -> " + inputParams[1]);
                    continue;
                }

                if (isBroadcast)
                {
                    char[] frequency = new char[inputParams[1].Length];

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        char current = inputParams[1][i];
                        if (char.IsLetter(current))
                        {
                            if (char.IsUpper(current))
                            {
                                current += (char)32;
                            }
                            else
                            {
                                current -= (char)32;
                            }
                        }
                        frequency[i] = current;
                    }
                    broadcasts.Add(string.Join("", frequency) + " -> " + inputParams[0]);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count>0)
            {
                foreach (var cast in broadcasts)
                {
                    Console.WriteLine(cast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count>0)
            {
                foreach (var msg in messages)
                {
                    Console.WriteLine(msg);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
        public static string RevereseString(string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
