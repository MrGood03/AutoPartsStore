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

namespace WPFProject.View
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
        
        public Basket()
        {
            InitializeComponent();
            
        }
        private void menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
