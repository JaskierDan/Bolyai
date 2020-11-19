using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PagesAndDispatcherTimer
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void ToPage2_Click(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
            NavigationService.Navigate(page2);
        }
    }
}
