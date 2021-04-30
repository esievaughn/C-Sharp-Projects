using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MethodSubmissionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            OptionalMethod codeOp = new OptionalMethod(); 

            Console.WriteLine("Please enter a whole number below: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optional to enter a second whole number below: ");
            string userNum2 = Console.ReadLine();
            bool userNull = string.IsNullOrEmpty(userNum2); //IsNullOrEmpty only evalutes string values; accounts blank user input

            if (userNull)
            {   int add = codeOp.OpMthd(userNum1);
                Console.WriteLine("\n" + userNum1 + " plus "+ "0" + " equals: " + add); //default value when user does not input a second number is 0
            }
            else
            {
                int userNum2Convert = Convert.ToInt32(userNum2); //originally used string method to get bool so have to convert to int
                int add2 = codeOp.OpMthd(userNum1, userNum2Convert);
                Console.WriteLine("\n" + userNum1 + " plus " + userNum2 + " equals: " + add2);
                Console.ReadLine();
            }

        }
    }
}
