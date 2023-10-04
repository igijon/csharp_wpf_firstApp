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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loader;
        }

        private void MainWindow_Loader(object sender, RoutedEventArgs e)
        {
            Person person = new Person()
            {
                Name = "Sergio",
                Age = 43
            };
            this.DataContext = person; //Asignarlo en DataContext de Window (this se refiere a Window)
        }
    }
}

public class Person
{
    public String Name { get; set; }
    public int Age { get; set; }


}
