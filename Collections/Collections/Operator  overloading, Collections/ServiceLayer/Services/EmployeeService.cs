using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
       
        public int  GetEmployeeCountByFiltered(DateTime startBirthday, DateTime endBirthday, double salary)
        {
            var employees = GetAll();

            List<Employee> employee = GetAll().FindAll(m => m.Birthday > startBirthday && m.Birthday < endBirthday && m.Salary > salary);

            return employee.Count ;
        }

        private List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1= new Employee
            {
                Name = "Konul",
                Surname = "Ibrahimova",
                Birthday = new DateTime(1996,03,08),
                Salary = 2500
            };

            Employee employee2 = new Employee
            {
                Name = "Roya",
                Surname = "Meherremova",
                Birthday = new DateTime(1993, 03, 19),
                Salary = 2300
            };

            Employee employee3 = new Employee
            {
                Name = "Chinara",
                Surname = "Ibadova",
                Birthday = new DateTime(1999, 09, 24),
                Salary = 2800
            };

            Employee employee4 = new Employee
            {
                Name = "Aqshin",
                Surname = "Hummetov",
                Birthday = new DateTime(1995, 12, 24),
                Salary = 3000
            };

            Employee employee5 = new Employee
            {
                Name = "Tural",
                Surname = "Huseynov",
                Birthday = new DateTime(1990, 03, 25),
                Salary = 1900
            };

            Employee employee6 = new Employee
            {
                Name = "David",
                Surname = "Abbasov",
                Birthday = new DateTime(2003, 10, 21),
                Salary = 1500
            };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);

            
            return employees;
        }
    }
}
