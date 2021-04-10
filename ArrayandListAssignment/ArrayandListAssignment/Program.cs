using System;
using System.Collections.Generic;


namespace ArrayandListAssignment
{
    class Program
    {
        static void Main()
        {

            string[] bikeArray = { "Trek", "Specialized", "Surly", "Kona", "Cannondale", "Giant" };
            Console.WriteLine("Please pick a number betweem 0 and 5 to get your bike brand.");  // 0 and 5 correspond to number of indices in array
            int bikeIndices = Convert.ToInt32(Console.ReadLine()); // variable that converts the number picked from user to an integer to be used in following statements

            if (bikeIndices >= 0 && bikeIndices <= 5) // if number chosen is within the number of indices 
            {
                Console.WriteLine("Your bike brand is " + bikeArray[bikeIndices]);
                Console.ReadLine();
            }
            else if (bikeIndices < 0  || bikeIndices > 5)
            {
                Console.WriteLine("Sorry, you did not choose a number between 0 and 5.");
                Console.ReadLine();
            }

            int[] numArray = { 15, 30, 45, 60, 75, 90, 105 };
            Console.WriteLine("Thank you, now please choose a number between 0 and 6 to get a multiple of 15");
            int  numIndices = Convert.ToInt32(Console.ReadLine());

            if (numIndices >= 0 && numIndices <= 6)
            {
                Console.WriteLine("Your number is: " + numArray[numIndices]) ;
                Console.ReadLine();
            } 
            else if (numIndices < 0 || numIndices > 6)
            {
                Console.WriteLine("Sorry, you did not choose a number between 0 and 6.");
                Console.ReadLine();
            }

            List<string> mountainBikes = new List<string>();
            mountainBikes.Add("Santa Cruz");
            mountainBikes.Add("Yeti");
            mountainBikes.Add("Pivot Cycles");
            mountainBikes.Add("Salsa Cycles");
            mountainBikes.Add("YT Industries");

            Console.WriteLine("Please choose a number between 0 and 4 to get a mountain bike brand.");
            int mbIndices = Convert.ToInt32(Console.ReadLine());

            if (mbIndices > 0 && mbIndices < 5)
            {
                Console.WriteLine("Your bike brand is: " + mountainBikes[mbIndices]);
                Console.ReadLine();
            }
            else //if user does not input correct number, run the following in console and then end program
            {
                Console.WriteLine("Sorry, you did not choose a number between 0 and 4.");
                Console.ReadLine();
            }

        }
    }
}
