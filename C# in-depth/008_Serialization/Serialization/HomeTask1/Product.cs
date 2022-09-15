using System.Xml.Serialization;

namespace HomeTask1
{
    [XmlRoot("Product")]
    public class Product
    {
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public decimal price;
        [XmlAttribute]
        public string color;
        [XmlAttribute]
        public int quantity;
        [XmlAttribute]
        public decimal total;

        public Product() { }
    }
}
