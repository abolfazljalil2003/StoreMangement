using DataAcces;
using DataAcces.Models;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for AddEditProduct.xaml
    /// </summary>
    public partial class AddEditProduct : Window

    {
        private ProductDataAccess productDataAccess;
        private product EditeProduct;
        bool EditeProd = false;
        public AddEditProduct(ProductDataAccess productData)
        {
            InitializeComponent();
            productDataAccess = productData;
        }
        public AddEditProduct(ProductDataAccess productData, product pr)
        {
            InitializeComponent();
            productDataAccess = productData;
            EditeProduct = pr;
            EditeProd = true;
            tboxName.Text = EditeProduct.Name;
            tboxPrice.Text = EditeProduct.Price.ToString();
            tboxAvilebleCount.Text = EditeProduct.AvilebleCount.ToString();


        }

        private void BtPCancel_Click(object sender, RoutedEventArgs e)//cancel product Add edit windo
        {
            this.Close();
        }

        private void BtPOkay_Click(object sender, RoutedEventArgs e)
        {
            if (EditeProd)
            {
                product product = new product()
                {
                    Id = EditeProduct.Id,
                    Name = tboxName.Text,
                    Price = Convert.ToDecimal( tboxPrice.Text),
                    AvilebleCount = Convert.ToInt32( tboxAvilebleCount.Text)
                };
                productDataAccess.EditeProduct(product);
            }
            else
            {

                product prod = new product()
                {
                    Id = productDataAccess.GetNextId(),
                    Name = tboxName.Text,
                    Price = Convert.ToDecimal(tboxPrice.Text),
                    AvilebleCount = Convert.ToInt32(tboxAvilebleCount.Text),

                };
                productDataAccess.AddProduct(prod);

            }
            this.Close();
        }

        private void BtAddTcustomer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
