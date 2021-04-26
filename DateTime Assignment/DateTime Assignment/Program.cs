using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is {0}", DateTime.Now);
            Console.WriteLine("Please input the number of hours to add to the current time:");
            int userInputHours = Convert.ToInt32(Console.ReadLine());
            DateTime timeWithUserInputHoursAdded = DateTime.Now.AddHours(userInputHours);
            Console.WriteLine("In {0} hours the time will be {1} ", userInputHours, timeWithUserInputHoursAdded);
            Console.ReadLine();

        }
    }
}
