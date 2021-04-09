using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            int total = num1 + num2;
            Console.WriteLine(total);

          
            int total2 = num1 - num2;
            Console.WriteLine(total2);

            
            int total3 = num1 * num2;
            Console.WriteLine(total3);

            
            double total4 = (double) num1 / num2;
            Console.WriteLine(total4);

            int footballNum = 55;
            string footballPlayer = "Skylar";
            Console.WriteLine(footballPlayer + "'s " + "football number is: " + footballNum + ".");
            Console.ReadLine();
        }
    }
}
