using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfGyak3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connection conn = new Connection();
        public MainWindow()
        {
            InitializeComponent();
            conn.FillListBox(lb);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewSpecies winform = new NewSpecies();
            winform.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewAnimal winform = new NewAnimal();
            winform.ShowDialog();
            lb.ItemsSource = null;
            conn.FillListBox(lb);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            conn.DeleteAnimal(lb);
            lb.ItemsSource = null;
            conn.FillListBox(lb);
        }
    }
}
