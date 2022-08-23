using System;
using System.Text.RegularExpressions;
using System.Net;
using System.Collections.Generic;
using System.IO;

namespace HomeTask2
{
    internal class Program
    {
        static void Main()
        {
            WebClient client = new WebClient();
            string htmlCode = client.DownloadString("https://blog.onliner.by/about");
            client.Dispose();

            string patternReference = @"<a href=""(?<link>\S+)""";
            string patternNumber = @"\+375\s*\(*[0-9]{2}\)*\s*\d{3}\s*\-*\s*\d{2}\s*\-*\s*\d{2}";
            string patternMail = @"[0-9A-Za-z.-]+@[a-zA-Z-]+\.[a-zA-Z]{2,4}";

            var regexReference = new Regex(patternReference);
            var regexNumber = new Regex(patternNumber);
            var regexMail = new Regex(patternMail);

            List<string> result = new List<string>();

            foreach (Match match in regexReference.Matches(htmlCode))
            {
                result.Add(match.Groups["link"].Value);
            }

            foreach (Match match in regexNumber.Matches(htmlCode))
            {
                result.Add(match.Groups[0].Value);
            }

            foreach (Match match in regexMail.Matches(htmlCode))
            {
                result.Add(match.Groups[0].Value);
            }

            File.AppendAllLines("result.txt", result);

            Console.WriteLine("Search completed");
            
            Console.ReadKey();
        }
    }
}
