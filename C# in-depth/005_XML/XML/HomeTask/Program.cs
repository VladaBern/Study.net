using System;
using System.Xml;

namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);

            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.IndentChar = '\t';
            xmlWriter.Indentation = 1;

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("+123456789");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Vlada");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("+54987321");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Roman");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("+789654123");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Ann");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            Console.WriteLine("File created!");

            var reader = new XmlTextReader("TelephoneBook.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name.Equals("Contact"))
                    {
                        Console.WriteLine("Number : {0}", reader.GetAttribute("TelephoneNumber"));
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
