using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для avtorizaciya.xaml
    /// </summary>
    public partial class avtorizaciya : Window
    {      
        int CountTry = 3;
       
        public avtorizaciya()
        {
            InitializeComponent();
        }
        private void menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Enter(object sender, RoutedEventArgs e)
        {

            if (Password.Password.ToString()== "" && PasswordHide.Text == "")
            { 
                MessageBox.Show("Введите пароль");
                return;
            }
            if (Login.Text== "")
            {
                MessageBox.Show("Ввдите логин");
                return;
            }
                string login = Login.Text;
            if (Password.Password.ToString() == "")
            {
                string passwordNHide = PasswordHide.Text.ToString();
                Entityes.User passwordNHideSerch = App.DB.User.Where(p => p.Password == passwordNHide).FirstOrDefault();
                Entityes.User userserch = App.DB.User.Where(u => u.Login == login).FirstOrDefault();
                if (userserch != null && passwordNHideSerch != null)
                {
                    MessageBox.Show("Вы успешно зашли как администратор ");
                    View.WindowUpdateCatalog openUpdate = new View.WindowUpdateCatalog();
                    this.Hide();
                    openUpdate.ShowDialog();
                    this.ShowDialog();

                }
                else
                {
                    CountTry = CountTry - 1;
                    if (CountTry == 0)
                    {
                        MessageBox.Show("Все попытки исчерпаны.Подождите 10 секунд");
                        Thread.Sleep(10000);
                        CountTry = 3;
                    }
                    else
                    {
                        MessageBox.Show("Неудачная попытка входа.\r\n  У Вас осталось " + CountTry + " попыток.");
                    }
                }
            }
            if ( PasswordHide.Text=="")
            { 
                string password =Password.Password.ToString();
                Entityes.User passwordHideSerch = App.DB.User.Where(p => p.Password == password).FirstOrDefault();
                Entityes.User userserch = App.DB.User.Where(u => u.Login == login).FirstOrDefault();
                if (userserch != null && passwordHideSerch != null) 
                {
                    MessageBox.Show("Вы успешно зашли как администратор ");
                    View.WindowUpdateCatalog openUpdate = new View.WindowUpdateCatalog();
                    this.Hide();
                    openUpdate.ShowDialog();
                    this.ShowDialog();

                }
                else
                {
                    CountTry = CountTry - 1;
                    if (CountTry == 0)
                    {
                        MessageBox.Show("Все попытки исчерпаны.Подождите 10 секунд");
                        Thread.Sleep(10000);
                        CountTry = 3;
                    }
                    else
                    {
                        MessageBox.Show("Неудачная попытка входа.\r\n  У Вас осталось " + CountTry + " попыток.");
                    }
                }
            }




                
            
        }
        private void Load(object sender, RoutedEventArgs e)
        {
            PasswordHide.Visibility = Visibility.Hidden;
            this.UpdateLayout();
        
        }
        private void Hide(object sender, RoutedEventArgs e)
        {
            
            if (pass.IsChecked==true)
            {
                PasswordHide.Visibility= Visibility.Visible;
                PasswordHide.Text = Password.Password.ToString();
                Password.Clear();
                Password.Visibility = Visibility.Hidden;
            }
            if (pass.IsChecked == false) 
            {
                Password.Visibility= Visibility.Visible;
                Password.Password = PasswordHide.Text;
                PasswordHide.Clear();
                PasswordHide.Visibility=Visibility.Hidden;
            }
        }

        

    }
}
