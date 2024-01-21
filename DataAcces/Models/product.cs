using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public class product : Iproduct
    {
        public int Id { get;set; }
        public string Name { get ; set; }
        public decimal Price { get; set; }
        public int AvilebleCount { get; set; }
        public string GetBasicInfo()
        {
            string str = Name + "\n Price :" + Price + "\n Avileble Count" + AvilebleCount;
            return str;
        }
    }
}
