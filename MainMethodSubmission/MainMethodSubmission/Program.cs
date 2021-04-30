using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Math codeMath = new Math(); //instantiate

            //INTEGER//
            Console.WriteLine("Please input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int wholetimesTwo = codeMath.timesTwo(num);

            Console.WriteLine(num + " times 2 " + "equals: " + wholetimesTwo);
            Console.ReadLine();

            //DECIMAL//
            Console.WriteLine("Please input a decimal number: ");
            decimal dec = Convert.ToDecimal(Console.ReadLine());

            decimal dectimesTwo = codeMath.timesTwo(dec);

            Console.WriteLine(dec + " times 2, " + "times 2 again, " + "equals: " + dectimesTwo);
            Console.ReadLine();

            //STRING//
            Console.WriteLine("Please input a number: ");
            string str = Console.ReadLine();

            int strtimesTwo = codeMath.timesTwo(str);

            Console.WriteLine(str + " times 2, " + " then divided by 2," + " equals: " + strtimesTwo);
            Console.ReadLine();
        }
    }
}
