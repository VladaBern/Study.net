using System.IO;
using System.ServiceProcess;

namespace HomeTask2.Service
{
    public partial class Service1 : ServiceBase
    {
        FileSystemWatcher watcher;

        public Service1()
        {
            InitializeComponent();

            watcher = new FileSystemWatcher(@"D:\");
            watcher.Deleted += WatcherChanged;
        }

        void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            File.AppendAllLines(@"F:\Log.txt", new string[] { e.FullPath });
        }

        protected override void OnStart(string[] args)
        {
            watcher.EnableRaisingEvents = true;
        }

        protected override void OnStop()
        {
            watcher.EnableRaisingEvents = false;
        }
    }
}
