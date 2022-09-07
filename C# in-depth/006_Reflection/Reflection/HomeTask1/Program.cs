using System;
using System.IO;
using System.Reflection;

namespace HomeTask1
{
    class Program
    {
        static void GetInfo(Assembly assembly)
        {
            Console.WriteLine("\nFull name : {0}", assembly.FullName);
            Console.WriteLine("Is fully trusted : {0}", assembly.IsFullyTrusted);
        }

        static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine("Types in {0}:\n", assembly.FullName);

            var types = assembly.GetTypes();

            foreach (var type in types)
                Console.WriteLine("Type - {0}", type);
        }

        static void Main()
        {
            Assembly assembly = null;

            Console.WriteLine("Enter a path to assembly");
            string path = Console.ReadLine();

            try
            {
                assembly = Assembly.LoadFrom(path);
                Console.WriteLine("\nAssembly loaded successfully!");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            GetInfo(assembly);

            Console.WriteLine(new string('-', 25));

            ListAllTypes(assembly);

            Console.ReadKey();
        }
    }
}
