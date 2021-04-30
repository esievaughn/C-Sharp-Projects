using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class VoidClass
    {
        public void Sub(int num1, int num2) //void method does not return values
        {
            int result = num1 - 10; //math performed on first integer
            Console.WriteLine(num2); //only second integer is written to the console
        }
    }
}
