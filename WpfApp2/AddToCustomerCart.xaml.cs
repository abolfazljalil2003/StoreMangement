using DataAcces;
using DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for AddToCustomerCart.xaml
    /// </summary>
    public partial class AddToCustomerCart : Window
        
    {
        CustomerDataAccess customerDataAccess = new CustomerDataAccess();
        ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
        ProductDataAccess productDataAccess = new ProductDataAccess();
        public product currentProduct { get; set; }=new product();
        public Customer currentCustomer{ get; set; } = new Customer();

        public AddToCustomerCart()
        {
            InitializeComponent();
            FillData();
            CustomersProduct.ItemsSource= customers;
            
        }
        private void FillData()
        {
            customers = customerDataAccess.Customers;

        }

        private void CustomersProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CustomersProduct.SelectedIndex >= 0)
            {
                currentCustomer = CustomersProduct.SelectedItem as Customer;
               
            }
          

        }

        private void BtCancelAddtocustomer_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtOkayAddtocustomer_Click(object sender, RoutedEventArgs e)
        {
            currentCustomer = CustomersProduct.SelectedItem as Customer;

            
          
        }
    }
}
