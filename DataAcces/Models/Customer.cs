using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public class Customer : Iperson

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ulong PhoneNumber { get; set; }
        public string Addres { get; set; }
        public string GetBasicInfo()
        {
            string str = FirstName + " " + LastName + "\nPhoneNumber : " + PhoneNumber + "\n Address : " + Addres ;
            return str;
        }


    } }
