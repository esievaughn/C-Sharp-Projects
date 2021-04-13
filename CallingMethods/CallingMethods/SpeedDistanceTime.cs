using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class SpeedDistanceTime
    {
        public double Speed(double distance, double time)
        {
            double speedResult = distance / time;
            return speedResult;
        }
        public double Distance(double speed2, double time2)
        {
            double distanceResult = speed2 * time2;
            return distanceResult;
        }
        public double Time(double distance3, double speed3)
        {
            double timeResult = distance3 / speed3;
            return timeResult;
        }
    }   
}
