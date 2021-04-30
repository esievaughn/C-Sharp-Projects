using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<int> numbers = new List<int>() { 2947, 2434, 54367, -4564, 96, 23, 243, 9427 };

                Console.WriteLine("Please input a number.");
                double userNum = Convert.ToDouble(Console.ReadLine());

                foreach (double num in numbers)
                {
                    double quotient = num / userNum;
                    Console.WriteLine(num + " divided by " + userNum + " equals: " + quotient);
                }

                //catch (DivideByZeroException)  DOUBLE accounts division by 0 because it approximates, returns infinity. INT does not define infinity, and must throw DIVIDEBYZERO exception
                //{
                //    Console.WriteLine("Cannot divide by zero. Please choose another number.");
                //}
                if (userNum == 0)
                {
                    Console.WriteLine("\nSorry, dividing by zero is undefined. Please try a new number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nThe program has exited the try/catch block.");
                Console.ReadLine();
            }

        }
    }
}
