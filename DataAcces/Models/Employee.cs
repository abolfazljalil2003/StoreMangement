using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public class Employee : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName   { get; set; }
        public ulong PhoneNumber  { get; set; }
        public string Addres     { get; set; }
        public Department Department { get; set; }
       public decimal BaseSalary { get; set; }
        public string GetBasicInfo()
        {
            string str = FirstName + " " + LastName + "\nPhoneNumber : " + PhoneNumber + "\n Address : " + Addres + "\n Department : "+Department +"\n Base Salary : "+ BaseSalary;
            return str;
            Console.WriteLine(str);

        }
    }
   public enum Department
    {
        Production,
        selse,
        Advertisement,
        management
    }
}
