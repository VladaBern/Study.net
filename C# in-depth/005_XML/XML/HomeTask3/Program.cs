using Microsoft.Win32;
using System;
using System.Configuration;

namespace HomeTask3
{
    internal class Program
    {
        static Settings CreateSettings()
        {
            Console.WriteLine("Enter foreground color: ");
            Enum.TryParse(Console.ReadLine(), true, out ConsoleColor foregroundColor);
            Console.WriteLine("Enter background color: ");
            Enum.TryParse(Console.ReadLine(), true, out ConsoleColor backgroundColor);
            Console.WriteLine("Enter cursor size: ");
            int cursorSize = Convert.ToInt32(Console.ReadLine());

            return new Settings(foregroundColor, backgroundColor, cursorSize);
        }

        static void SaveConfiguration()
        {
            var settings = CreateSettings();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["foregroundColor"].Value = settings.ForegroundColor.ToString();
            config.AppSettings.Settings["backgroundColor"].Value = settings.BackgroundColor.ToString();
            config.AppSettings.Settings["cursorSize"].Value = settings.СursorSize.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            Console.WriteLine("Settings saved to file!");
        }

        static void SaveRegistry()
        {
            var settings = CreateSettings();
            var key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey("Software", true);
            RegistryKey subSubKey = subKey.CreateSubKey("StudyRegistry");
            subSubKey.SetValue("foregroundColor", settings.ForegroundColor.ToString());
            subSubKey.SetValue("backgroundColor", settings.BackgroundColor.ToString());
            subSubKey.SetValue("cursorSize", settings.СursorSize.ToString());
            subKey.Close();
            subSubKey.Close();

            Console.WriteLine("Settings saved to registry!");
        }

        static void LoadConfiguration()
        {
            Enum.TryParse(ConfigurationManager.AppSettings["foregroundColor"], true, out ConsoleColor foregroundColor);
            Console.ForegroundColor = foregroundColor;
            Enum.TryParse(ConfigurationManager.AppSettings["backgroundColor"], true, out ConsoleColor backgroundColor);
            Console.BackgroundColor = backgroundColor;
            Console.CursorSize = Convert.ToInt32(ConfigurationManager.AppSettings["cursorSize"]);

            Console.WriteLine("Settings loaded from file!");
        }

        static void LoadRegistry()
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey(@"Software\StudyRegistry");

            if (subKey == null)
            {
                Console.WriteLine("There are not settings in registry");
            }
            else
            {
                Enum.TryParse(subKey.GetValue("foregroundColor") as string, true, out ConsoleColor foregroundColor);
                Console.ForegroundColor = foregroundColor;
                Enum.TryParse(subKey.GetValue("backgroundColor") as string, true, out ConsoleColor backgroundColor);
                Console.BackgroundColor = backgroundColor;
                Console.CursorSize = Convert.ToInt32(subKey.GetValue("cursorSize"));

                Console.WriteLine("Settings loaded from registry!");
            }                        
        }

        static void ShowTheText(string text)
        {
            Console.WriteLine(text);
        }

        static void Main(string[] args)
        {            
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1.Save configuration to file.\n2.Save to registry.\n3.Load configuration from file." +
                "\n4.Load configuration from registry.\n5.Show the text.");

                Console.WriteLine("Enter number of command:");
                int command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        {
                            SaveConfiguration();
                            break;
                        }
                    case 2:
                        {
                            SaveRegistry();
                            break;
                        }
                    case 3:
                        {
                            LoadConfiguration();
                            break;
                        }
                    case 4:
                        {
                            LoadRegistry();
                            break;
                        }
                    case 5:
                        {
                            ShowTheText(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter another command!");
                            break;
                        }
                }

                Console.ReadKey();
            }                        
        }
    }
}
