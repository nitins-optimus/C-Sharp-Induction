using System;
using System.Collections.Generic;
using System.Text;

namespace GenCollectnEmployee
{
    public class Employee
    {
        string FirstName;
        string LastName;
        int Age;

        public Employee() { }
        public Employee(string fName, string lName, int Age)
        {
            this.Age = Age;
            this.FirstName = fName;
            this.LastName = lName;
        }

        public string EmployeeData
        {
            get { return String.Format("{0} {1} is {2} years old", FirstName, LastName, Age); }
        }
    }
}
