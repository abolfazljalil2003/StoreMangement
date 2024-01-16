using DataAcces.Models;using System;using System.Collections.Generic;using System.Collections.ObjectModel;using System.Linq;using System.Text;using System.Threading.Tasks;namespace DataAcces{    public class CustomerDataAccess    {        public ObservableCollection<Customer> Customers { get; set; } = new ObservableCollection<Customer>();
        public ObservableCollection<product> CustomerCart{ get; set; } = new ObservableCollection<product>();
        public void AddProductToCustomer(int customerId, product product)
        {
            Customer customer = Customers.First(c => c.Id == customerId);
            customer.SelectedProducts.Add(product);
        }

        public void RemoveProductFromCustomer(int customerId, int productId)
        {
            Customer customer = Customers.First(c => c.Id == customerId);
            product product = customer.SelectedProducts.First(p => p.Id == productId);
            customer.SelectedProducts.Remove(product);
        }

        public CustomerDataAccess()        {            ReedCustomer();        }        private void ReedCustomer()        {            Customer cu1 = new Customer()            {                FirstName = "imran",                Id = 55,                LastName = "bagheri",                PhoneNumber = 9999999                ,                Addres = "shiraz",
                

            };            Customer cu2 = new Customer()            {                FirstName = "mobin",                Id = 56,                LastName = "fallah",                PhoneNumber = 777777               ,                Addres = "yazd",                                            };            Customers.Add(cu1);            Customers.Add(cu2);            product p = new product()
            {
                Name = "calaaaa",
                Id = 999,
                AvilebleCount = 1,
                Price = 133
            };            cu2.AddSelectedProduct(p);        }                public void AddCustomer(Customer customer)        {            Customers.Add(customer);        }        public void RemoveCustomer(int id)        {            Customer temp = Customers.First(p => p.Id == id);            Customers.Remove(temp);        }        public void EditeCustomer(Customer cu)        {            Customer temp = Customers.First(p => p.Id == cu.Id);            int index = Customers.IndexOf(cu);            Customers[index] = cu;        }        public int GetNextId()        {            int index = Customers.Any() ? Customers.Max(p => p.Id) + 1 : 1;            return index;        }
        //////////////////////
        private ProductDataAccess productDataAccess; // نمونه از ProductDataAccess

        public CustomerDataAccess(ProductDataAccess productDataAccess)
        {
            this.productDataAccess = productDataAccess;
            ReedCustomer();
        }

        // سایر متدها

        public void AddProductToCustomerCart(int customerId, int productId)
        {
            Customer customer = Customers.FirstOrDefault(c => c.Id == customerId);
            product product = productDataAccess.Products.FirstOrDefault(p => p.Id == productId);

            if (customer != null && product != null)
            {
                customer.SelectedProducts.Add(product);
            }
            else
            {
                Console.WriteLine("مشتری یا محصول یافت نشد.");
            }
        }    }}