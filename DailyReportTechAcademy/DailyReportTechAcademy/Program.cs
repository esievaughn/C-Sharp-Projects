using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Teach Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            string pageNumInput = Console.ReadLine();
            int pageNumConvert = Convert.ToInt32(pageNumInput); //casting - converting string user input to an integer

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\". ");
            string helpInput = Console.ReadLine();
            bool helpConvert = Convert.ToBoolean(helpInput); // casting - converting string user input to boolean

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiencesInput = Console.ReadLine();

            Console.WriteLine("\nIs there any feedback you'd like to provide? Please be specific.");
            string feedbackInput = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study?");
            string hoursInput = Console.ReadLine();
            int hoursInputConvert = Convert.ToInt32(hoursInput); // converting string user input to integer

            Console.WriteLine("\nThank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}