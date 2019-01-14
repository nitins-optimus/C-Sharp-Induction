using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GenCollectnEmployee
{
    public class EmployeeCollection<T> : IEnumerable<T> where T : Employee
    {
        List<T> empList = new List<T>();

        public void AddEmployee(T e)
        {
            empList.Add(e);
        }

        public T GetEmployee(int index)
        {
            return empList[index];
        }

        //Compile time Error if we do not use where constrain
        public void PrintEmployeeData(int index)
        {
            Console.WriteLine(empList[index].EmployeeData);
        }

        //foreach support
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return empList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return empList.GetEnumerator();
        }
    }
}
