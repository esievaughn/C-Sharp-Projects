using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Package Express. Please follow the instructions below.");
            Console.WriteLine("\nPlease input package weight below (numbers only, please):");
            double packageWeight = Convert.ToDouble(Console.ReadLine());


            if (packageWeight > 50.00) // decimal to denote double 
            {
                Console.WriteLine("\nSorry, your package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nThank you, please enter a few more dimensions.");

                Console.WriteLine("\nPackage Width:");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nPackage Height:");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nPackage Length:");
                double packageLength = Convert.ToDouble(Console.ReadLine());

                if ((packageWidth + packageHeight + packageLength) > 50)  
                {
                    Console.WriteLine("\nSorry, your package is too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nThank you! The estimated shipping cost for your package is: ");
                    double shippingQuote = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
                    double shippingCost = Convert.ToDouble(string.Format("{0:0.00}", shippingQuote)); // format to 2 decimal places only 
                    Console.WriteLine("\n$"+ shippingCost);
                    Console.ReadLine();
                }
            }

        }
    }
}
