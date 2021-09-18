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
        const int FEET_IN_A_YARD = 3;

        public static decimal FeetToInches(decimal inputInFeet)
        {
            return inputInFeet * INCHES_IN_A_FOOT;
        }

        public static decimal InchesToFeet(decimal inputInInches)
        {
            return inputInInches / INCHES_IN_A_FOOT;
        }

        public static decimal FeetToYards(decimal inputInFeet)
        {
            return inputInFeet / FEET_IN_A_YARD;
        }

        public static decimal YardsToFeet(decimal inputInYards)
        {
            return inputInYards * FEET_IN_A_YARD;
        }
    }
}
