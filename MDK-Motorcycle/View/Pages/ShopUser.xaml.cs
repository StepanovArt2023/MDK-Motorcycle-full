using MDK_Motorcycle.Model;
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

namespace MDK_Motorcycle.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShopUser.xaml
    /// </summary>
    public partial class ShopUser : Window
    {
        private ModelDBContext? _db = new ModelDBContext();
        public ShopUser()
        {
            InitializeComponent();

            Shop shop = null;
            string a = class1.Data;
            shop = _db.Shops.Where(b => b.Login == a).FirstOrDefault();
            if (shop != null)
                TbShop.Text = Convert.ToString(shop);
        }

       private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new MainPage());
        }
    }
}
