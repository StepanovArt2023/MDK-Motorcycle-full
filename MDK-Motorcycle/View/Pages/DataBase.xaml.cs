using MDK_Motorcycle.Core;
using MDK_Motorcycle.Model;
using MDK_Motorcycle.View.Pages.Images;
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

namespace MDK_Motorcycle.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataBase.xaml
    /// </summary>
    public partial class DataBase : Page
    {
        public List<Product> DatabaseProducts { get; private set; }
        public DataBase()
        {
            InitializeComponent();
            Read();
        }
        public void Read()
        {
            using (ModelDBContext db = new ModelDBContext())
            {
                DatabaseProducts = db.Products.ToList();
                LVInfo1.ItemsSource = DatabaseProducts;
            }
        }
        public void Create()
        {
            using (ModelDBContext db = new ModelDBContext())
            {
                var Tbn1 = TbnName.Text;
                var Tbn2 = TbnType.Text;
                var Tbn3 = TbnColour.Text;
                var Tbn4 = TbnEngine.Text;
                var Tbn5 = TbnTransmission.Text;
                var Tbn6 = TbnDrive.Text;
                var Tbn7 = TbnQuantity.Text;
                var Tbn8 = TbnPrice.Text;

                try
                {
                    if (string.IsNullOrEmpty(Tbn1) ||
                        string.IsNullOrEmpty(Tbn2) ||
                        string.IsNullOrEmpty(Tbn3) ||
                        string.IsNullOrEmpty(Tbn4) ||
                        string.IsNullOrEmpty(Tbn5) ||
                        string.IsNullOrEmpty(Tbn6) ||
                        string.IsNullOrEmpty(Tbn7) ||
                        string.IsNullOrEmpty(Tbn8))
                    {
                        MessageBox.Show("Ошибки ввода данных",
                                        "Системное сообщение",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Error);
                    }
                    else
                    {
                        db.Products.Add(new Product()
                        {
                            ProductName = Tbn1,
                            TypeProduct = Tbn2,
                            ColourProduct = Tbn3,
                            EngineProduct = Tbn4,
                            TransmissionProduct = Tbn5,
                            DriveProduct = Tbn6,
                            QuantityProduct = Tbn7,
                            PriceProduct = Tbn8
                        });
                        db.SaveChanges();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }

        public void Update()
        {
            using (ModelDBContext db = new ModelDBContext())
            {
                Product? selectproduct = LVInfo1.SelectedItem as Product;

                var Tbn1 = TbnName.Text;
                var Tbn2 = TbnType.Text;
                var Tbn3 = TbnColour.Text;
                var Tbn4 = TbnEngine.Text;
                var Tbn5 = TbnTransmission.Text;
                var Tbn6 = TbnDrive.Text;
                var Tbn7 = TbnQuantity.Text;
                var Tbn8 = TbnPrice.Text;

                try
                {
                    if (string.IsNullOrEmpty(Tbn1) ||
                        string.IsNullOrEmpty(Tbn2) ||
                        string.IsNullOrEmpty(Tbn3) ||
                        string.IsNullOrEmpty(Tbn4) ||
                        string.IsNullOrEmpty(Tbn5) ||
                        string.IsNullOrEmpty(Tbn6) ||
                        string.IsNullOrEmpty(Tbn7) ||
                        string.IsNullOrEmpty(Tbn8))
                    {
                        MessageBox.Show("Ошибки ввода данных",
                                        "Системное сообщение",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Error);
                    }

                    else
                    {
                        Product product = db.Products.Find(selectproduct.ProductId);
                        product.ProductName = Tbn1;
                        product.TypeProduct = Tbn2;
                        product.ColourProduct = Tbn3;
                        product.EngineProduct = Tbn4;
                        product.TransmissionProduct = Tbn5;
                        product.DriveProduct = Tbn6;
                        product.QuantityProduct = Tbn7;
                        product.PriceProduct = Tbn8;

                        db.SaveChanges();
                        Read();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(),
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }

        public void Delete()
        {
            using (ModelDBContext db = new Model.ModelDBContext())
            {
                Product selectedproduct = LVInfo1.SelectedItem as Product;

                if (selectedproduct != null)
                {
                    Product? product = db.Products.Single(f => f.ProductId == selectedproduct.ProductId);
                    db.Products.Remove(product);
                    db.SaveChanges();
                    Read();
                }
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            Read();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            LVInfo1.Items.Clear();
        }

        private void BtnUsers_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new UserDB());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new LogIn());
        }
    }
}
