using System;
using System.IO;
using System.Xml;

namespace HomeTask2
{
    internal class Program
    {
        static void ReadXml(string path)
        {         
            FileStream stream = new FileStream(path, FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(stream);

            while (xmlReader.Read())
            {
                Console.WriteLine("{0} {1} {2}", xmlReader.NodeType, xmlReader.Name, xmlReader.Value);

                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.HasAttributes)
                    {
                        while (xmlReader.MoveToNextAttribute())
                        {
                            Console.WriteLine(xmlReader.Name + " = " + xmlReader.Value);
                        }
                    }
                }
            }

            xmlReader.Close();
            stream.Close();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a path to file");
            string path = Console.ReadLine();

            Console.WriteLine("\n");

            ReadXml(path);

            Console.ReadKey();
        }
    }
}
