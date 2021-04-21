using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plase enter the current day of the week below: ");
            string userDayInput = Console.ReadLine();

            try
            {
                daysoftheWeek userInput = (daysoftheWeek)Enum.Parse(typeof(daysoftheWeek), userDayInput); //Enum.parse converts string array into enum; typeof gets System.Type
                Console.WriteLine((int)userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public enum daysoftheWeek
        {
            Monday,
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday, 
            Sunday
        }
    }
}
