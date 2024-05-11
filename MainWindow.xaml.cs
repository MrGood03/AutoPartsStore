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

namespace WPFProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.DB = new Entityes.AutoPartsStoreEntities();
        }
        public string dict = "Light";
        private void OpenPrice(Object sender, RoutedEventArgs e)
        { 
            View.WindowPrice OpenPrice = new View.WindowPrice();
            this.Hide();
            OpenPrice.ShowDialog();
            this.ShowDialog();
            
        }
        private void OpenOrder(Object sender, RoutedEventArgs e)
        {
            View.WindowOrder OpenOrder = new View.WindowOrder();
            this.Hide();
            OpenOrder.ShowDialog();
            this.ShowDialog();
        }
        private void OpenCatalog(object sender, RoutedEventArgs e)
        { 
            View.avtorizaciya OpenCatalog = new View.avtorizaciya();
            this.Hide();
            OpenCatalog.ShowDialog();
            this.ShowDialog();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dict == "Dark")
            {
                dict = "Light";
                Price.Source = BitmapFrame.Create(new Uri(@"C:\MKod\С#\WPFProject\Resurs\PriceListBlack.png"));
                Order.Source = BitmapFrame.Create(new Uri(@"C:\MKod\С#\WPFProject\Resurs\MakeOrderBlack.png"));
                Catalog.Source = BitmapFrame.Create(new Uri(@"C:\MKod\С#\WPFProject\Resurs\EditCatalogBlack.png"));
            }
            else
            {
                dict = "Dark";
                Price.Source = BitmapFrame.Create(new Uri(@"C:\MKod\С#\WPFProject\Resurs\PriceLiskWhite.png"));
                Order.Source = BitmapFrame.Create(new Uri(@"C:\MKod\С#\WPFProject\Resurs\MakeOrderWhite.png"));
                Catalog.Source = BitmapFrame.Create(new Uri(@"C:\MKod\С#\WPFProject\Resurs\EditCatalogWhite.png"));

            }
            var uri = new Uri(dict + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(dict + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }

}
