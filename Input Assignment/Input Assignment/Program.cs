using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type any whole number.");
            string userText = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Owner\Desktop\Basic_C#_Projects\input_assignment_log.txt", userText);
            string printUserText = File.ReadAllText(@"C:\Users\Owner\Desktop\Basic_C#_Projects\input_assignment_log.txt");
            string path = @"C:\Users\Owner\Desktop\Basic_C#_Projects\input_assignment_log.txt";
            Console.WriteLine("\nYour number was succesfully written as {0} to location {1}", printUserText, path);
            Console.ReadLine();

        }
    }
}
