using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();

            string inputArgs;

            while ((inputArgs = Console.ReadLine()) != "login")
            {
                var input = inputArgs.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var username = input[0];
                var password = input[1];

                if (!users.ContainsKey(username))
                {
                    users[username] = password;
                }
                users[username] = password;


            }
            var counter = 0;
            while ((inputArgs = Console.ReadLine()) != "end")
            {
                var input = inputArgs.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var username = input[0];
                var password = input[1];

                if (users.ContainsKey(username) && users.ContainsValue(password))
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                else
                {
                    counter++;
                    Console.WriteLine($"{username}: login failed");
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"unsuccessful login attempts: {counter}");
            }

        }
    }
}
