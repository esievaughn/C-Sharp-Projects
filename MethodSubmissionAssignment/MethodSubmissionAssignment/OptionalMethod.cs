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
        public int OpMthd(int userNum1, [Optional] int userNum2) //optional parameters always after other parameters; Optional using Runtime.InteropServices does not require default value to be specified, already has its own default values
        {
            return userNum1 + userNum2;
        }
    }
}
