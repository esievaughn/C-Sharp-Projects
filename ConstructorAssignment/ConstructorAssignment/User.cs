using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime userAdded { get; set; }

        public User(string FN, string LN) : this(FN, LN, DateTime.Today)
        {

        }

        public User(string FN, string LN, DateTime whenUserAdded)
        {
            FirstName = FN;
            LastName = LN;
            userAdded = whenUserAdded;
        }
    }
}
