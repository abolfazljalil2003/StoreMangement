using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
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
using DataAcces;
using DataAcces.Models;






namespace WpfApp2
{
    /// <summary>   
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
        CustomerDataAccess customerDataAccess = new CustomerDataAccess();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
        ObservableCollection<product> products = new ObservableCollection<product>();
        ObservableCollection<Employee> Employees = new ObservableCollection<Employee>();
        public Employee currentEmployee { get; set; } = new Employee();
        public Customer cureentCustomer { get; set; } = new Customer();
        public product currenProduct { get; set; } = new product();

        public MainWindow()
        {
            InitializeComponent();
            fillData();
            EmployeeGrid.ItemsSource = employees;
            ProductGrid.ItemsSource = products;
            CustomerGrid.ItemsSource = customers;
        }
        private void fillData()
        {
            employees = employeeDataAccess.Employees;
            customers = customerDataAccess.Customers;
            products = productDataAccess.Products;

        }





        private void bthome_Click(object sender, RoutedEventArgs e)
        {
            homePanel.Visibility = Visibility.Visible;
            employeePanel.Visibility = Visibility.Collapsed;
            productPanel.Visibility = Visibility.Collapsed;
            customerPanel.Visibility = Visibility.Collapsed;
            Mystore.Visibility = Visibility.Collapsed;
        }

        private void btemployee_Click(object sender, RoutedEventArgs e)
        {
            homePanel.Visibility = Visibility.Collapsed;
            employeePanel.Visibility = Visibility.Visible;
            productPanel.Visibility = Visibility.Collapsed;
            customerPanel.Visibility = Visibility.Collapsed;
            Mystore.Visibility = Visibility.Collapsed;
        }

        private void btproduct_Click(object sender, RoutedEventArgs e)
        {
            homePanel.Visibility = Visibility.Collapsed;
            employeePanel.Visibility = Visibility.Collapsed;
            productPanel.Visibility = Visibility.Visible;
            customerPanel.Visibility = Visibility.Collapsed;
            Mystore.Visibility = Visibility.Collapsed;
        }

        private void btcustomer_Click(object sender, RoutedEventArgs e)
        {
            homePanel.Visibility = Visibility.Collapsed;
            employeePanel.Visibility = Visibility.Collapsed;
            productPanel.Visibility = Visibility.Collapsed;
            customerPanel.Visibility = Visibility.Visible;
            Mystore.Visibility = Visibility.Collapsed;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    homePanel.Visibility = Visibility.Collapsed;
        //    employeePanel.Visibility = Visibility.Collapsed;
        //    productPanel.Visibility = Visibility.Collapsed;
        //    customerPanel.Visibility = Visibility.Collapsed;


        private void btHomenfo_Click(object sender, RoutedEventArgs e)
        {
            Mystore.Background = new SolidColorBrush(Colors.Black);
            Mystore.Visibility = Visibility.Visible;
            homePanel.Visibility = Visibility.Collapsed;
            employeePanel.Visibility = Visibility.Collapsed;
            productPanel.Visibility = Visibility.Collapsed;
            customerPanel.Visibility = Visibility.Collapsed;
        }

        private void EmployeeGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeeGrid.SelectedIndex >= 0)
            {
                currentEmployee = EmployeeGrid.SelectedItem as Employee;
                EmployeeLable.Content = currentEmployee.GetBasicInfo();
            }
        }

        private void BtAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            Window1 AddWindow = new Window1(employeeDataAccess);
            AddWindow.ShowDialog();
        }

        private void BtEditEmployee_Click(object sender, RoutedEventArgs e)
        {
            currentEmployee = EmployeeGrid.SelectedItem as Employee;
            Window1 AddWindow = new Window1(employeeDataAccess, currentEmployee);
            AddWindow.ShowDialog();
        }


        private void BtDeliteEmployee_Click(object sender, RoutedEventArgs e)
        {
            currentEmployee = EmployeeGrid.SelectedItem as Employee;
            employeeDataAccess.RemoveEmployee(currentEmployee.Id);
            EmployeeLable.Content = "---";
        }

        private void BtDeleteProd_Click(object sender, RoutedEventArgs e)
        {
            currenProduct = ProductGrid.SelectedItem as product;
            productDataAccess.Removeproduct(currenProduct.Id);
            EmployeeLable.Content = currenProduct.GetBasicInfo();
        }

        private void BtEditeproduc_Click(object sender, RoutedEventArgs e)
        {
            currenProduct = ProductGrid.SelectedItem as product;
            AddEditProduct window = new AddEditProduct(productDataAccess, currenProduct);
            window.ShowDialog();
        }

        private void BtAddProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtAddProduct_Click_1(object sender, RoutedEventArgs e)
        {
            AddEditProduct AddProduct = new AddEditProduct(productDataAccess);
            AddProduct.ShowDialog();
        }

        private void ProductGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductGrid.SelectedIndex >= 0)
            {
                currenProduct = ProductGrid.SelectedItem as product;
                ProductLible.Content = currenProduct.GetBasicInfo();
                BtAddTcustomer.Visibility = Visibility.Visible;

            }
        }

        private void CustomerGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CustomerGrid.SelectedIndex >= 0)
            {
                cureentCustomer = CustomerGrid.SelectedItem as Customer;
                CustomerGridLible.Content = cureentCustomer.GetBasicInfo();
                BtviewCustomercat.Visibility = Visibility.Visible;

            }
        }

        private void BtDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtEditeCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtAddCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtviewCustomercat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtAddTcustomer_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerGrid.SelectedIndex >= 0)
                currenProduct = ProductGrid.SelectedItem as product;
            AddToCustomerCart customer_window = new AddToCustomerCart();


            customer_window.ShowDialog();
        }
    }


}
