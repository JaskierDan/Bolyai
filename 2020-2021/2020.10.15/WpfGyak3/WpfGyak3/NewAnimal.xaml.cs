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
    /// Interaction logic for NewAnimal.xaml
    /// </summary>
    public partial class NewAnimal : Window
    {
        Connection conn = new Connection();
        public NewAnimal()
        {
            InitializeComponent();
            conn.FillComboBox(cb);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conn.AddAnimal(animal, cb);
            this.Close();
        }
    }
}
