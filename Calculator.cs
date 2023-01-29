using System;

namespace Calculator
{
	public class Calculator : ICalculator
	{
		public double add(double a, double b)
        {
            return a + b;
        }

        public double subtract(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double divide(double a, double b)
        {

            double result = 0.0;

            // **** divide integers (may throw exception) ****
            try
            {
                 result = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", a);
            }

            // **** ****
            return result;
        }
    }
}
