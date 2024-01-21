using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_Access.models
{
    public class Customer : Iperson
    {
        public int Id { get ;set; }
        public string FirstName { get; set; }
        public string LastName { get ; set ; }
        public ulong PhoneNumber { get; set; }
        public string Address { get ; set ; }

        public string GetBasicInfo()
        {
            string str = FirstName + " " + LastName + "\n" + PhoneNumber + "\n" + Address ;
            return str;
        }
    }
}
