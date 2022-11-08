using System;
using System.IO;
using System.Windows;
using System.Windows.Threading;

namespace HomeTask2.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DeletedFiles.Text = File.ReadAllText("F:/log.txt");
        }
    }
}
