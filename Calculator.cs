using System;

namespace Calculator
{
	public class Calculator : ICalculator
	{
		public int add(int a, int b)
        {
            return a + b;
        }

        public int subtract(int a, int b)
        {
            return a - b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public double divide(int a, int b)
        {
            // **** ****
            if (b == 0)
            {
                throw new DivideByZeroException("divide <<< b: {0}", b);
            }

            // **** divide integers ****
            return a / b;
        }
    }
}
