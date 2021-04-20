using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public override void SayName() //override for abstract method
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
        public void Quit()
        {
            Console.WriteLine("{0} {1} is quitting!", FirstName, LastName);
        }
        public static bool operator == (Employee E1, Employee E2) // == requires a matching != to also be defined
        {
            if (E1.ID == E2.ID)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator != (Employee E1, Employee E2) 
        {
            if (E1.ID == E2.ID)
            {
                return false; //"!=" not equal is false 
            }
            else
                return true; //"!=" not equal is true 
        }
    }
}
