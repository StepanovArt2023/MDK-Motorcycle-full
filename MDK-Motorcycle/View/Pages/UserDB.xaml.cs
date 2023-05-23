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

namespace MDK_Motorcycle.View.Pages.Images
{
    /// <summary>
    /// Логика взаимодействия для UserDB.xaml
    /// </summary>
    public partial class UserDB : Page
    {
        public List<Users> DatabaseUsers { get; private set; }
        public UserDB()
        {
            InitializeComponent();
            Read();
        }
        public void Create()
        {
            using (ModelDBContext db = new ModelDBContext())
            {
                var login = TbLogin.Text;
                var password = TbPassword.Text;

                try
                {
                    if (string.IsNullOrEmpty(login) ||
                        string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Ошибки ввода данных",
                                        "Системное сообщение",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Error);
                    }
                    else
                    {
                        db.Users.Add(new Users()
                        {
                            Login = login,
                            Password = password
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

        public void Read()
        {
            using (ModelDBContext db = new ModelDBContext())
            {
                DatabaseUsers = db.Users.ToList();
                LVInfo2.ItemsSource = DatabaseUsers;
            }
        }

        public void Update()
        {
            using (ModelDBContext db = new ModelDBContext())
            {
                Users? selectUser = LVInfo2.SelectedItem as Users;

                var login = TbLogin.Text;
                var password = TbPassword.Text;

                try
                {
                    if (string.IsNullOrEmpty(login) ||
                        string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Ошибки ввода данных",
                                        "Системное сообщение",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Error);
                    }

                    else
                    {
                        Users user = db.Users.Find(selectUser.UserId);
                        user.Login = login;
                        user.Password = password;

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
                Users selectedUser = LVInfo2.SelectedItem as Users;

                if (selectedUser != null)
                {
                    Users? user = db.Users.Single(f => f.UserId == selectedUser.UserId);
                    db.Users.Remove(user);
                    db.SaveChanges();
                    Read();
                }
            }
        }
        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            Read();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            LVInfo2.Items.Clear();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Util.UtilFrame?.Navigate(new DataBase());
        }
    }
}
