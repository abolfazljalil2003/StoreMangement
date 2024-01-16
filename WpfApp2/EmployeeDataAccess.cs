using DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAcces
{
    public class EmployeeDataAccess
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();
        public EmployeeDataAccess()
        {
            ReedEmployee();
        }
        private void ReedEmployee()
        {
            Employee em1 = new Employee()
            {
                FirstName = "abolfazl",
                Id = 22,
                LastName="jalil",
                PhoneNumber=9123323131
                ,Addres="lordegan",
                Department=Department.Advertisement,
                BaseSalary=360
            };
            Employee em2 = new Employee()
            {
                FirstName = "ali",
                Id = 22,
                LastName = "ahmadi",
                PhoneNumber = 9123323131
               ,
                Addres = "lordegan",
                Department = Department.Advertisement,
                BaseSalary = 360
            };
            Employees.Add(em1);
            Employees.Add(em2);
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void RemoveEmployee(int id)
        {
            Employee temp = Employees.First(p => p.Id == id);
            Employees.Remove(temp);
        }
        public void EditeEmployee(Employee em)
        {
            Employee temp = Employees.First(x => x.Id == em.Id);
            int index = Employees.IndexOf(temp);
            Employees[index] = em;
        }
        public int GetNextId()
        {
            int index = Employees.Any() ? Employees.Max(p => p.Id) + 1 : 1;
            return index;
        }
    }
}

