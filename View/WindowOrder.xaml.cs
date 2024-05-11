using System;
using System.Collections.Generic;
using System.IO;
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
using WPFProject.Entityes;

namespace WPFProject.View
{
    /// <summary>
    /// Логика взаимодействия для WindowOrder.xaml
    /// </summary>
    public partial class WindowOrder : Window
    {
        Random rand = new Random();
        public double SummaBankCard { get; set; }//Сумма на карте
        public double SummaOrder { get; set; }//Сумма заказа
        string pathPhoto = Environment.CurrentDirectory + "\\Photo\\";
        public WindowOrder()
        {
            InitializeComponent();

        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ShowProduct()
        {                
            List<Entityes.Product> products = App.DB.Product.ToList();

            if (LbCategory.SelectedIndex > 0)
            {
                products = products.Where(pr => pr.CategoryID== LbCategory.SelectedIndex).ToList();
            }
            foreach (Entityes.Product product in products)
            {
                if (!product.Image.Contains(Environment.CurrentDirectory) || String.IsNullOrEmpty(product.Image))
                    product.Image = Environment.CurrentDirectory + "\\Photo\\" + product.Image;
            }
            LbProduct.ItemsSource = products;


        }
        private void butExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void LBCateg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowProduct();
        }
        private void OpenBasket(Object sender, RoutedEventArgs e)
        { 
                View.Basket OpenBasket= new View.Basket();
                OpenBasket.Owner = this;
                this.Hide();
                OpenBasket.ShowDialog();
                this.ShowDialog();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Entityes.Category> categories = App.DB.Category.ToList();
            Entityes.Category category = new Entityes.Category();
            category.CategoryID = 0;
            category.Name = "Все категории";
            categories.Insert(0, category);
            LbCategory.ItemsSource = categories;
            LbCategory.DisplayMemberPath = "Name";
            LbCategory.SelectedValuePath = "CategoryID";
            LbCategory.SelectedIndex = 0;
            ShowProduct();

        }
        private void Register_Click (object senderm, RoutedEventArgs e)
        {
            this.Close();

        }

        private void LbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
