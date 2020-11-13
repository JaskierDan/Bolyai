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

namespace WpfGyak2
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
            conn.FillComboBox(Subjects, "subjects");
            conn.FillComboBox(Students, "students");
            /*Subjects.SelectedIndex = 0;
            Students.SelectedIndex = 0;*/
        }

        private void New_Subject_Click(object sender, RoutedEventArgs e)
        {
            NewSubject winform = new NewSubject();
            winform.ShowDialog();
            Subjects.ItemsSource = null;
            conn.FillComboBox(Subjects, "subjects");
        }

        private void New_Student_Click(object sender, RoutedEventArgs e)
        {
            NewStudent winform = new NewStudent();
            winform.ShowDialog();
            Students.ItemsSource = null;
            conn.FillComboBox(Students, "students");
        }

        private void Input_Data_Click(object sender, RoutedEventArgs e)
        {
            int number;
            bool isNumber = Int32.TryParse(Grade.Text, out number);
            if(Subjects.SelectedValue != null && Students.SelectedValue != null && isNumber == true && Convert.ToInt32(Grade.Text) <= 5 && Convert.ToInt32(Grade.Text) >= 1)
            {
                conn.Grade(Students, Subjects, Grade);
            }
            else
            {
                MessageBox.Show("Kérlek válassz ki egy diákot, egy tárgyat valamint számot adj meg a jegynek!");
            }
        }

        private void List_Data_Click(object sender, RoutedEventArgs e)
        {
            List1.ItemsSource = null;
            conn.FillListBox(List1, Students);
        }
    }
}
