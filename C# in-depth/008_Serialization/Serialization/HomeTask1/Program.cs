using System;
using System.IO;
using System.Xml.Serialization;

namespace HomeTask1
{
    class Program
    {
        static void Main()
        {
            var item = new Product();
            item.name = "computer";
            item.price = 468;
            item.color = "black";
            item.quantity = 3;
            item.total = item.price * item.quantity;

            var stream = new FileStream("Serialized.xml", FileMode.Create);
            var serializer = new XmlSerializer(typeof(Product));
            serializer.Serialize(stream, item);
            Console.WriteLine("Object serialized");
            stream.Close();

            Console.ReadKey();
        }
    }
}
