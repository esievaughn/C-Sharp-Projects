using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMulitMethods
{
     class Divide
    {
        public void division(int userNum1, out int product1)
        {
            product1 = userNum1 / 2;
        }
        public void division(double userNum2, out double product2) //overloaded method, different user parems and datatype
        {
            product2 = userNum2 / 4;
        }
    }
}
