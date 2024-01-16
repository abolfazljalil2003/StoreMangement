using data_Access.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_Access
{
    public class CustomerDataAccess
    {
        public List<Customer> customers { get; set; } = new List<Customer>();
        public CustomerDataAccess()
        {
            ReedCustomer();
        }
        private void ReedCustomer()
        {
            Customer cust = new Customer()
            {
                Id = 55,
                FirstName = "ali",
                LastName = "ahmadi",
                PhoneNumber = 066666660,

                Address = "ch/m/b/lordegan",


            };
            Customer cust2 = new Customer()
            {
                Id = 66,
                FirstName = "iman",
                LastName = "mohammadi",
                PhoneNumber = 12399998455,

                Address = "ahvaz",


            };
            customers.Add(cust);
            customers.Add(cust2);
        }
        public void AddCustomer(Customer cst)
        {
            customers.Add(cst);
        }
        public void RemoveCustomer(int id)
        {
            Customer temp = customers.First(x => x.Id == id);
            customers.Remove(temp);
        }
        public void EditeCustomer(Employee employee)
        {
            Customer temo = customers.First(x => x.Id == employee.Id);
            int index = customers.IndexOf(temo);
            customers[index] = temo;
        }
        public int getNextId()
        {

            int index = customers.Any() ? customers.Max(x => x.Id) + 1 : 1;
            return index;
        }
    }
}

