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

namespace Khalitov41Shoes
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        
        public AuthPage()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTB.Text;
            string password = PassTB.Text;
            if (login == "" || password == "")
            {
                MessageBox.Show("Есть пустые поля");
                return;
            }
            User user = Khalitov41ShoesEntities.GetContext().User.ToList().Find(p => p.UserLogin == login && p.UserPassword == password);
            if (user != null)
            {
                Manager.MainFrame.Navigate(new ProductPage(user));
                LoginTB.Text = "";
                PassTB.Text = "";
            }
            else
            {
                MessageBox.Show("Введены неверные данные");
                LoginBtn.IsEnabled = false;
                await Task.Delay(10000);
                LoginBtn.IsEnabled = true;
            }
        }

        private void GuestBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ProductPage(null));
            LoginTB.Text = "";
            PassTB.Text = "";
        }
    }
}
