﻿using System;

namespace ClassLibrary1
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }
    }
}
