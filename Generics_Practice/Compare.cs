using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    class Compare<AnyTypeYouWant>
    {
        //returns true if the inputs are equal, returns false if not.
        public bool CompareUserInput(AnyTypeYouWant data1, AnyTypeYouWant data2)
        {
            if (data1.Equals(data2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
