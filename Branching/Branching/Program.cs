using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number";
            Console.WriteLine(result);







            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name>");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temp.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is cooler than room temp.");
            //}
            //else 
            //{
            //    Console.WriteLine("Something went wrong.");
            //}



            //int currentTemp = 65;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is cooler than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            Console.ReadLine();
            
        }
    }
}
