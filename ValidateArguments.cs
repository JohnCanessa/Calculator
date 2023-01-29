using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ValidateArguments : IValidateArguments
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="application"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsValid(CalculatorApplication application)
        {
            //// **** ****
            //throw new NotImplementedException("Simulate this real dependency being hard to use.");

            // **** initialization ****
            double result = 0.0;

            // **** for ease of use ****
            var firstOp = application.firstOp;
            var secondOp = application.secondOp;

            // **** compute and return result ****
            switch (application.op)
            {
                case "+":
                    result = firstOp + secondOp;
                    break;

                case "-":
                    result = firstOp - secondOp;
                    break;

                case "*":
                    result = firstOp * secondOp;
                    break;

                case "/":
                    result = firstOp / secondOp;
                    break;

                default:
                    throw new InvalidOperationException();
            }

            // **** ****
            return result.Equals(application.result);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="application"></param>
        /// <param name="areValid"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void IsValid(CalculatorApplication application, out bool areValid)
        {
            throw new NotImplementedException("Simulate this real dependency being hard to use.");
        }
    }
}
