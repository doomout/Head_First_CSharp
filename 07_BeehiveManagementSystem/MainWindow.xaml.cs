using System;
using System.Windows;
using System.Windows.Threading;

namespace _07_BeehiveManagementSystem
{
    public partial class MainWindow : Window
    {
        private readonly Queen queen;
        //private Queen queen = new Queen();
        private DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            //statusReport.Text = queen.StatusReport;
            queen = Resources["queen"] as Queen; //데이터 바인딩 사용
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1.5);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            WorkShift_Click(this, new RoutedEventArgs());
        }

        private void AssignJob_Click(object sender, RoutedEventArgs e)
        {
            queen.AssignBee(jobSelector.Text);
            //statusReport.Text = queen.StatusReport;
        }

        private void WorkShift_Click(object sender, RoutedEventArgs e)
        {
            queen.WorkTheNextShift();
            //statusReport.Text = queen.StatusReport;
        }
    }
}
