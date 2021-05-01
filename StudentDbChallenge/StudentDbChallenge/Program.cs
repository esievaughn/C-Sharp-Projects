using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentDbChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var studie = new Student { FirstName = "Kermit"};
                
                ctx.Students.Add(studie);
                ctx.SaveChanges();
                Console.WriteLine("{0} has been added to the student database.", studie.FirstName);
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
