using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Models;

namespace DataAcces
{
    public class ProductDataAccess
    {
        public ObservableCollection<product> Products { get; set; } = new ObservableCollection<product>();
        public ProductDataAccess()
        {
            ReedProducts();
        }
        private void ReedProducts()
        {
            product pi1 = new product()
            {
                Name = "cala",
                Id = 1,
                Price = 17,
                AvilebleCount = 20
            };
            product pi2 = new product()
            {
                Name = "cala2",
                Id = 2,
                Price = 18,
                AvilebleCount = 10
            };
            Products.Add(pi1);
            Products.Add(pi2);
        }
        public void AddProduct(product product)
        {
            Products.Add(product);
        }
        public void Removeproduct(int  id)
        {
            product temp=Products.First(p => p.Id == id);
            Products.Remove(temp);
        }
        public void EditeProduct(product pr)
        {
            product temp = Products.First(p => p.Id ==pr.Id);
            int index=Products.IndexOf(temp);
            Products[index] = pr;
        }
        public int GetNextId()
        {
            int index=Products.Any()? Products.Max(p => p.Id)+1 :1;
            return index;
        }

    }
}
