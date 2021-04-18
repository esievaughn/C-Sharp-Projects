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

            employee.SayName();
            Console.ReadLine();

            IQuittable quittable = new Employee() { FirstName = "Lester", LastName = "Burnham" };
            quittable.Quit();
            Console.ReadLine();
    }
    }
}
