using data_Access.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace data_Access
{
    public class EmployeeDataAcces
    {

        public List<Employee> employees { get; set; } = new List<Employee>();
        public EmployeeDataAcces()
        {
            ReedEmployee();
        }
        private void ReedEmployee()
        {
            Employee emp1 = new Employee()
            {
                Id = 33,
                FirstName = "abolfazl",
                LastName = "jalil",
                PhoneNumber = 09140255960,
                BaseSalary = 2500,
                Address = "ch/m/b/lordegan",
                Department = Department.Production

            };
            Employee emp2 = new Employee()
            {
                Id = 44,
                FirstName = "imran",
                LastName = "bageri",
                PhoneNumber = 1234443455,
                BaseSalary = 3000,
                Address = "shiraz",
                Department = Department.Advertisement

            };
            employees.Add(emp1);
            employees.Add(emp2);
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void RemoveEmployee(int id)
        {
            Employee temp = employees.First(x => x.Id == id);
            employees.Remove(temp);
        }
        public void EditeEmployee(Employee employee)
        {
            Employee temo = employees.First(x => x.Id == employee.Id);
            int index = employees.IndexOf(temo);
            employees[index] = temo;
        }
        public int getNextId()
        {

            int index = employees.Any() ? employees.Max(x => x.Id) + 1 : 1;
            return index;
        }
    }

}

