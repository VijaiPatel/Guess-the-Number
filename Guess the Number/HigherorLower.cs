using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class HigherorLower
    {
        public String whereisthenumber(int a, int b)// a will be the random number, b will be user input
        {
            // need to determine whether a is greater or lower than b
            if (a==b)
            {
                return "You got it!";
            }
            else if (b>a)
            {
                return "Higher";
            }
            else
            {
                return "Lower";
            }
        }
    }
}
