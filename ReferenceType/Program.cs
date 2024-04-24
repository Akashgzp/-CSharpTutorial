using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    internal class Program
    {
        class Employee
        {
            public int age = 10;
        }
        static void Main(string[] args)
        {
            // Reference Type 

            Employee emp = new Employee();
            Console.WriteLine(emp.age);

        }
    }
}
