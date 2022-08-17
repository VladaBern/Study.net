using System.IO;
using System.IO.Compression;

namespace HomeTask1
{
    internal class Compress
    {
        private string path;
         
        public Compress(string path)
        {
            this.path = path;
        }

        public void CompressFile()
        {
            FileStream source = File.OpenRead(path);
            FileStream destination = File.Create(@"F:\archive.dfl");

            DeflateStream compressor = new DeflateStream(destination, CompressionMode.Compress);

            int theByte = source.ReadByte();
            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = source.ReadByte();
            }

            compressor.Dispose();
            destination.Dispose();
            source.Dispose();
        }
    }
}
