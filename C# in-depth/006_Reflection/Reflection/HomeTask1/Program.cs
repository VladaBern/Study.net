using System;
using System.Collections.Generic;
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

        static void ListAllTypes(Assembly assembly, List<MemberTypes> members)
        {
            Console.WriteLine("Types in {0}:\n", assembly.FullName);

            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine("{0}:", type);

                var attributes = type.GetCustomAttributes(true);
                if (attributes != null && attributes.Length != 0)
                    Console.WriteLine("\nAttributes:");

                foreach (var attribute in attributes)
                {
                    Console.WriteLine(attribute.GetType().Name);
                }

                foreach (var member in type.GetMembers(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance))
                {
                    if (members.Contains(member.MemberType))
                    {
                        Console.WriteLine($"\n{member.MemberType} - {member.Name}");
                        var memberAttributes = member.GetCustomAttributes(true);
                        if (memberAttributes != null && memberAttributes.Length != 0)
                            Console.WriteLine("\nAttributes:");

                        foreach (var attribute in memberAttributes)
                        {
                            Console.WriteLine(attribute.GetType().Name);
                        }
                    }
                }
            }
        }

        static List<MemberTypes> ConvertToEnum(string membersLine)
        {
            List<MemberTypes> members = new List<MemberTypes>();
            
            foreach (var member in membersLine.Split(" "))
            {
                object type;
                if (Enum.TryParse(typeof(MemberTypes), member, true, out type))
                {
                    members.Add((MemberTypes)type);
                }
            }

            return members;
        }

        static void Main()
        {
            Assembly assembly = null;

            Console.WriteLine("Enter a path to assembly");
            string path = Console.ReadLine();

            Console.WriteLine("Enter members");
            string membersLine = Console.ReadLine();                      
            
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

            ListAllTypes(assembly, ConvertToEnum(membersLine));

            Console.ReadKey();
        }
    }
}
