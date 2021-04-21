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
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", ID = 4};
            Employee employee1 = new Employee() { FirstName = "Apple", LastName = "Banana", ID = 84728 };
            Employee employee2 = new Employee() { FirstName = "Pancake", LastName = "Waffle", ID = 84729 };
            Employee employee3 = new Employee() { FirstName = "Fried", LastName = "Soapapilla", ID = 3858 };
            Employee employee4 = new Employee() { FirstName = "Cinnamon", LastName = "Toast", ID = 2929 };
            Employee employee5 = new Employee() { FirstName = "Joe", LastName = "Schmoe", ID = 2 };
            Employee employee6 = new Employee() { FirstName = "Joe", LastName = "Doe", ID = 09229 };
            Employee employee7 = new Employee() { FirstName = "Apple", LastName = "Fritter", ID = 2308 };
            Employee employee8 = new Employee() { FirstName = "Strawberry", LastName = "Jam", ID = 5399 };
            Employee employee9 = new Employee() { FirstName = "Blueberry", LastName = "Muffin", ID = 0298 };
            Employee employee10 = new Employee() { FirstName = "Pecan", LastName = "Pie", ID = 76049 };

            List<Employee> employees = new List<Employee>() { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    Console.WriteLine("Iterating through a list with a foreach loop to find the name Joe: " + emp.FirstName);
                }
            }

            List<Employee> newList = employees.Where(x => x.FirstName == "Joe").ToList(); //same as above but with lambda expression
            foreach (Employee emp in newList)
            {
                Console.WriteLine("Iterating through list with a lambda expression to find Joe: " + emp.FirstName);
            }

            List<Employee> empID = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee emp in empID)
            { 
                Console.WriteLine("Employees with an ID greater than five: " + " " + emp.FirstName + " " + emp.LastName + " " + emp.ID);
            }

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
