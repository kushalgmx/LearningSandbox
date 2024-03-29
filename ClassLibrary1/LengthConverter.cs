﻿namespace ClassLibrary1
{
    public static class LengthConverter
    {
        const int INCHES_IN_A_FOOT = 12;
        const decimal METERS_IN_A_FOOT = 0.3048M;
        const int FEET_IN_A_YARD = 3;

        public static decimal FeetToInches(decimal inputInFeet)
        {
            return inputInFeet * INCHES_IN_A_FOOT;
        }

        public static decimal InchesToFeet(decimal inputInInches)
        {
            return inputInInches / INCHES_IN_A_FOOT;
        }

        public static decimal FeetToMeters(decimal inputInFeet)
        {
            return inputInFeet * METERS_IN_A_FOOT;
        }

        public static decimal MetersToFeet(decimal inputInMeters)
        {
            return inputInMeters / METERS_IN_A_FOOT;
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
