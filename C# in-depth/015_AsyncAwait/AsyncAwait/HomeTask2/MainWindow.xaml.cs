using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace HomeTask2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        bool isConnectToDatabase = false;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 2);
        }

        private async void Connect_Click(object sender, RoutedEventArgs e)
        {
            if (isConnectToDatabase == false)
            {
                await Task.Delay(3000);
                Text.Text = "Connected to database";
                timer.Start();
                isConnectToDatabase = true;
            }
            else
            {
                Text.Text += "\nAlready connected to database";
            }
        }

        private async void Disable_Click(object sender, RoutedEventArgs e)
        {
            if (isConnectToDatabase == true)
            {
                await Task.Delay(3000);
                Text.Text = "Disconnected from database";
                timer.Stop();
                isConnectToDatabase = false;
            }
            else
            {
                Text.Text += "\nNo opened connections";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Text.Text += "\nData received";
        }
    }
}
