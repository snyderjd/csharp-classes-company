using System;

namespace PracticeCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            // public Employee(string firstName, string lastName, string title, DateTime startDate)
            // {
            //     FirstName = firstName;
            //     LastName = lastName;
            //     Title = title;
            //     _startDate = startDate;
            // }
            // public Company(DateTime dateFounded, string name)
            // {
            //     _dateFounded = dateFounded;
            //     _name = name;
            //     Employees = new List<Employee>();
            // }

            Company NSS = new Company(new DateTime(2012, 1, 15), "Nashville Software School");

            Employee CEO = new Employee("John", "Wark", "CEO", new DateTime(2012, 01, 15));
            Employee headInstructor = new Employee("Steve", "Brownlee", "Head Instructor", new DateTime(2012, 01, 15));
            Employee instructor = new Employee("Bryan", "Nilsen", "Instructor", new DateTime(2018, 07, 01));

            NSS.Employees.Add(CEO);
            NSS.Employees.Add(headInstructor);
            NSS.Employees.Add(instructor);

            NSS.ListEmployees();

        }
    }
}
