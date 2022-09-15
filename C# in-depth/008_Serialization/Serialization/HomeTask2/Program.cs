using HomeTask1;
using System;
using System.IO;
using System.Xml.Serialization;

// Создайте новое приложение, в котором выполните десериализацию объекта из предыдущего примера.Отобразите состояние объекта на экране. 

namespace HomeTask2
{
    class Program
    {
        static void Main()
        {
            try
            {
                var stream = new FileStream("D:/Study.net/C# in-depth/008_Serialization/Serialization/HomeTask1/bin/Debug/net5.0/Serialized.xml", FileMode.Open);
                var deSerializer = new XmlSerializer(typeof(Product));
                var item = deSerializer.Deserialize(stream) as Product;
                Console.WriteLine("Object deserialized\n");
                Console.WriteLine($"Name - {item.name}");
                Console.WriteLine($"Price = {item.price}");
                Console.WriteLine($"Color - {item.color}");
                Console.WriteLine($"Quantity = {item.quantity}");
                Console.WriteLine($"Total price = {item.total}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
