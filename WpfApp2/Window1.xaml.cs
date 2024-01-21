using DataAcces;
using DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private EmployeeDataAccess employeeDataAccess;
        private Employee editeEmoployee;
        private bool isEdite =false;
        public Window1(EmployeeDataAccess empDataAccess)
        {
            InitializeComponent();
            employeeDataAccess=empDataAccess;
        }
        public Window1(EmployeeDataAccess empDataAccess,Employee emp)
        {
            InitializeComponent();
            employeeDataAccess = empDataAccess;
            editeEmoployee=emp;
            isEdite =true;
            tboxName.Text = editeEmoployee.FirstName;
            tboxLName.Text= editeEmoployee.LastName;
            tboxPhoneNumber.Text=editeEmoployee.PhoneNumber.ToString();
            tboxAdress.Text = editeEmoployee.Addres;
            tboxSalary.Text=editeEmoployee.BaseSalary.ToString();
            Cdepartment.SelectedIndex = (int)editeEmoployee.Department;
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtOkay_Click(object sender, RoutedEventArgs e)
        {
            if (isEdite)
            {
                Employee employee = new Employee()
                {
                    Id = editeEmoployee.Id,
                    FirstName = tboxName.Text,
                    LastName = tboxLName.Text,
                    PhoneNumber = Convert.ToUInt64(tboxPhoneNumber.Text),
                    Addres = tboxAdress.Text,
                    BaseSalary = Convert.ToDecimal(tboxSalary.Text),
                    Department = (Department)Cdepartment.SelectedIndex

                };
                employeeDataAccess.EditeEmployee(employee);
            }
            else
            {
                Employee employee = new Employee()
                {
                    Id = employeeDataAccess.GetNextId(),
                    FirstName = tboxName.Text,
                    LastName = tboxLName.Text,
                    PhoneNumber = Convert.ToUInt64(tboxPhoneNumber.Text),
                    Addres = tboxAdress.Text,
                    BaseSalary = Convert.ToDecimal(tboxSalary.Text),
                    Department = (Department)Cdepartment.SelectedIndex

                };
                int result = employeeDataAccess.AddEmployee(employee);

                if (result == 1)
                {
                    MessageBox.Show("Employee was added!, result code=" + result);
                }
                else
                    MessageBox.Show("Employee was not added!, result code=" + result);
            }
            
            
            this.Close();
        }
    }
}
