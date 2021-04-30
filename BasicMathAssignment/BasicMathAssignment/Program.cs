using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number and type it below: ");
            string userNum = Console.ReadLine();                            // get user input number
            decimal userNumConvert = Convert.ToDecimal(userNum);            // converts user input number to decimal in case a decimal number is entered instead of an integer;  
                                                                            //decimal also accounts for a larger input than float or double, float loses precision at 6 digits
            decimal mulptiply50 = userNumConvert * 50;
            Console.WriteLine(userNum + " times 50 equals: " + mulptiply50);

            decimal add25 = userNumConvert + 25;
            Console.WriteLine(userNum + " plus 25 equals: " + add25);

            decimal divideTwelveHalf = userNumConvert / 12.5m;      // m denotes decimal 
            Console.WriteLine(userNum + " divided by 12.5 equals: " + divideTwelveHalf);

            bool greater50 = userNumConvert > 50;
            Console.WriteLine("Is " + userNum + " greater than 50? True or False: " + greater50);

            decimal divide7Remainder = userNumConvert % 7;
            Console.WriteLine( userNum + " divide by 7 with a remainder of: " + divide7Remainder);

            Console.ReadLine();
        }
    }
}
