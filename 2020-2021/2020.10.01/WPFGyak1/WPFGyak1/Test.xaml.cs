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
using System.Windows.Shapes;

namespace WPFGyak1
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        private Connection conn = new Connection();

        public Test()
        {
            InitializeComponent();
            conn.FillListBox(lb1);
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            conn.Insert(Text1);
            Text1.Text = "";
            lb1.ItemsSource = null;
            conn.FillListBox(lb1);
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            conn.Delete(lb1);
            lb1.ItemsSource = null;
            conn.FillListBox(lb1);
        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            conn.Update(lb1, Update_Text);
            lb1.ItemsSource = null;
            conn.FillListBox(lb1);
        }
    }
}
