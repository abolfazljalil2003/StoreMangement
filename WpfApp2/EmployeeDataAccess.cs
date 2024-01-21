using DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Db;

namespace DataAcces
{
    public class EmployeeDataAccess
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();
        public EmployeeDataAccess()
        {
           

            Class1 conn = new Class1();
            conn.CreateTable(conn.CreateConnection(), @"CREATE TABLE IF NOT EXISTS employee (
    Id INTEGER PRIMARY KEY,
    FirstName TEXT NOT NULL,
    LastName TEXT NOT NULL,
    PhoneNumber INTEGER NOT NULL,
    Address TEXT,
    Department TEXT,
    BaseSalary REAL NOT NULL
); ");
            
            ReedEmployee(conn.CreateConnection());
        }
        private void ReedEmployee(SQLiteConnection conn)
        {
   
            SQLiteDataReader reader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM employee";

            reader = sqlite_cmd.ExecuteReader();

            while (reader.Read())
            {
              
                Employees.Add(new Employee()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    PhoneNumber = Convert.ToUInt64(reader["PhoneNumber"]),
                    Addres = reader["Address"].ToString(),
                    Department = Department.Advertisement,
                    BaseSalary = Convert.ToDecimal(reader["BaseSalary"])

                });
            }
            conn.Close();

        }
        public int AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            Class1 con = new Class1();
            SQLiteConnection conn = con.CreateConnection();
            return AddEmployeeToTable(employee, conn);

        }



        private int AddEmployeeToTable(Employee employee, SQLiteConnection conn)
        {
            // Open a connection to the SQLite database



            SQLiteCommand command;
            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO employee ( FirstName, LastName, PhoneNumber, Address, Department, BaseSalary) " +
                                          "VALUES ( @FirstName, @LastName, @PhoneNumber, @Address, @Department, @BaseSalary)";

                    // Add parameters to the command
                    
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", employee.Addres);
                    command.Parameters.AddWithValue("@Department", employee.Department);
                    command.Parameters.AddWithValue("@BaseSalary", employee.BaseSalary);

                    // Execute the command to insert data

                  int result = command.ExecuteNonQuery();

            conn.Close();
            return result;
            



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

