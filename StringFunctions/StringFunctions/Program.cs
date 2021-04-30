using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quotes = "The lady said, \"Hello\", Jesse. \nHello on a new line \n \tHello on a tab";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(quotes);
            //Console.WriteLine(fileName);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);
            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder(); //creates instance of StringBuilder

            sb.Append("My name is Jesse");


                        Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
