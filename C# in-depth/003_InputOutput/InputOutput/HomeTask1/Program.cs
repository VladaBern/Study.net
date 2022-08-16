using System;

namespace HomeTask1
{
    internal class Program
    {
        public static void Search()
        {
            Console.WriteLine("Enter the name of searching file");
            string fileName = Console.ReadLine();
            Search search = new Search(fileName);
            var pathes = search.SearchPath();
            if (pathes.Count == 0)
            {
                Console.WriteLine("File not found");
            }
            else
            {
                foreach (var path in pathes)
                    Console.WriteLine(path);
            }
        }

        public static void Read()
        {
            Console.WriteLine("Enter the path to file for reading");
            string filePath = Console.ReadLine();
            Read read = new Read(filePath);
            Console.WriteLine(read.ReadContent());
        }

        public static void Compress()
        {
            Console.WriteLine("Enter the path to file for compressing");
            string filePath = Console.ReadLine();
            Compress compress = new Compress(filePath);
            compress.CompressFile();
            Console.WriteLine("Compression completed");
        }

        public static void Decompress()
        {
            Console.WriteLine("Enter the path to file for decompressing");
            string filePath = Console.ReadLine();
            Decompress decompress = new Decompress(filePath);
            decompress.DecompressFile();
            Console.WriteLine("Decompression completed");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a command : ");
            var command = Console.ReadLine();

            switch (command)
            {
                case "search":
                    {
                        Search();                        
                        break;
                    }
                case "read":
                    {
                        Read();
                        break;
                    }
                case "compress":
                    {
                        Compress();
                        break;
                    }
                case "decompress":
                    {
                        Decompress();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter another command");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
