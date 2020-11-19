using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PagesAndDispatcherTimer
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void ToPage1_Click(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            NavigationService.Navigate(page1);
        }
    }
}
