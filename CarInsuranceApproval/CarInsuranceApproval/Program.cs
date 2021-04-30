using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Answer a few simple screening questions to see if you qualify for car insurance.");

            Console.WriteLine("\nWhat is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHave you ever had a DUI? Please answer true or false.");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int userSpeedingTicket = Convert.ToInt32(Console.ReadLine());

            bool qualifyInsurance = (userAge > 15 && userDUI == false && userSpeedingTicket <= 3);      // each condition must be met to qualify; qualify determined in boolean 
            Console.WriteLine("\nThank you for your input. Let's see if you are qualified for car insurance: " + qualifyInsurance);

            Console.ReadLine();

        }
    }
}
