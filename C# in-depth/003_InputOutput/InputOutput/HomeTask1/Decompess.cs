using System.IO;
using System.IO.Compression;

namespace HomeTask1
{
    internal class Decompress
    {
        private string path;

        public Decompress(string path)
        {
            this.path = path;
        }

        public void DecompressFile()
        {
            FileStream source = File.OpenRead(path);
            FileStream destination = File.Create(@"F:\text_decompress.txt");

            DeflateStream decompressor = new DeflateStream(source, CompressionMode.Decompress);

            int theByte = decompressor.ReadByte();
            while (theByte != -1)
            {
                destination.WriteByte((byte)theByte);
                theByte = decompressor.ReadByte();
            }

            decompressor.Dispose();
            destination.Dispose();
            source.Dispose();
        }
    }
}
