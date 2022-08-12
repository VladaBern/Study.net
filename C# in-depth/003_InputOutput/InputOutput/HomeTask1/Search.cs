using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HomeTask1
{
    internal class Search
    {
        private string name;

        public Search(string name)
        {
            this.name = name;
        }

        public List<string> SearchPath()
        {
            var files = new List<string>();

            foreach (DriveInfo d in DriveInfo.GetDrives().Where(x => x.IsReady == true && x.Name == @"F:\"))
            {
                files.AddRange(Directory.GetFiles(d.RootDirectory.FullName, name, SearchOption.TopDirectoryOnly));

                foreach (DirectoryInfo info in d.RootDirectory.EnumerateDirectories())
                {
                    try
                    {
                        files.AddRange(Directory.GetFiles(info.FullName, name, SearchOption.AllDirectories));
                    }
                    catch { }
                }
            }

            return files;
        }
    }
}
