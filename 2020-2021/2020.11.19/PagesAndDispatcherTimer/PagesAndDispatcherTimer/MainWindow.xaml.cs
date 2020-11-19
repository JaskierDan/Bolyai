using System.Windows;

namespace PagesAndDispatcherTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Page1 page1 = new Page1();
        private TimeController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new TimeController(ClockLabel);
            controller.UpdateUI();
            MainFrame.Navigate(page1);
        }
    }
}
