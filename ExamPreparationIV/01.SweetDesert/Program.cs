using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggsPrice = double.Parse(Console.ReadLine());
            var berriesPricePerKilo = double.Parse(Console.ReadLine());



            var sets = 0;
            if (guests > 0)
            {
                sets = 1;


                //int numberOfGuests = guests;

                while (guests > 6)
                {
                    sets++;
                    guests = guests - 6;
                }
            }
            double pricePerSet = 2 * bananaPrice + 4 * eggsPrice + 0.2 * berriesPricePerKilo;
            double total = sets * pricePerSet;

            if (cash >= total)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {total - cash:f2}lv more.");
            }
        }
    }
}
