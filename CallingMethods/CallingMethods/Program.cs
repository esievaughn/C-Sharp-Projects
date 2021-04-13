using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeedDistanceTime SDT = new SpeedDistanceTime(); //INSTANTIATE NEW OBJECT
            // SPEED //
            Console.WriteLine("Let's calculate speed! Please enter a number that will represent distance: ");
            double distance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nGreat, thank you! Now please enter a number that will represent time: ");
            double time1 = Convert.ToDouble(Console.ReadLine());

            double speed1 = SDT.Speed(distance1, time1);
            Console.WriteLine("\nSpeed equals: " + speed1);
            Console.ReadLine();

            // DISTANCE //
            Console.WriteLine("Now let's calculate distance. Please enter a number that will represent speed: ");
            double speed2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nGreat, thank you! Now please enter a number that will represent time: ");
            double time2 = Convert.ToDouble(Console.ReadLine());

            double distance2 = SDT.Distance(speed2, time2);
            Console.WriteLine("\nDistance equals: " + distance2);
            Console.ReadLine();

            // TIME //
            Console.WriteLine("\nNow let's calculate time. Please enter a number that will represent distance: ");
            double distance3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nGreat, thank you! Now please enter a number that will represent speed: ");
            double speed3 = Convert.ToDouble(Console.ReadLine());

            double time3 = SDT.Time(distance3, speed3);
            Console.WriteLine("\nTime equals: " + time3);
            Console.ReadLine();
        }
    }
}
