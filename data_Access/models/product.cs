using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_Access.models
{
    public class Product : Iproduct
    {
        public  int Id { get; set; }
        public  string Name { get ; set; }
        public decimal Price { get ; set ; }
        public int AvalebleCount { get; set; }

        public string GetBasicInfo()
        {
            string str = Name + "\n" + Price + "\n" + "$\n" + AvalebleCount;
            return str;
        }
    }
}
