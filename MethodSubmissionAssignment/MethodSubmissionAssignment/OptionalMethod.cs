using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace MethodSubmissionAssignment
{
    public class OptionalMethod
    {
        public int OpMthd(int userNum1, [Optional] int userNum2) //Optional using Runtime.InteropServices does not require default value to be specified
        {
            return userNum1 + userNum2;
        }
    }
}
