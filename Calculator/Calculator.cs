﻿using System;
namespace Calculator
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0.0;
            SecondNumber = 0.0;
            NumberInMemory = 0.0;
        }

        override
        public string ToString() 
        {
            return String.Format("First number: {0} \n Second number: {1} \n Number in memory: {2}", FirstNumber, SecondNumber, NumberInMemory);
        }

        public double SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        public double MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public double SumInBetween()
        {
            int sum = 0;
            //TODO - Fix this loop
            for (int i = 1; i < 5; i++)
            {

            }

                return sum;
        }
    }
}