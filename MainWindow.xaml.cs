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

namespace SSH
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

        private void itogo(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(x.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            otvet.Content += Math.Pow(x, 3).ToString();
        }
    }
}
