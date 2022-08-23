using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace HomeTask4
{
    internal class Program
    {
        static void ShowReceive(CultureInfo cultureInfo, string[] lines)
        {
            var regex = new Regex(@"\d+\,\d{2}");

            for (int i = 0; i < lines.Length - 1; i++)
            {
                var cost = Convert.ToDecimal(regex.Match(lines[i]).Value);

                string line = lines[i];
                line = regex.Replace(line, "");
                Console.WriteLine(line + cost.ToString("C", cultureInfo));
            }

            var date = Convert.ToDateTime(lines[lines.Length - 1], CultureInfo.CurrentCulture.DateTimeFormat);
            Console.WriteLine(date.ToString("D", cultureInfo));
        }

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("receive.txt");
            
            ShowReceive(CultureInfo.CurrentCulture, lines);

            Console.WriteLine(new String('-', 25));

            ShowReceive(CultureInfo.GetCultureInfo("en-US"), lines);

            Console.ReadKey();
        }
    }
}
