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
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace MDK_Motorcycle.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        private ModelDBContext? _db = null;
        public LogIn()
        {
            InitializeComponent();
            _db = new ModelDBContext();
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new Registration());
        }

        private void TbnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (TbnLogin.Text != null)
            {
                if (PsPassword.Password != null )
                {
                    Users? userModel = _db?.Users.FirstOrDefault(predicate: x => x.Login == TbnLogin.Text && x.Password == PsPassword.Password);
                    if (userModel != null)
                    {
                        if (TbnLogin.Text == "admin" && PsPassword.Password == "1")
                        {
                            Util.UtilFrame?.Navigate(new DataBase());
                        }
                        else
                        {
                            class1.Data = TbnLogin.Text;
                            Util.UtilFrame?.Navigate(new MainPage());
                        }
                    }
                    else
                    {
                        Error1.Text = "error";
                        Error.Text = "error";
                    }
                }
            }
            TbnLogin.Text = String.Empty;
            PsPassword.Password = String.Empty;
        }
    }
}
