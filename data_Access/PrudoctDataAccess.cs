using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_Access.models;


namespace data_Access
{
    public class PrudoctDataAccess
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public PrudoctDataAccess()
        {
            ReedProducts();
        }
        private void ReedProducts()
        {
            Product pr1 = new Product()
            {
                Id = 22,
                Name = "p1",
                Price = 122,
                AvalebleCount = 3,

            };
            Product pr2 = new Product()
            {
                Id = 33,
                Name = "p2",
                Price = 123,
                AvalebleCount = 4,

            };
            Products.Add(pr1);
            Products.Add(pr2);
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveProduct(int id)
        {
            Product temp = Products.First(x => x.Id == id);
            Products.Remove(temp);
        }
        public void EditeProduct(Product product)
        {
            Product temo =Products.First( x=> x.Id == product.Id);
            int index=Products.IndexOf(temo);
            Products[index] = temo;
        }
        public int getNextId()
        {
            
            int index =Products.Any() ?Products.Max(x => x.Id)+1 :1;
            return index;
        }
    }

}
