using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // BOOLEAN COMPARISON USING A WHILE STATEMENT 
            int i = 0;

            while (i < 10)                      // while i is less than 10 = true, run loop
            {
                Console.WriteLine("i = {0}", i); // {} place holder starting at index 0, write i value to console

                i++;                            // increment by 1

                if (i > 10)                     // if i is greater than 10, exit while loop using break statement
                    break;
            }


            // BOOLEAN COMPARISON USING A DO WHILE STATEMENT
            int x = 10;

            do
            {
                Console.WriteLine("x = {0}", x); // {} place holder, write x value to console
                
                x--;                            // decrement by 1

            } 
            while (x > 0);                      // while x > 0 = true, then loop runs;  while x > 0 = false, exit loop

            Console.Read();
        }
    }
}
