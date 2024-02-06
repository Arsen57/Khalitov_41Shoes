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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        int CountRecords;
        int CountPage;
        int CurrentPage = 0;

        List<Product> CurrentPageList = new List<Product>();
        List<Product> TableList;
        public ProductPage()
        {
            InitializeComponent();
            //добавить строки
            //загрузить в список из БД
            var currentProduct = Khalitov41ShoesEntities.GetContext().Product.ToList();
            //связаться с листвью
            ProductListView.ItemsSource = currentProduct;
            //добавить строки
            //CostComboBox.SelectedIndex = 0;
            //DiscntComboBox.SelectedIndex = 0;

            //UpdateProduct();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }
    }
}
