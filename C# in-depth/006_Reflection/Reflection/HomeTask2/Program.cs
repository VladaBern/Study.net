using System;
using System.IO;
using System.Reflection;

namespace HomeTask2
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("Temperature");
                Console.WriteLine(assembly.FullName + " loaded");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("What operation do you want to do?\n1.Convert celsius to fahrenheit.\n2.Convert fahrenheit to celsius.");
            int operation = Convert.ToInt32(Console.ReadLine());
            
            switch (operation)
            {
                case 1:
                    {
                        Convertation(assembly, "ConvertToFahrenheit");
                        break;
                    }
                case 2:
                    {
                        Convertation(assembly, "ConvertToCelsius");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Command is invalid");
                        break;
                    }
            }

            Console.ReadKey();
        }

        static void Convertation(Assembly assembly, string operation)
        {
            Console.WriteLine("Enter degrees:");
            double degrees = Convert.ToDouble(Console.ReadLine());
            Type type = assembly.GetType("Temperature.Temperature");
            object instance = Activator.CreateInstance(type, degrees);

            MethodInfo method = type.GetMethod(operation);

            if (operation == "ConvertToFahrenheit")
            {
                Console.WriteLine($"Temperature = {method.Invoke(instance, null)} F");
            }
            else
            {
                Console.WriteLine($"Temperature = {method.Invoke(instance, null)} C");
            }
        }
    }
}
