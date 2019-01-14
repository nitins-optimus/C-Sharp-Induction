using System;

namespace GenCollectnEmployee
{
    public delegate void MyGenericDelegate<T>(T a, T b);

    class Program
    {
        static void Main(string[] args)
        {
            #region Using EmployeeCollection

            Console.WriteLine("Using EmployeeCollection\n");

            EmployeeCollection<Employee> a = new EmployeeCollection<Employee>();

            a.AddEmployee(new Employee("Nitin", "Sharma", 23));
            Employee e = a.GetEmployee(0);

            Console.WriteLine(e.EmployeeData + "\n");
        }       
    }
}
#endregion
