using System;
using System.Collections.Generic;

namespace PracticeCompany
{
    public class Company
    {
        private DateTime _dateFounded;
        private string _name { get; set; }
        public List<Employee> Employees { get; set; }

        public Company(DateTime dateFounded, string name)
        {
            _dateFounded = dateFounded;
            _name = name;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach(Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Title}");
            }
        }

    }
}