using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace PagesAndDispatcherTimer
{
    public class TimeController : DispatcherTimer
    {
        private readonly TimeModel model = new TimeModel();
        public TimeController(Label timeLabel)
        {
            model.TimeLabel = timeLabel;
        }

        public void UpdateUI()
        {
            Interval = TimeSpan.FromMilliseconds(1);
            Tick += Timer_Tick;
            Start();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            model.TimeLabel.Content = DateTime.Now.ToLongTimeString();
        }
    }
}
