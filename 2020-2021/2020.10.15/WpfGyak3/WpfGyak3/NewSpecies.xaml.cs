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

namespace WpfGyak3
{
    /// <summary>
    /// Interaction logic for NewSpecies.xaml
    /// </summary>
    public partial class NewSpecies : Window
    {
        Connection conn = new Connection();
        public NewSpecies()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conn.Insert("species", species);
            this.Close();
        }
    }
}
