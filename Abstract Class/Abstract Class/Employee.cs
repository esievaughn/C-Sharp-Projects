using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person
    {
        public override void SayName() //override for abstract method
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
