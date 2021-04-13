using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    public class Math
    {
        public int timesTwo(int num)
        {
            return num * 2;
        }
        public decimal timesTwo(decimal dec)
        {
            return dec * 2 *2;
        }
        public int timesTwo(string str)
        {
            int strConvert = Convert.ToInt32(str);
            return (strConvert * 2) / 2;
        }
    }
}
