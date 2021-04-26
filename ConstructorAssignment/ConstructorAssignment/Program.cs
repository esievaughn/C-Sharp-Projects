using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string FN = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string LN = Console.ReadLine();
            var newUser = new User(FN, LN);
            const string userWelcome = "Welcome,";
            Console.WriteLine("{0} {1} {2}! You were succesfully added as a new user today at {3}", userWelcome, newUser.FirstName, newUser.LastName, DateTime.Today );
            Console.ReadLine();
        }
    }
}
