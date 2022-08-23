using System;
using System.Text.RegularExpressions;

namespace HomeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(без|безо|близ|в|во|вместо|вне|для|до|за|из|изо|из-за|из-под|к|ко|кроме|между" +
                @"|меж|на|над|надо|о|об|обо|от|ото|перед|передо|пред|предо|пo|под|подо|при|про|ради|с|со|сквозь|среди|у|через|чрез)\b";
            Console.WriteLine("Введите текст: ");
            var text = Console.ReadLine();

            Console.WriteLine(Regex.Replace(text, pattern, "ГАВ!", RegexOptions.IgnoreCase));

            Console.ReadKey();
        }
    }
}
