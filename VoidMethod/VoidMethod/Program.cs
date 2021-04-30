using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidClass displayVoid = new VoidClass();

            Console.WriteLine("Please write a whole number below: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            displayVoid.Sub(50, 200); //call method passing in two numbers
            displayVoid.Sub(num1, num2: 100); //call method specifying by name
            Console.ReadLine();
        }
    }
}
