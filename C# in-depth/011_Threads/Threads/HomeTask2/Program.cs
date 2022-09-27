using System;
using System.IO;
using System.Threading;

namespace HomeTask2
{
    class PathInfo
    {
        public string ReadPath { get; }
        public string WritePath { get; }
        public PathInfo(string readPath, string writePath)
        {
            ReadPath = readPath;
            WritePath = writePath;
        }
    }

    class Program
    {
        static object block = new object();

        static string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }

        static void WriteFile(string text, string path)
        {
            lock (block)
            {
                File.AppendAllText(path, text);
            }
        }

        static void Procedure(object path)
        {
            if (path is PathInfo pathInfo)
            {
                WriteFile(ReadFile(pathInfo.ReadPath), pathInfo.WritePath);
            }
        }

        static void Main()
        {
            Thread thread = new Thread(Procedure);
            Thread thread2 = new Thread(Procedure);

            thread.Start(new PathInfo("TextFile1.txt", "result.txt"));
            thread2.Start(new PathInfo("TextFile2.txt", "result.txt"));

            Console.WriteLine("File is written");
        }
    }
}
