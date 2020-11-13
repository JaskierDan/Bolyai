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

namespace WpfGyak2
{
    /// <summary>
    /// Interaction logic for NewSubject.xaml
    /// </summary>
    public partial class NewSubject : Window
    {
        Connection conn = new Connection();
        public NewSubject()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            conn.AddNewData(Subject, "subjects");
        }
    }
}
