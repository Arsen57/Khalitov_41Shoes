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
        User currentUser;
        int newOrderId;

        List<OrderProduct> selectedOrderProducts = new List<OrderProduct>();
        List<Product> selectedProducts = new List<Product>();
        int CountRecords;
        int CountPage;
        int CurrentPage = 0;

        List<Product> CurrentPageList = new List<Product>();
        List<Product> TableList;
        public ProductPage(User user)
        {
            InitializeComponent();

            if (selectedProducts.Count == 0)
            {
                BtnOrder.Visibility = Visibility.Hidden;
            }
            currentUser = user;
            //добавить строки
            //загрузить в список из БД
            if (user != null)
            {
                FIOTB.Text = user.UserSurname + " " + user.UserName + " " + user.UserPatronymic;
                switch (user.UserRole)
                {
                    case 1:
                        RoleTB.Text = "Клиент"; break;
                    case 2:
                        RoleTB.Text = "Менеджер"; break;
                    case 3:
                        RoleTB.Text = "Администратор"; break;
                }
            }
            else
            {
                FIOTB.Text = "гость";
                RoleTB.Text = "Гость";
            }

            List<Product> currentProducts = Khalitov41ShoesEntities.GetContext().Product.ToList();
            ProductListView.ItemsSource = currentProducts;
            List<Order> allOrder = Khalitov41ShoesEntities.GetContext().Order.ToList();
            List<int> allOrderId = new List<int>();
            foreach (var p in allOrder.Select(x => $"{x.OrderID}").ToList())
            {
                allOrderId.Add(Convert.ToInt32(p));
            }

            newOrderId = allOrderId.Max() + 1;

            var currentProduct = Khalitov41ShoesEntities.GetContext().Product.ToList();
            //связаться с листвью
            ProductListView.ItemsSource = currentProduct;
            //добавить строки

            ProdAll.Text = Convert.ToString(currentProduct.Count);

            CostComboBox.SelectedIndex = 0;
            DiscntComboBox.SelectedIndex = 0;

            UpdateProduct();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void ProdSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateProduct();
        }

        private void CostComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProduct();
        }

        private void DiscntComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProduct();
        }

        public void UpdateProduct()
        {
            var currentProduct = Khalitov41ShoesEntities.GetContext().Product.ToList();
            currentProduct = currentProduct.Where(p => p.ProductName.ToLower().Contains(ProdSearch.Text.ToLower())).ToList();
            if (selectedProducts.Count > 0)
            {
                BtnOrder.Visibility = Visibility.Visible;
            }

            if (CostComboBox.SelectedIndex == 0)
            {
                currentProduct = currentProduct.Where(p => p.ProductDiscountAmount >= 0 && p.ProductDiscountAmount <= 100).ToList();
            }
            else if (CostComboBox.SelectedIndex == 1)
            {
                currentProduct = currentProduct.OrderBy(p => p.ProductCost).ToList();
            }
            else if (CostComboBox.SelectedIndex == 2)
            {
                currentProduct = currentProduct.OrderByDescending(p => p.ProductCost).ToList();
            }
            if (DiscntComboBox.SelectedIndex == 0)
            {

            }
            else if (DiscntComboBox.SelectedIndex == 1)
            {
                currentProduct = currentProduct.Where(p => (p.ProductDiscountAmount >= 0 && p.ProductDiscountAmount < 10)).ToList();
            }
            else if (DiscntComboBox.SelectedIndex == 2)
            {
                currentProduct = currentProduct.Where(p => (p.ProductDiscountAmount >= 10 && p.ProductDiscountAmount < 15)).ToList();
            }
            else if (DiscntComboBox.SelectedIndex == 3)
            {
                currentProduct = currentProduct.Where(p => (p.ProductDiscountAmount >= 15)).ToList();
            }

            ProdAtTheMoment.Text = Convert.ToString(currentProduct.Count);

            ProductListView.ItemsSource = currentProduct;

            TableList = currentProduct;
            if (selectedProducts.Count == 0)
            {
                BtnOrder.Visibility = Visibility.Hidden;
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow window = new OrderWindow(selectedOrderProducts, selectedProducts, currentUser);
            window.ShowDialog();
            UpdateProduct();
        }

        private void AddInOrder_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListView.SelectedIndex >= 0)
            {
                List<Order> allOrder = Khalitov41ShoesEntities.GetContext().Order.ToList();
                List<int> allOrderId = new List<int>();
                foreach (var p in allOrder.Select(x => $"{x.OrderID}").ToList())
                {
                    allOrderId.Add(Convert.ToInt32(p));
                }

                newOrderId = allOrderId.Max() + 1;
                var prod = ProductListView.SelectedItem as Product;

                //int newOrderID = selectedOrderProducts.Last().Order.OrderID;
                var newOrderProd = new OrderProduct();
                newOrderProd.OrderID = newOrderId;

                newOrderProd.ProductArticleNumber = prod.ProductArticleNumber;
                newOrderProd.Amount = 1;
                var selOP = selectedOrderProducts.Where(p => Equals(p.ProductArticleNumber, prod.ProductArticleNumber));

                if (selOP.Count() == 0)
                {
                    selectedOrderProducts.Add(newOrderProd);
                    selectedProducts.Add(prod);
                }
                else
                {
                    foreach (OrderProduct p in selectedOrderProducts)
                    {
                        if (p.ProductArticleNumber == prod.ProductArticleNumber)
                            p.Amount++;
                    }
                }

                BtnOrder.Visibility = Visibility.Visible;
                ProductListView.SelectedIndex = -1;

                UpdateProduct();
            }
        }
    }
}

