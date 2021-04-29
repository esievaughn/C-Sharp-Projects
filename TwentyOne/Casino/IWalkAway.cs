using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway  //I in front, so know it is an interface
    {
        void WalkAway(Player player); //interface is always public
    }
}
