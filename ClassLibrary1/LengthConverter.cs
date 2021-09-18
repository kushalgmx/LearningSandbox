using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class LengthConverter
    {
        const int INCHES_IN_A_FOOT = 12;

        public static decimal FeetToInches(decimal inputInFeet)
        {
            return inputInFeet * INCHES_IN_A_FOOT;
        }
    }
}
