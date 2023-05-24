using MDK_Motorcycle.Core;
using MDK_Motorcycle.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MDK_Motorcycle.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private ModelDBContext? _db = new ModelDBContext();
        private Product _product = new Product();
        public MainPage()
        {
            InitializeComponent();

            //_db1 = new ModelDBContext();
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BorderItem1.Background = Brushes.White;
            BorderItem2.Background = Brushes.Transparent;
            BorderItem3.Background = Brushes.Transparent;
            BorderItem4.Background = Brushes.Transparent;
            BorderItem5.Background = Brushes.Transparent;
            BorderItem6.Background = Brushes.Transparent;
            BorderItem7.Background = Brushes.Transparent;
            ImageItem.Source = BitmapFrame.Create(new Uri("C:\\Users\\Пользователь\\Desktop\\MDK-Motorcycle\\MDK-Motorcycle\\View\\Pages\\Images\\1.webp", UriKind.Relative));
            Product product = null;
            int a = 1;
            product = _db.Products.Where(b => b.ProductId == a).FirstOrDefault();
            if (product != null)
                TbnNomber.Text = Convert.ToString(product);
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            BorderItem1.Background = Brushes.Transparent;
            BorderItem2.Background = Brushes.White;
            BorderItem3.Background = Brushes.Transparent;
            BorderItem4.Background = Brushes.Transparent;
            BorderItem5.Background = Brushes.Transparent;
            BorderItem6.Background = Brushes.Transparent;
            BorderItem7.Background = Brushes.Transparent;
            ImageItem.Source = BitmapFrame.Create(new Uri("C:\\Users\\Пользователь\\Desktop\\MDK-Motorcycle\\MDK-Motorcycle\\View\\Pages\\Images\\2.webp", UriKind.Relative));
            Product product = null;
            int a = 2;
            product = _db.Products.Where(b => b.ProductId == a).FirstOrDefault();
            if (product != null)
                TbnNomber.Text = Convert.ToString(product);
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            BorderItem1.Background = Brushes.Transparent;
            BorderItem2.Background = Brushes.Transparent;
            BorderItem3.Background = Brushes.White;
            BorderItem4.Background = Brushes.Transparent;
            BorderItem5.Background = Brushes.Transparent;
            BorderItem6.Background = Brushes.Transparent;
            BorderItem7.Background = Brushes.Transparent;
            ImageItem.Source = BitmapFrame.Create(new Uri("C:\\Users\\Пользователь\\Desktop\\MDK-Motorcycle\\MDK-Motorcycle\\View\\Pages\\Images\\3.webp", UriKind.Relative));
            Product product = null;
            int a = 3;
            product = _db.Products.Where(b => b.ProductId == a).FirstOrDefault();
            if (product != null)
                TbnNomber.Text = Convert.ToString(product);
        }

        private void Border_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            BorderItem1.Background = Brushes.Transparent;
            BorderItem2.Background = Brushes.Transparent;
            BorderItem3.Background = Brushes.Transparent;
            BorderItem4.Background = Brushes.White;
            BorderItem5.Background = Brushes.Transparent;
            BorderItem6.Background = Brushes.Transparent;
            BorderItem7.Background = Brushes.Transparent;
            ImageItem.Source = BitmapFrame.Create(new Uri("C:\\Users\\Пользователь\\Desktop\\MDK-Motorcycle\\MDK-Motorcycle\\View\\Pages\\Images\\4.webp", UriKind.Relative));
            Product product = null;
            int a = 4;
            product = _db.Products.Where(b => b.ProductId == a).FirstOrDefault();
            if (product != null)
                TbnNomber.Text = Convert.ToString(product);
        }

        private void Border_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            BorderItem1.Background = Brushes.Transparent;
            BorderItem2.Background = Brushes.Transparent;
            BorderItem3.Background = Brushes.Transparent;
            BorderItem4.Background = Brushes.Transparent;
            BorderItem5.Background = Brushes.White;
            BorderItem6.Background = Brushes.Transparent;
            BorderItem7.Background = Brushes.Transparent;
            ImageItem.Source = BitmapFrame.Create(new Uri("C:\\Users\\Пользователь\\Desktop\\MDK-Motorcycle\\MDK-Motorcycle\\View\\Pages\\Images\\5.webp", UriKind.Relative));
            Product product = null;
            int a = 5;
            product = _db.Products.Where(b => b.ProductId == a).FirstOrDefault();
            if (product != null)
                TbnNomber.Text = Convert.ToString(product);
        }

        private void Border_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            BorderItem1.Background = Brushes.Transparent;
            BorderItem2.Background = Brushes.Transparent;
            BorderItem3.Background = Brushes.Transparent;
            BorderItem4.Background = Brushes.Transparent;
            BorderItem5.Background = Brushes.Transparent;
            BorderItem6.Background = Brushes.White;
            BorderItem7.Background = Brushes.Transparent;
            ImageItem.Source = BitmapFrame.Create(new Uri("C:\\Users\\Пользователь\\Desktop\\MDK-Motorcycle\\MDK-Motorcycle\\View\\Pages\\Images\\6.webp", UriKind.Relative));
            Product product = null;
            int a = 6;
            product = _db.Products.Where(b => b.ProductId == a).FirstOrDefault();
            if (product != null)
                TbnNomber.Text = Convert.ToString(product);
        }

        private void Border_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            BorderItem1.Background = Brushes.Transparent;
            BorderItem2.Background = Brushes.Transparent;
            BorderItem3.Background = Brushes.Transparent;
            BorderItem4.Background = Brushes.Transparent;
            BorderItem5.Background = Brushes.Transparent;
            BorderItem6.Background = Brushes.Transparent;
            BorderItem7.Background = Brushes.White;
            ImageItem.Source = BitmapFrame.Create(new Uri("C:\\Users\\Пользователь\\Desktop\\MDK-Motorcycle\\MDK-Motorcycle\\View\\Pages\\Images\\7.webp", UriKind.Relative));
            Product product = null;
            int a = 7;
            product = _db.Products.Where(b => b.ProductId == a).FirstOrDefault();
            if (product != null)
                TbnNomber.Text = Convert.ToString(product);
        }
        //private ModelDBContext? _db1 = null;
        private ModelDBContext? _db1 = new ModelDBContext();
        private Shop _shop = new Shop();
        private void TbnBuy_Click(object sender, RoutedEventArgs e)
        {
                MessageBox.Show("Данная функция временно недоступна",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                /*try
                {          
                    _shop.Login = class1.Data;
                    _shop.Product = _product.ProductName; 
                    _shop.Price = _product.PriceProduct;
                _db?.Products.Add(_product);
                _db?.SaveChanges();
                _db1?.Shops.Add(_shop);
                    _db1?.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(),
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                }*/
        }

        private void BtnBack1_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new LogIn());
        }

        private void TbnShopUser_Click(object sender, RoutedEventArgs e)
        {
            ShopUser shopuser = new ShopUser();
            shopuser.Show();
        }
    }
}
