using System.IO;

namespace HomeTask1
{
    internal class Read
    {
        private string path;

        public Read(string path)
        {
            this.path = path;
        }

        public string ReadContent()
        {
            FileStream file = File.Open(path, FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(file);

            string result = reader.ReadToEnd();

            reader.Dispose();

            return result;
        }
    }
}
