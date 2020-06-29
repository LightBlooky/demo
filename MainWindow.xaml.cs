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
using System.Text.RegularExpressions;

namespace demo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(tb.Text);

            if (match.Success)
            {
                List<fogrib> result = new List<fogrib>(0);

                result.Add(new fogrib(tb.Text));

                grib.ItemsSource = result;
                tb.Clear();
            }
            else { MessageBox.Show("Неверное значение"); }
        }

        private void grib_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
