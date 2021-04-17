using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMulitMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide divideOb = new Divide();

            Console.WriteLine("Please write a whole number below: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            divideOb.division(userNum1, out int product1);
            Console.WriteLine(userNum1 + " divided by 2 equals: " + product1);
            Console.ReadLine();


            Console.WriteLine("Please write a decimal number below: ");
            double userNum2 = Convert.ToDouble(Console.ReadLine());
            
            divideOb.division(userNum2, out double product2);
            Console.WriteLine(userNum2 + " divided by 4 equals: " + product2);
            Console.ReadLine();

            Console.WriteLine("Please write a whole number below: ");
            int userNum3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userNum3 + " times 2 equals: " + StaticClass.multiplication(userNum3));  //static method calls by class name instead of creating object instance
            Console.ReadLine();

        }
    }
}
