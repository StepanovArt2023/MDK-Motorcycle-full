using MDK_Motorcycle.Core;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MDK_Motorcycle.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private ModelDBContext? _db = null;
        private Users _user = new Users();
        public Registration()
        {
            InitializeComponent();

            _db = new ModelDBContext();
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new LogIn());
        }

        private void TbnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbnLogin.Text) ||
                string.IsNullOrEmpty(PswPassword.Password))
            {
                MessageBox.Show("Ошибка ввода данных",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    _user.Login = TbnLogin.Text;
                    _user.Password = PswPassword.Password;

                    MessageBox.Show("Аккаунт успешно создан",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);

                    _db?.Users.Add(_user);
                    _db?.SaveChanges();

                    Util.UtilFrame?.Navigate(new LogIn());
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
    }
}
