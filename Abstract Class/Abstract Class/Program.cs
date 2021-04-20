using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            Employee employee1 = new Employee() { FirstName = "Apple", LastName = "Banana", ID = 84728 };
            Employee employee2 = new Employee() { FirstName = "Pancake", LastName = "Waffle", ID = 84729 };

            employee.SayName();
            Console.ReadLine();

            IQuittable quittable = new Employee() { FirstName = "Lester", LastName = "Burnham" };
            quittable.Quit();
            Console.ReadLine();

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine();
        }
    }
}
