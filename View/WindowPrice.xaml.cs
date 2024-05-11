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
using WPFProject.Entityes;

namespace WPFProject.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPrice.xaml
    /// </summary>
    public partial class WindowPrice : Window
    {
        List<Entityes.Product> Products;
        public WindowPrice()
        {
            InitializeComponent();


        }
        private void ShowProduct()
        { 
            Products=App.DB.Product.ToList();
            int AllCount = Products.Count;
            if (CbSort.SelectedIndex == 1)
            { 
                Products=Products.OrderBy(p=>p.Price).ToList();
            }
            if (CbSort.SelectedIndex == 2)
            { 
                Products= Products.OrderByDescending(p=>p.Price).ToList();
            
            }


            if (CbCateg.SelectedValue != null && (int)CbCateg.SelectedValue > 0)
            { 
                Products= Products.Where(p=>p.CategoryID==(int)CbCateg.SelectedValue).ToList();
            }
            string search = Tb_Search.Text.ToLower();
            if (search.Length > 0)
            {
                Products = Products.Where(p => p.NameProduct.ToLower().Contains(search)).ToList();  

            }
            int countFilter = Products.Count;
            tbCount.Text = countFilter.ToString() + "/" + AllCount.ToString();
            GridPrice.ItemsSource = Products;

            
        }
        

            

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Entityes.Product> products = App.DB.Product.ToList();
            GridPrice.ItemsSource = products;
            CbSort.SelectedIndex = 0;				
            List<Entityes.Category> categories = App.DB.Category.ToList();
            Entityes.Category category = new Entityes.Category();
            category.Name = "Все категории";
            category.CategoryID = 0;
            categories.Insert(0, category);
            CbCateg.ItemsSource = categories;
            CbCateg.DisplayMemberPath = "Name";
            CbCateg.SelectedValuePath = "CategoryID";


        }

        private void CbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowProduct();
        }

        private void CbCateg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowProduct();

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowProduct();

        }
        private void BC_Clear(object sender, RoutedEventArgs e)
        {
            ShowProduct();
            CbCateg.SelectedIndex = -1;

        }
    }
}
