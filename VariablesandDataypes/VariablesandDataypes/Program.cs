using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDataypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program 
            //Console.WriteLine("What is your is name?");
            //string yourName = Console.ReadLine(); 
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            // C# data types
            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTyemp = -23;
            char questionsMark = '\u2103';
            decimal moneyInBank = 100.5m; //m for compiler to recognize decimal
            double heightInCentimeters = 211.53408958;
            float secondsLeft = 2.62f; //f for float - 7 decimal places
            short tempOnMars = -341;
            string myName = "Sky";


            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = false;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            //Console.WriteLine(questionsMark);
            //Console.ReadLine();
        }
    }
}
