using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("hourly rate:");
            double p1HourlyRate = Convert.ToDouble(Console.ReadLine());         // converting to double in case of decimals 
            Console.WriteLine("hours worked per week:");
            double p1HoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("hourly rate:");
            double p2HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hours worked per week:");
            double p2HoursWorked = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAnnual Salary of Person 1:");
            double p1Salary = (p1HourlyRate * p1HoursWorked) * 52;         // 52 is the number of weeks in a year
            Console.WriteLine(p1Salary);

            Console.WriteLine("Annual Salary of Person 2:");
            double p2Salary = (p2HourlyRate * p2HoursWorked) * 52;         // 52 is the number of weeks in a year
            Console.WriteLine(p2Salary);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool compareSalary = p1Salary > p2Salary;
            Console.WriteLine(compareSalary);


            Console.ReadLine();

        }
    }
}
