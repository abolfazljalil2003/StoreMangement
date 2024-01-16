﻿using DataAcces.Models;
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

        public CustomerDataAccess()
                

            };
            {
                Name = "calaaaa",
                Id = 999,
                AvilebleCount = 1,
                Price = 133
            };
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
        }