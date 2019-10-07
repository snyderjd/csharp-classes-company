using System;
using System.Collections.Generic;

namespace PracticeCompany
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        private DateTime _startDate;

        public Employee(string firstName, string lastName, string title, DateTime startDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            _startDate = startDate;
        }
    }
}