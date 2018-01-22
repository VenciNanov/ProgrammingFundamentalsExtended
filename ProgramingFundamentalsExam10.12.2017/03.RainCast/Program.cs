using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RainCast
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            var foreCastList = new List<string>();

            var forecastInvalidChars = new List<char>(new char[] { '!', '.', ',', '?' });


            while ((str = Console.ReadLine()) != "Davai Emo")
            {
                var input = str;

                foreCastList.Add(input);
            }

            var typeDone = false;
            var sourceDone = false;
            var forecastDone = false;

            StringBuilder sb = new StringBuilder();
            StringBuilder placeholder = new StringBuilder();

            foreach (var forecast in foreCastList)
            {
               
                var splited = forecast.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);

                var token = splited[0];
                var token2 = splited[1];

                if (!typeDone && !sourceDone && !forecastDone)
                {
                    if (token == "Type" && (token2 == "Normal" || token2 == "Warning" || token2 == "Danger"))
                    {
                        sb.Append("(" + token2 + ") ");
                        typeDone = true;
                    }
                }
                if (typeDone&&!sourceDone && !forecastDone)
                {
                   var isAlpha = IsAlphaNumeric(token2);
                    if (token=="Source"&&isAlpha)
                    {
                        // Console.Write($"{token2} ~ ");
                        placeholder.Append(" ~ " + token2);
                        sourceDone = true;
                    }
                }
                if (typeDone && sourceDone && !forecastDone)
                {
                    if (token=="Forecast"&&!token.Any(s=>forecastInvalidChars.Contains(s)))
                    {
                        //Console.WriteLine($"{token2}");
                        sb.Append(token2);
                        typeDone = false;
                        sourceDone = false;
                        forecastDone = false;
                        sb.Append(placeholder);
                        Console.WriteLine(sb);
                        placeholder.Clear();
                        sb.Clear();
                    }
                }
            }
        }
        public static Boolean IsAlphaNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");
            return rg.IsMatch(strToCheck);
        }
    }
    
}
